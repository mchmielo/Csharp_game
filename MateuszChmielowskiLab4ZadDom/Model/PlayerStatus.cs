﻿using GMap.NET;
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
        /// <summary>
        /// Funkcja oddaje nowy status dla gracza o podanym ID.
        /// </summary>
        /// <param name="playerID"></param>
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
        /// <summary>
        /// Funkcja zwraca staus gracza o podanym ID
        /// </summary>
        /// <param name="playerID"></param>
        /// <returns></returns>
        public static PlayerStatus GetPlayerStatusByPlayerID(int playerID)
        {
            var query = from playerStatus in DatabaseContext.dataContext.PlayerStatus select playerStatus;
            return query.Where(x => x.PlayerID == playerID).First();
        }
        /// <summary>
        /// Funkcja aktualizuje pozycję podanego gracza.
        /// </summary>
        /// <param name="playerID"></param>
        /// <param name="position"></param>
        public static void UpdatePlayerStatus(int playerID, PointLatLng position)
        {
            PlayerStatus statusOfPlayer = (from playerStatus in DatabaseContext.dataContext.PlayerStatus select playerStatus).Where(x => x.PlayerID == playerID).First();
            statusOfPlayer.GPSLatitude = (decimal)position.Lat;
            statusOfPlayer.GPSLongitude = (decimal)position.Lng;
            DatabaseContext.dataContext.SubmitChanges();
        }
        /// <summary>
        /// Funkcja aktualizuje status gracza ustawiajac pole IsOnline.
        /// </summary>
        /// <param name="playerID"></param>
        /// <param name="online"></param>
        internal static void SetPlayerOnline(int playerID, bool online)
        {
            PlayerStatus statusOfPlayer = (from playerStatus in DatabaseContext.dataContext.PlayerStatus select playerStatus).Where(x => x.PlayerID == playerID).First();
            statusOfPlayer.IsOnline = online;
            DatabaseContext.dataContext.SubmitChanges();
        }
    }
}
