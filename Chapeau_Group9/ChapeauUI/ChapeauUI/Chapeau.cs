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
    public partial class Chapeau : Form
    {
        private int LoginPassword;
        public Chapeau()
        {
            InitializeComponent();

        }

        private void lblloginbox_TextChanged(object sender, EventArgs e)
        {

            bool status = int.TryParse(lblloginbox.Text, out LoginPassword);
        }
        private void lbllogin_Click(object sender, EventArgs e)
        {
            Chapeau.ActiveForm.Hide();
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=den1.mssql7.gear.host;Persist Security Info=True;User ID=dbchapeau09;Password=Jm2K-w?9ez1C");
            string query1 = "select Password From employees WHERE password = '" + lblloginbox.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query1, sqlConnection);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);
            if (data.Rows.Count == 1)
            {
                TablesOverview layout = new TablesOverview();
                layout.ShowDialog();
            }

            else
            {
                MessageBox.Show("wrong password");
            }




        }
    }
}
