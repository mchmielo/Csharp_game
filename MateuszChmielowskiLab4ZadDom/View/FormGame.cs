using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MateuszChmielowskiLab4ZadDom.Controller;
using MateuszChmielowskiLab4ZadDom.Model;
using MateuszChmielowskiLab4ZadDom.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MateuszChmielowskiLab4ZadDom
{
    public partial class FormGame : Form
    {
        /// Zmienne służące do zminimalizowania zapytań bazodanowych.
        /// <summary>
        /// Wczytany z bazy obecny gracz.
        /// </summary>
        Player currentPlayer;
        /// <summary>
        /// Obecny samochód gracza.
        /// </summary>
        PlayerCar currentPlayerCar;
        /// <summary>
        /// Status obecnego gracza.
        /// </summary>
        PlayerStatus currentPlayerStatus;
        /// <summary>
        /// Model samochodu gracza.
        /// </summary>
        Car currentPlayerCarModel;
        PlayerQuest currentPlayerQuest;

        private double playerSpeed = 0;
        private bool onTheMission = false;
        private decimal timeToEndMission = 0;

        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay quests = new GMapOverlay("quests");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");

        private List<Keys> pressedKeys;
        private PointLatLng previousPosition;

        private System.Timers.Timer timerHalfSecond;
        private bool timerStartedEvent = false;

        public FormGame(Player player)
        {
            InitializeComponent();
            currentPlayer = player;
            UpdateCurrentPlayer();

            InitializeMap();
            pressedKeys = new List<Keys>();
            timerHalfSecond = new System.Timers.Timer(200);
            timerHalfSecond.Elapsed += timerHalfSecond_Elapsed;
            timerHalfSecond.Start();
        }

        private void UpdateCurrentPlayer()
        {
            currentPlayerCar = PlayerCar.GetPlayerCarByPlayerID(currentPlayer.ID);
            currentPlayerCarModel = Car.GetCarByID(currentPlayerCar.CarID);
            currentPlayerStatus = PlayerStatus.GetPlayerStatusByPlayerID(currentPlayer.ID);
        }

        private void InitializeMap()
        {
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                MessageBox.Show("Brak dostępu do Internetu.", "Brak dostępu do bazy danych.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            mainMap.MapProvider = GMapProviders.OpenStreetMap;  // wybranie dostawcy mapy
            mainMap.MinZoom = 16;                               // ustawienie przybliżenia mapy
            mainMap.MaxZoom = 16;
            mainMap.Zoom = 16;
            mainMap.Overlays.Add(routes);                       // dodanie 3 warstw do mapy
            mainMap.Overlays.Add(objects);                      // do warstw dodwane są później np. markery
            mainMap.Overlays.Add(top);
            mainMap.Overlays.Add(quests);

            mainMap.OnMarkerClick += mainMap_OnMarkerClick;

            AddCarDealersToMap();
            AddGasStationsToMap();
            AddCurrentPlayerToMap();
            AddOtherPlayersToMap();
            AddRandomQuestToMap();
            UpdateFuelLabel();
            UpdateGoldLabel();
        }

        private void mainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            decimal distance = MainController.CalculateDistanceInMetres(mainMap.Position, item.Position);
            if ( distance < 0.0001M)
            {
                StartAction(item.ToolTipText);
            }
        }

        private void StartAction(string p)
        {
            string[] splittedString = p.Split('|');
            int id = int.Parse(splittedString[1]);
            string actionName = splittedString[0];
            switch (actionName)
            {
                case "Stacja":
                    playerSpeed = 0;
                    timerHalfSecond.Stop();
                    FormGetGas formGetGas = new FormGetGas(currentPlayerCar.CarID, currentPlayer.ID, id);
                    formGetGas.ShowDialog();
                    break;
                case "Sprzedawca":
                    playerSpeed = 0;
                    break;
                case "Misja":
                    playerSpeed = 0;
                    timerHalfSecond.Stop();
                    FormMission formMission = new FormMission(currentPlayer.ID, id);
                    formMission.ShowDialog();
                    currentPlayerQuest = PlayerQuest.GetPlayerQuestByID(currentPlayer.ID, id);
                    onTheMission = true;
                    AddQuestEndToMap(id);
                    break;
                case "Koniec misji":
                    playerSpeed = 0;
                    quests.Clear();
                    onTheMission = false;
                    labelQuestTimer.Hide();
                    PlayerQuest.UpdatePlayerQuestEnded(currentPlayer.ID, currentPlayerQuest.QuestID);
                    currentPlayerStatus.CurrentGold += Quest.GetQuestByID(currentPlayerQuest.QuestID).Reward;
                    MessageBox.Show("Gratulacje, udało Ci się skończyć misję!");
                    AddRandomQuestToMap();
                    break;
                default:
                    break;
            }
            UpdateCurrentPlayer();
            timerHalfSecond.Start();
        }

        private void AddCurrentPlayerToMap()
        {
            PointLatLng pos = new PointLatLng(Convert.ToDouble(currentPlayerStatus.GPSLatitude), Convert.ToDouble(currentPlayerStatus.GPSLongitude));
            mainMap.Position = pos;
            previousPosition = pos;
        }

        private void AddGasStationsToMap()
        {
            GMapMarker currentMarker;
            List<GasStation> gasStations = GasStation.GetAllGasStations();
            for (int i = 0; i < gasStations.Count; i++)
            {
                PointLatLng pos = new PointLatLng(Convert.ToDouble(gasStations[i].GPSLatitude), Convert.ToDouble(gasStations[i].GPSLongitude));
                currentMarker = new GMarkerGoogle(pos, new Bitmap(MateuszChmielowskiLab4ZadDom.Properties.Resources.gasStationPin));
                currentMarker.ToolTipText = "Stacja|" + gasStations[i].ID + "|: " + gasStations[i].Name + Environment.NewLine + "Cena za litr:" + gasStations[i].Price;
                currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                top.Markers.Add(currentMarker);
            }
        }
        private void AddCarDealersToMap()
        {
            GMapMarker currentMarker;
            List<CarDealer> carDealers = CarDealer.GetAllCarDealers();
            for (int i = 0; i < carDealers.Count; i++)
            {
                PointLatLng pos = new PointLatLng(Convert.ToDouble(carDealers[i].GPSLatitude), Convert.ToDouble(carDealers[i].GPSLongitude));
                currentMarker = new GMarkerGoogle(pos, new Bitmap(MateuszChmielowskiLab4ZadDom.Properties.Resources.carDealerPin));
                currentMarker.ToolTipText = "Sprzedawca|" + carDealers[i].ID + "|: " + carDealers[i].Name;
                currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                top.Markers.Add(currentMarker);
            }
        }

        private void AddOtherPlayersToMap()
        {
            GMapMarker currentMarker;
            List<Player> players = Player.GetAllOnlinePlayers();
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].ID != currentPlayer.ID)
                {
                    PlayerStatus playerStatus = PlayerStatus.GetPlayerStatusByPlayerID(players[i].ID);
                    PointLatLng pos = new PointLatLng(Convert.ToDouble(playerStatus.GPSLatitude), Convert.ToDouble(playerStatus.GPSLongitude));
                    currentMarker = new GMarkerGoogle(pos, new Bitmap(MateuszChmielowskiLab4ZadDom.Properties.Resources.user));
                    currentMarker.ToolTipText = players[i].Login;
                    currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                    top.Markers.Add(currentMarker);
                }
            }
        }

        private void AddRandomQuestToMap()
        {
            GMapMarker currentMarker;
            Quest quest = Quest.GetRandomQuest();
            PointLatLng pos = new PointLatLng(Convert.ToDouble(quest.GPSFromLatitude), Convert.ToDouble(quest.GPSFromLongitude));
            currentMarker = new GMarkerGoogle(pos, new Bitmap(MateuszChmielowskiLab4ZadDom.Properties.Resources.quest));
            currentMarker.ToolTipText = "Misja|"+ quest.ID+"|:" + Environment.NewLine + quest.Description;
            currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            quests.Markers.Add(currentMarker);
        }

        private void AddQuestEndToMap(int questID)
        {
            GMapMarker currentMarker;
            Quest quest = Quest.GetQuestByID(questID);
            PointLatLng pos = new PointLatLng(Convert.ToDouble(quest.GPSToLatitude), Convert.ToDouble(quest.GPSToLongitude));
            currentMarker = new GMarkerGoogle(pos, new Bitmap(MateuszChmielowskiLab4ZadDom.Properties.Resources.quest));
            currentMarker.ToolTipText = "Koniec misji|" + quest.ID + "|:" + Environment.NewLine + quest.Description;
            currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            quests.Markers.Add(currentMarker);
            labelQuestTimer.Text = quest.MaxEndTime.ToString()+":00";
            timeToEndMission = quest.MaxEndTime;
            labelQuestTimer.Show();
        }

        private void UpdateGoldLabel()
        {
            labelPlayerMoney.Text = currentPlayerStatus.CurrentGold.ToString() + " $";
        }

        private void UpdateFuelLabel()
        {
            labelPlayerFuel.Text = ((int)(currentPlayerCar.FuelLevel)).ToString() + " %";
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pressedKeys.Contains(e.KeyCode))
                pressedKeys.Add(e.KeyCode);
            UpdateMapPosition();
        }

        private void FormGame_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
        }

        private void UpdateMapPosition()
        {
            foreach (Keys key in pressedKeys)
            {
                switch (key)
                {
                    case Keys.W:
                        if (playerSpeed < (double)currentPlayerCarModel.MaxSpeed)
                            playerSpeed += 0.1*(double)currentPlayerCarModel.MaxSpeed;
                        break;
                    case Keys.A:
                        mainMap.Bearing -= 1;
                        break;
                    case Keys.D:
                        mainMap.Bearing += 1;
                        break;
                    case Keys.S:
                        if (playerSpeed > 0)
                        {
                            if (playerSpeed > 0 && playerSpeed < 10)
                                playerSpeed = 0;
                            else
                                playerSpeed -= 0.3 * (double)currentPlayerCarModel.MaxSpeed;
                        }
                        else
                            playerSpeed = -10;
                        break;
                    default:
                        break;
                }
            }
        }
        void timerHalfSecond_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timerStartedEvent = true;
            double distance = ((playerSpeed*1000)/3600)*0.5/100000;
            decimal fuelConsumed = (MainController.CalculateDistance(previousPosition, mainMap.Position)) / (currentPlayerCarModel.FuelTankCapacity) * 100;
            decimal allFuel = currentPlayerCar.FuelLevel;
            allFuel -= fuelConsumed;
            currentPlayerStatus.GPSLatitude = (decimal)mainMap.Position.Lat;
            currentPlayerStatus.GPSLongitude = (decimal)mainMap.Position.Lng;
            currentPlayerCar.FuelLevel = allFuel;
            labelPlayerFuel.Invoke(new Action(()=> labelPlayerFuel.Text = ((int)(currentPlayerCar.FuelLevel)).ToString() + " %"));
            if (allFuel < 30)
            {
                if(allFuel < 15)
                    pictureFuel.Invoke(new Action(() => pictureFuel.Image = Properties.Resources.fuelRed));
                else
                    pictureFuel.Invoke(new Action(() => pictureFuel.Image = Properties.Resources.fuelYellow));
            }
            else
                pictureFuel.Invoke(new Action(() => pictureFuel.Image = Properties.Resources.fuelGreen));
            progressBarFuelLevel.Invoke(new Action(()=>progressBarFuelLevel.Value = (int)allFuel));
            mainMap.Invoke(new Action(() => mainMap.Position = MainController.NewPosition(mainMap.Position, mainMap.Bearing, distance)));
            labelSpeed.Invoke(new Action(() => labelSpeed.Text = playerSpeed.ToString() + "km/h"));
            labelPlayerMoney.Invoke(new Action(() => UpdateGoldLabel()));
            if (onTheMission)
            {
                timeToEndMission -= 0.1M;
                labelQuestTimer.Invoke(new Action(()=>labelQuestTimer.Text = timeToEndMission.ToString()));
                if (timeToEndMission <= 0)
                {
                    MissionTimeExpired();
                }
            }
            timerStartedEvent = false;
           // DatabaseContext.dataContext.SubmitChanges();
        }

        private void MissionTimeExpired()
        {
            quests.Clear();
            onTheMission = false;
            labelQuestTimer.Hide();
            MessageBox.Show("Czas misji upłynął.");
        }
        /// <summary>
        /// Metoda wylogowuje gracza po zamknięciu okna gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            PlayerStatus.SetPlayerOnline(currentPlayer.ID, false);
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerHalfSecond.Stop();
            if(timerStartedEvent)
                e.Cancel = true;
            timerHalfSecond.AutoReset = false;
            timerHalfSecond.SynchronizingObject = this;
            this.Close();
        }

        
    }
}
