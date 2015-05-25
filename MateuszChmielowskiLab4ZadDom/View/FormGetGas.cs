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

namespace MateuszChmielowskiLab4ZadDom.View
{
    public partial class FormGetGas : Form
    {
        private Car car;
        private PlayerCar playerCar;
        private PlayerStatus playerStatus;
        private GasStation gasStation;

        public FormGetGas(int playerCarID, int playerID, int gasStationID)
        {
            
            InitializeComponent();

            car = Car.GetCarByID(playerCarID);
            playerCar = PlayerCar.GetPlayerCarByPlayerID(playerID);
            playerStatus = PlayerStatus.GetPlayerStatusByPlayerID(playerID);
            gasStation = GasStation.GetGasStationByID(gasStationID);
            int maxFuelLevel = (int)(car.FuelTankCapacity - car.FuelTankCapacity*playerCar.FuelLevel/100);
            labelMax.Text = maxFuelLevel.ToString();
            trackBarFuelAmount.Maximum = maxFuelLevel;
            trackBarFuelAmount.Minimum = 0;
            trackBarFuelAmount.Value = maxFuelLevel;
            textBoxToPay.Text = (maxFuelLevel * gasStation.Price).ToString();
            labelStationName.Text = gasStation.Name;
        }

        private void trackBarFuelAmount_Scroll(object sender, EventArgs e)
        {
            textBoxToPay.Text = (trackBarFuelAmount.Value * gasStation.Price).ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            playerCar.FuelLevel += (trackBarFuelAmount.Value/car.FuelTankCapacity)*100;
            playerStatus.CurrentGold -= decimal.Parse(textBoxToPay.Text);
            DatabaseContext.dataContext.SubmitChanges();
            this.Close();
        }
    }
}
