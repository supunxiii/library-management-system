using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyscoTechLMS
{
    public partial class Membership : Form
    {
        public Membership()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LevelALogIn lla = new LevelALogIn();
            lla.Show();
            this.Visible = false;
        }

        private void btnLevelB_Click(object sender, EventArgs e)
        {
            LevelBLogIn llb = new LevelBLogIn();
            llb.Show();
            this.Visible = false;
        }

        private void btnLevelC_Click(object sender, EventArgs e)
        {
            LevelCLogIn llc = new LevelCLogIn();
            llc.Show();
            this.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Visible = false;
        }
    }
}
