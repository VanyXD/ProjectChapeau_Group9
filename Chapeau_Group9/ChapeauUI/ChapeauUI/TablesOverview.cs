using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using System.Data.SqlClient;


namespace ChapeauUI
{
    public partial class TablesOverview : Form
    {
        public TablesOverview()
        {
            InitializeComponent();
        }
        private void lbllogoutbtn_Click(object sender, EventArgs e)
        {
            Hide();
            new Chapeau().ShowDialog();
        }
        private void Layout_Load(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection(@"Data Source=den1.mssql7.gear.host;Persist Security Info=True;User ID=dbchapeau09;Password=Jm2K-w?9ez1C");
            string query1 = "select first_name From employees WHERE password = '" + lblloginbox.Text + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query1, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            lblCurrentUser.Text = data.Rows[1]["first_name"].ToString();
        }
    }
}
