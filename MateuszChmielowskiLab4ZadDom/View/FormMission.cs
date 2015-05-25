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
    public partial class FormMission : Form
    {
        PlayerQuest playerQuest;
        Quest quest;
        int PlayerID, QuestID;
        public FormMission(int playerID, int questID)
        {
            InitializeComponent();
            PlayerID = playerID;
            QuestID = questID;
            quest = Quest.GetQuestByID(QuestID);
            labelDescription.Text = quest.Description;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            PlayerQuest.AddPlayerQuest(PlayerID, quest);
            this.Close();
        }

        private void buttonDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
