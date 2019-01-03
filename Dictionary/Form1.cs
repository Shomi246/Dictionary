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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
            LoadGridData();
        }

        private string conString = "Data Source=DESKTOP-DRE63AO\\SQLEXPRESS; Initial Catalog=Dictionary; Integrated Security=True";
        private void LoadGridData()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlDataAdapter adadpt = new SqlDataAdapter("Select English, Bengali, Synonym from Wordbank", con);
            DataTable dt = new DataTable();
            adadpt.Fill(dt);

            datagrid.DataSource = dt;
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();

            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string sq = "Select English, Bengali, Synonym from Wordbank where English = '"+txteng.Text+"'";
            SqlDataAdapter adadpt = new SqlDataAdapter(sq, con);
            DataTable dt = new DataTable();
            adadpt.Fill(dt);

            datagrid.DataSource = dt;
            con.Close();
        }
    }
}
