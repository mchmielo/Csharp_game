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
        /// <summary>
        /// Funkcja dodaje nowego gracza.
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        public static void AddPlayer(string Login, string Password)
        {
            Player player = new Player();
            player._Login = Login;
            player._Password = Password;
            DatabaseContext.dataContext.Players.InsertOnSubmit(player);
            DatabaseContext.dataContext.SubmitChanges();
        }
        /// <summary>
        /// Funkcja zwraca true jeśli nie znalazła gracza o podanym loginie.
        /// </summary>
        /// <param name="playerLogin"></param>
        /// <returns></returns>
        public static bool IsLoginAvailable(string playerLogin)
        {
            if (((from player in DatabaseContext.dataContext.Players select player).Where(x => x.Login == playerLogin)).Count() > 0)
                return false;
            return true;
        }
        /// <summary>
        /// Funkcja zwraca gracza o podanym loginie.
        /// </summary>
        /// <param name="playerLogin"></param>
        /// <returns></returns>
        public static Player GetPLayerByLogin(string playerLogin)
        {
            return (from player in DatabaseContext.dataContext.Players where player.Login.Equals(playerLogin) select player).First();
        }
        /// <summary>
        /// Funkcja zwraca wszystkich graczy, których status jest online.
        /// </summary>
        /// <returns></returns>
        public static List<Player> GetAllOnlinePlayers()
        {
            return (from player in DatabaseContext.dataContext.Players
                    from playerStatus in DatabaseContext.dataContext.PlayerStatus
                    where player.ID == playerStatus.PlayerID && playerStatus.IsOnline
                    select player).ToList();
        }
        /// <summary>
        /// Funkcja sprawdza czy podane dane logowania są w bazie.
        /// </summary>
        /// <param name="playerLogin"></param>
        /// <param name="playerEncryptedPassword"></param>
        /// <returns></returns>
        public static bool CheckLogin(string playerLogin, string playerEncryptedPassword)
        {
            if ((from player in DatabaseContext.dataContext.Players select player).Where(x => x.Login == playerLogin && x.Password == playerEncryptedPassword).Count() > 0)
                return true;
            return false;
        }
        /// <summary>
        /// Funkcja sprawdza czy gracz o podanym loginie jest online.
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
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
