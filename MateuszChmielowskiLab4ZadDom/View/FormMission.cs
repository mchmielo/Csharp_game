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
        Quest quest;
        int PlayerID, QuestID;
        /// <summary>
        /// Ustawienie pól klasy oraz kontrolek na podstawie otrzymanych danych z bazy danych.
        /// </summary>
        /// <param name="playerID"></param>
        /// <param name="questID"></param>
        public FormMission(int playerID, int questID)
        {
            InitializeComponent();
            PlayerID = playerID;
            QuestID = questID;
            quest = Quest.GetQuestByID(QuestID);
            labelDescription.Text = quest.Description;
        }
        /// <summary>
        /// Akcja wykonywana przy akceptacji misji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            PlayerQuest.AddPlayerQuest(PlayerID, quest);
            this.Close();
        }
        /// <summary>
        /// Zamknięcie okna jeśli anulowano.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
