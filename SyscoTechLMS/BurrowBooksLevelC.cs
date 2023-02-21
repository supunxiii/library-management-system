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

namespace SyscoTechLMS
{
    public partial class BurrowBooksLevelC : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=SUPUNXIIIXPS\SQLEXPRESS;Initial Catalog=SyscoTech;Integrated Security=True;Pooling=False");
        private void FillMember()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StdId from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdId", typeof(int));
            dt.Load(rdr);
            memberCMB.ValueMember = "StdId";
            memberCMB.DataSource = dt;
            Con.Close();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty >"+0+"", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            bookCMB.ValueMember = "BookName";
            bookCMB.DataSource = dt;
            Con.Close();
        }
        private void showData()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            issueDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        public BurrowBooksLevelC()
        {
            InitializeComponent();
        }
        
        private void fetchData()
        {
            Con.Open();
            string query = "select * from StudentTbl where StdId=" + memberCMB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                memberTxt.Text = dr["StdName"].ToString();
                membershipTxt.Text = dr["StdDep"].ToString();
                phoneTxt.Text = dr["StdPhone"].ToString();
            }
            Con.Close();
        }

        private void updateQty()
        {
            int Qty;
            int newQty;
            Con.Open();
            string query = "select * from BookTbl where BookName='" + bookCMB.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty - 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + bookCMB.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }
           
            Con.Close();
        }
        private void BurrowBooksLevelC_Load(object sender, EventArgs e)
        {
            FillMember();
            FillBook();
            showData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void memberCMB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchData();
        }

        private void btnBurrow_Click(object sender, EventArgs e)
        {
            if (burrowNumTxt.Text == "" || memberTxt.Text == "")
            {
                MessageBox.Show("Cannot Complete the Process. Either Burrow Number or Member Name is Missing.");
            }
            else
            {
                string issueDate = burrowDatePicker.Value.Day.ToString() + "/" + burrowDatePicker.Value.Month.ToString() + "/" + burrowDatePicker.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into IssueTbl values(" + burrowNumTxt.Text + "," + memberCMB.SelectedValue.ToString() + ",'" + memberTxt.Text + "','" + membershipTxt.Text + "','" + phoneTxt.Text + "','" + bookCMB.SelectedValue.ToString()+ "','" + issueDate + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Burrow Process Complete.");
                Con.Close();
                showData();
                updateQty();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Visible = false;
        }
    }
}
