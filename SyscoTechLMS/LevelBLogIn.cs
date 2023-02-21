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
    public partial class LevelBLogIn : Form
    {
        public LevelBLogIn()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string uname = txtUsername.Text;
            string pword = txtPassword.Text;

            if ((uname.CompareTo("shawn") == 0) && pword.CompareTo("1997") == 0)
            {
                BurrowBooksLevelB bbb = new BurrowBooksLevelB();
                bbb.Show();
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
