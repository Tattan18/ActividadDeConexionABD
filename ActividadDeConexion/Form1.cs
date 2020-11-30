using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadDeConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oConexionString = @"Server = (LocalDB)\MSSQLLocalDB; Database = Master; Trusted_Connection = True;";
            try
            {
                using (SqlConnection oSqlConnection = new SqlConnection(oConexionString))
                {
                    oSqlConnection.Open();
                    MessageBox.Show("Conectado al servidor: " + oSqlConnection.DataSource + "\nBase de datos: " + oSqlConnection.Database);
                    oSqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible conectarse con la base de datos" + ex.Message);
            }
        }
    }
}
