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
    }
}
