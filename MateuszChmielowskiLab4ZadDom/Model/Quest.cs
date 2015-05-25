using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class Quest
    {

        public static Quest GetQuestByID(int id)
        {
            return (from quest in DatabaseContext.dataContext.Quests select quest).Where(x=>x.ID == id).First();
        }

        public static Quest GetRandomQuest()
        {
            List<Quest> quests = (from quest in DatabaseContext.dataContext.Quests select quest).ToList();
            Random random = new Random();
            int index = random.Next(quests.Count());
            return quests.ElementAt(index);
        }

        public static void AddQuest(PointLatLng fromPoint, PointLatLng toPoint, decimal maxTime, decimal reward, string description = "")
        {
            Quest quest = new Quest();
            quest.GPSFromLatitude = (decimal)fromPoint.Lat;
            quest.GPSFromLongitude = (decimal)fromPoint.Lng;
            quest.GPSToLatitude = (decimal)toPoint.Lat;
            quest.GPSToLongitude = (decimal)toPoint.Lng;
            quest.MaxEndTime = maxTime;
            quest.Reward = reward;
            quest.Description = description;
            DatabaseContext.dataContext.Quests.InsertOnSubmit(quest);
            DatabaseContext.dataContext.SubmitChanges();
        }
    }
}
