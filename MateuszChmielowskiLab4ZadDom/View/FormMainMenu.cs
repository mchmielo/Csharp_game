using MateuszChmielowskiLab4ZadDom.Controller;
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

namespace MateuszChmielowskiLab4ZadDom
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                MessageBox.Show("Należy wypełnić oba pola.");
            else
            {
                if(Player.CheckLogin(textBoxLogin.Text, MainController.CalculateMD5Hash(textBoxPassword.Text)))
                {
                    if (Player.IsOnline(textBoxLogin.Text))
                    {
                        MessageBox.Show("Gracz jest już zalogowany na innym urządzeniu.");
                    }
                    else
                    {
                        Player player = Player.GetPLayerByLogin(textBoxLogin.Text);
                        PlayerStatus.SetPlayerOnline(player.ID, true);
                        FormGame formGame = new FormGame(player);
                        formGame.FormClosed += new FormClosedEventHandler(FormGame_Closed);
                        formGame.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Niepoprawny login lub hasło.");
            }
        }

        private void FormGame_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void buttonNewPlayer_Click(object sender, EventArgs e)
        {
            FormNewPlayer formNewPlayer = new FormNewPlayer();
            formNewPlayer.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
