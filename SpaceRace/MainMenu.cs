using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceRace
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            this.BackgroundImage = Properties.Resources.download__1_;
            InitializeComponent();
        }

        private void newGame()
        {
            SpaceRace form = new SpaceRace();
            this.Visible = false;

            if (form.ShowDialog() == System.Windows.Forms.DialogResult.No)
            {
                form.Visible = false;
                this.Visible = true;
            }
            else
            {
                newGame();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SpaceRace form = new SpaceRace();
            this.Visible = false;
            form.Show();

        }
    }
}
