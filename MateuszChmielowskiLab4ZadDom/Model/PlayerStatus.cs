using MateuszChmielowskiLab4ZadDom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class PlayerStatus
    {
        public static void AddPlayerStatus(int playerID)
        {
            PlayerStatus playerStatus = new PlayerStatus();
            playerStatus.IsOnline = false;
            playerStatus.GPSLatitude = MainController.RandomLatitude();
            playerStatus.GPSLongitude = MainController.RandomLongitude();
            playerStatus.PlayerID = playerID;
            playerStatus.CurrentGold = 10000;
            playerStatus.CurrentCarID = 1;
            DatabaseContext.dataContext.PlayerStatus.InsertOnSubmit(playerStatus);
            DatabaseContext.dataContext.SubmitChanges();
        }

        public static PlayerStatus GetPlayerStatusByPlayerID(int playerID)
        {
            var query = from playerStatus in DatabaseContext.dataContext.PlayerStatus select playerStatus;
            return query.Where(x => x.PlayerID == playerID).First();
        }
    }
}
