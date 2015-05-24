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
    public partial class FormNewPlayer : Form
    {
        public FormNewPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (!Player.IsLoginAvailable(textBoxLogin.Text))
            {
                labelWrongLogin.Show();
                error = true;
            }
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                labelDifferentPasswords.Show();
                error = true;
            }
            if (!error)
            {
                Player.AddPlayer(textBoxLogin.Text, MainController.CalculateMD5Hash(textBoxPassword.Text));
                Player player = Player.GetPLayerByLogin(textBoxLogin.Text);
                PlayerStatus.AddPlayerStatus(player.ID);
                PlayerCar.AddPlayerCar(player, Car.GetCarByID(1));
                this.Close();
            }
        }
    }
}
