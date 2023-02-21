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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnBurrow_Click(object sender, EventArgs e)
        {
            Membership memMenu = new Membership();
            memMenu.Show();
            this.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBooks retMenu = new ReturnBooks();
            retMenu.Show();
            this.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
