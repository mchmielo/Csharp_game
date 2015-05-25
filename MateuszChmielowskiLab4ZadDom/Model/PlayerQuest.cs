using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszChmielowskiLab4ZadDom.Model
{
    public partial class PlayerQuest
    {
        public static PlayerQuest GetPlayerQuestByID(int playerId, int questId)
        {
            return (from playerQuest in DatabaseContext.dataContext.PlayerQuests select playerQuest).Where(x => x.PlayerID == playerId && x.QuestID == questId).First();
        }
        public static void AddPlayerQuest(int playerID, Quest quest)
        {
            PlayerQuest playerQuest = new PlayerQuest();
            playerQuest.PlayerID = playerID;
            playerQuest.QuestID = quest.ID;
            playerQuest.StartTime = DateTime.Now;
            DatabaseContext.dataContext.PlayerQuests.InsertOnSubmit(playerQuest);
            DatabaseContext.dataContext.SubmitChanges();
        }
        public static void UpdatePlayerQuestEnded(int playerID, int questID)
        {
            PlayerQuest playersQuest = (from playerQuest in DatabaseContext.dataContext.PlayerQuests select playerQuest).Where(x => x.PlayerID == playerID && x.QuestID == questID).First();
            playersQuest.EndTime = DateTime.Now;
            DatabaseContext.dataContext.SubmitChanges();
        }
    }
}
