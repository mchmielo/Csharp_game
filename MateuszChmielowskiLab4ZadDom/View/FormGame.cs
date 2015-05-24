using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MateuszChmielowskiLab4ZadDom.Model;
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
        Player currentPlayer;
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");

        public FormGame(Player player)
        {
            InitializeMap();
            currentPlayer = player;
        }

        private void InitializeMap()
        {
            InitializeComponent();
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.",
                      "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }
            mainMap.MapProvider = GMapProviders.OpenStreetMap;
            mainMap.Position = new PointLatLng(51.110, 17.030);
            mainMap.MinZoom = 0;
            mainMap.MaxZoom = 24;
            mainMap.Zoom = 12;
            mainMap.Overlays.Add(routes);
            mainMap.Overlays.Add(objects);
            mainMap.Overlays.Add(top);
            AddCarDealersToMap();
            AddGasStationsToMap();
            AddCurrentPlayerToMap();
        }

        private void AddCurrentPlayerToMap()
        {
            PointLatLng pos = new PointLatLng(Convert.ToDouble(PlayerStatus.GetPlayerStatusByPlayerID(currentPlayer.ID).GPSLatitude), Convert.ToDouble(PlayerStatus.GetPlayerStatusByPlayerID(currentPlayer.ID).GPSLongitude));
            GMapMarker currentMarker = new GMarkerGoogle(pos, Properties.Resources.Truck1);
            currentMarker.ToolTipText = currentPlayer.Login;
            currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            top.Markers.Add(currentMarker);
        }

        private void AddGasStationsToMap()
        {
            GMapMarker currentMarker;
            List<GasStation> gasStations = GasStation.GetAllGasStations();
            for (int i = 0; i < gasStations.Count; i++)
            {
                PointLatLng pos = new PointLatLng(Convert.ToDouble(gasStations[i].GPSLatitude), Convert.ToDouble(gasStations[i].GPSLongitude));
                currentMarker = new GMarkerGoogle(pos, new Bitmap(MateuszChmielowskiLab4ZadDom.Properties.Resources.gasStationPin));
                currentMarker.ToolTipText = gasStations[i].Name + Environment.NewLine + "Cena za litr:" + gasStations[i].Price;
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
                currentMarker.ToolTipText = carDealers[i].Name;
                currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                top.Markers.Add(currentMarker);
            }
        }

        private void AddOtherPlayersToMap()
        {
            GMapMarker currentMarker;
            List<CarDealer> carDealers = CarDealer.GetAllCarDealers();
            for (int i = 0; i < carDealers.Count; i++)
            {
                PointLatLng pos = new PointLatLng(Convert.ToDouble(carDealers[i].GPSLatitude), Convert.ToDouble(carDealers[i].GPSLongitude));
                currentMarker = new GMarkerGoogle(pos, new Bitmap(MateuszChmielowskiLab4ZadDom.Properties.Resources.carDealerPin));
                currentMarker.ToolTipText = carDealers[i].Name;
                currentMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                top.Markers.Add(currentMarker);
            }
        }
    }
}
