using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class PlayerCar
    {
        public static void AddPlayerCar(Player player, Car car)
        {
            PlayerCar playerCar = new PlayerCar();
            playerCar.PlayerID = player.ID;
            playerCar.CarID = car.ID;
            playerCar.Roadworthy = true;
            playerCar.FuelLevel = 100;
            DatabaseContext.dataContext.PlayerCars.InsertOnSubmit(playerCar);
            DatabaseContext.dataContext.SubmitChanges();
        }

        public static PlayerCar GetPlayerCarByPlayerID(int playerID)
        {
            return (from playerCar in DatabaseContext.dataContext.PlayerCars select playerCar).Where(x => x.PlayerID == playerID).First();
        }

        public static void UpdateFuelLevel(int playerID, decimal fuelLevel)
        {
            PlayerCar playersCar = (from playerCar in DatabaseContext.dataContext.PlayerCars select playerCar).Where(x => x.PlayerID == playerID).First();
            playersCar.FuelLevel = fuelLevel;
            DatabaseContext.dataContext.SubmitChanges();
        }
    }
}
