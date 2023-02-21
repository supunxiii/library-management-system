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

    public partial class ReturnBooks : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=SUPUNXIIIXPS\SQLEXPRESS;Initial Catalog=SyscoTech;Integrated Security=True;Pooling=False");
        public ReturnBooks()
        {
            InitializeComponent();
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
        private void fetchData()
        {
            Con.Open();
            string query = "select * from StudentTbl where StdId=" + memberCMB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                memberTxt.Text = dr["StdName"].ToString();
                membershipTxt.Text = dr["StdDep"].ToString();
                phoneTxt.Text = dr["StdPhone"].ToString();
            }
            Con.Close();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty >" + 0 + "", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            bookCMB.ValueMember = "BookName";
            bookCMB.DataSource = dt;
            Con.Close();
        }
        private void showDataReturn()
        {
            Con.Open();
            string query = "select * from ReturnTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            returnDGV.DataSource = ds.Tables[0];
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
                newQty = Qty + 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + bookCMB.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
            }

            Con.Close();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            showData();
            showDataReturn();
            FillBook();
        }

        private void issueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            returnNumTxt.Text = issueDGV.SelectedRows[0].Cells[0].Value.ToString();
            memberCMB.SelectedItem = issueDGV.SelectedRows[0].Cells[1].Value.ToString();
            memberTxt.Text = issueDGV.SelectedRows[0].Cells[2].Value.ToString();
            membershipTxt.Text = issueDGV.SelectedRows[0].Cells[3].Value.ToString();
            phoneTxt.Text = issueDGV.SelectedRows[0].Cells[4].Value.ToString();
            bookCMB.SelectedItem = issueDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (returnNumTxt.Text == "" || memberTxt.Text == "")
            {
                MessageBox.Show("Cannot Complete the Process. Either Return Number or Member Name is Missing.");
            }
            else
            {
                string issueDate = burrowDatePicker.Value.Day.ToString() + "/" + burrowDatePicker.Value.Month.ToString() + "/" + burrowDatePicker.Value.Year.ToString();
                string returnDate = returnDatePicker.Value.Day.ToString() + "/" + returnDatePicker.Value.Month.ToString() + "/" + returnDatePicker.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ReturnTbl values(" + returnNumTxt.Text + "," + memberCMB.SelectedValue.ToString() + ",'" + memberTxt.Text + "','" + membershipTxt.Text + "','" + phoneTxt.Text + "','" + bookCMB.SelectedValue.ToString() + "','" + issueDate + "','" + returnDate + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thank You For Returning the Book.");
                Con.Close();
                updateQty();
                showData();
                showDataReturn();
                
            }
        }

        private void returnNumTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void memberCMB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchData();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Visible = false;
        }
    }
}
