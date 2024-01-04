using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elderly_Information_System
{
    public partial class Death : UserControl
    {
        public Death()
        {
            InitializeComponent();
        }

        private void Death_Load(object sender, EventArgs e)
        {
            DGVDeath.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVDeath.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "Resident_Id", "Household_No.", "Last_Name", "First_Name", "Middle_Name", "Suffix", "Birthdate", "Age", "Sex", "Civil_Status", "Pension", "Contact_Number", "Purok" };

            DGVDeath.ColumnCount = 13;

            for (int a = 0; a < columnNames.Length; a++)
            {
                DGVDeath.Columns[a].Name = columnNames[a];
            }

            string query = "SELECT * FROM userinfo WHERE status = '0'";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Assuming the birthdate is stored in the 7th column (index 6)
                        DateTime birthdate = reader.GetDateTime(6);

                        // Extract year, month, and day
                        int year = birthdate.Year;
                        int month = birthdate.Month;
                        int day = birthdate.Day;

                        DGVDeath.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), month + "/" + day + "/" + year, reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void DGVDeath_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
