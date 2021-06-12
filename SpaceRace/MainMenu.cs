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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Visible = false;
            form.Show();

        }

        private void newGame()
        {
            Form1 form = new Form1();
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
    }
}
