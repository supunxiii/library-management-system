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
    public partial class LevelALogIn : Form
    {
        public LevelALogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text;
            string pword = txtPassword.Text;

            if ((uname.CompareTo("john") == 0) && pword.CompareTo("1234") == 0)
            {
                BurrowBooksLevelA bba = new BurrowBooksLevelA();    
                bba.Show();
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
