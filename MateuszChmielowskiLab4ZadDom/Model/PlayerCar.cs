using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class PlayerCar
    {
        /// <summary>
        /// Funkcja dodaje podany samochód do podanego gracza.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="car"></param>
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
        /// <summary>
        /// Funkcja zwraca samochód gracza na podstawie jego ID.
        /// </summary>
        /// <param name="playerID"></param>
        /// <returns></returns>
        public static PlayerCar GetPlayerCarByPlayerID(int playerID)
        {
            return (from playerCar in DatabaseContext.dataContext.PlayerCars select playerCar).Where(x => x.PlayerID == playerID).First();
        }
        /// <summary>
        /// Funkcja aktualizuje pole fuelLevel samochodu gracza o podanym ID.
        /// </summary>
        /// <param name="playerID"></param>
        /// <param name="fuelLevel"></param>
        public static void UpdateFuelLevel(int playerID, decimal fuelLevel)
        {
            PlayerCar playersCar = (from playerCar in DatabaseContext.dataContext.PlayerCars select playerCar).Where(x => x.PlayerID == playerID).First();
            playersCar.FuelLevel = fuelLevel;
            DatabaseContext.dataContext.SubmitChanges();
        }
    }
}
