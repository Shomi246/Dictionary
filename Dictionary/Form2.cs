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

namespace Dictionary
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private int id = 0;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private string conString = "Data Source=DESKTOP-DRE63AO\\SQLEXPRESS; Initial Catalog=Dictionary; Integrated Security=True";
        private void save_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("Insert Into Wordbank(English, Bengali, Synonym) values('" + txteng.Text + "',N'" +txtbng.Text + "', '" + txtsy.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SAVED");
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string sq = "Select English, Bengali, Synonym from Wordbank where English like '"+txteng.Text+"%'";
            SqlDataAdapter adadpt = new SqlDataAdapter(sq, con);
            DataTable dt = new DataTable();
            adadpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                
                txteng.Text = Convert.ToString(dt.Rows[0][0]); 
                txtbng.Text = Convert.ToString(dt.Rows[0][1]);
                txtsy.Text = Convert.ToString(dt.Rows[0][2]);

            }
            con.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("Delete Wordbank where English= '"+txteng.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void edit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("Update Wordbank set Bengali = N'" + txtbng.Text + "', Synonym = '" + txtsy.Text + "' where English= '" + txteng.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");
        }
    }
}
