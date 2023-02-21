using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SyscoTechLMS
{
    public partial class BurrowBooksLevelB : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=SUPUNXIIIXPS\SQLEXPRESS;Initial Catalog=SyscoTech;Integrated Security=True;Pooling=False");
        public BurrowBooksLevelB()
        {
            InitializeComponent();
        }

        private void BurrowBooksLevelB_Load(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Visible = false;
        }
    }
}
