using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class Player
    {
        public static void AddPlayer(string Login, string Password)
        {
            Player player = new Player();
            player._Login = Login;
            player._Password = Password;
            DatabaseContext.dataContext.Players.InsertOnSubmit(player);
            DatabaseContext.dataContext.SubmitChanges();
        }

        public static bool IsLoginAvailable(string playerLogin)
        {
            if (((from player in DatabaseContext.dataContext.Players select player).Where(x => x.Login == playerLogin)).Count() > 0)
                return false;
            return true;
        }

        public static Player GetPLayerByLogin(string playerLogin)
        {
            return (from player in DatabaseContext.dataContext.Players where player.Login.Equals(playerLogin) select player).First();
        }

        public static List<Player> GetAllOnlinePlayers()
        {
            return (from player in DatabaseContext.dataContext.Players
                    from playerStatus in DatabaseContext.dataContext.PlayerStatus
                    where player.ID == playerStatus.PlayerID && playerStatus.IsOnline
                    select player).ToList();
        }

        public static bool CheckLogin(string playerLogin, string playerEncryptedPassword)
        {
            if ((from player in DatabaseContext.dataContext.Players select player).Where(x => x.Login == playerLogin && x.Password == playerEncryptedPassword).Count() > 0)
                return true;
            return false;
        }

        public static bool IsOnline(string login)
        {
            if ((from player in DatabaseContext.dataContext.Players
                 from playerStatus in DatabaseContext.dataContext.PlayerStatus
                 where player.Login.Equals(login) && player.ID == playerStatus.PlayerID && playerStatus.IsOnline
                 select player).Count() > 0)
                return true;
            return false;
        }
    }
}
