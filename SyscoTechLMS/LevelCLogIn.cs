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
    public partial class LevelCLogIn : Form
    {
        public LevelCLogIn()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text;
            string pword = txtPassword.Text;

            if ((uname.CompareTo("supun") == 0) && pword.CompareTo("1999") == 0)
            {
                BurrowBooksLevelC bbc = new BurrowBooksLevelC();
                bbc.Show();
                this.Visible = false;
            }
            else
            {
                lblError.Text = "Sorry, Invalid Username or Password.";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
