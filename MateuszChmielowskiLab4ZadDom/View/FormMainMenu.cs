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
        /// <summary>
        /// Po zamknięciu okna z grą otwierane jest menu główne.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGame_Closed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        /// <summary>
        /// Utworzenie okna do tworzenia nowego gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNewPlayer_Click(object sender, EventArgs e)
        {
            FormNewPlayer formNewPlayer = new FormNewPlayer();
            formNewPlayer.ShowDialog();
        }
        /// <summary>
        /// Zamknięcie programu po wciśnięciu przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Logowanie do gry. Jeśli podano prawidłowy login i hasło i gra nie jest już gdzieś indziej otwarta,
        /// to zostaje utworzone okno z grą. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                MessageBox.Show("Należy wypełnić oba pola.");
            else
            {
                if (Player.CheckLogin(textBoxLogin.Text, MainController.CalculateMD5Hash(textBoxPassword.Text)))
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
    }
}
