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
    public partial class Notification : UserControl
    {
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime currentDate = DateTime.Now;
            int month = currentDate.Month;
            int day = currentDate.Day;

            DGVElderlist.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVElderlist.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "Resident_Id", "Household_No.", "Last_Name", "First_Name", "Middle_Name", "Suffix", "Birthdate", "Age", "Sex", "Civil_Status", "Pension", "Contact_Number", "Purok" };

            DGVElderlist.ColumnCount = 13;

            for (int a = 0; a < columnNames.Length; a++)
            {
                DGVElderlist.Columns[a].Name = columnNames[a];
            }

            string query = $"SELECT * FROM userinfo WHERE DATE(dateregister) < '{today.ToString("yyyy-MM-dd")}';";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    string query2 = $"SELECT * FROM userinfo WHERE MONTH(birthdate) = {month} AND DAY(birthdate) = {day} AND age = 59;";
                    MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
                    MySqlCommand command2 = new MySqlCommand(query2, connect2);
                    command2.CommandTimeout = 60;

                    try
                    {
                        connect2.Open();

                        MySqlDataReader reader2 = command2.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            while (reader.Read())
                            {
                                DGVElderlist.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12));
                            }
                        }
                        else
                        {
                        }
                    }
                    catch (Exception c)
                    {
                        MessageBox.Show("Query error: " + c.Message);
                    }
                    finally
                    {
                        connect2.Close();
                    }
                }
            }
            catch (Exception c)
            {
                MessageBox.Show("Query error: " + c.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        int age = 0;

        private void DGVElderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow;
                selectedrow = e.RowIndex;
                DataGridViewRow row = DGVElderlist.Rows[selectedrow];

                Connection.IdContent = row.Cells[0].Value.ToString();

                string query = "SELECT * FROM userinfo WHERE residentId = '" + Connection.IdContent + "'";

                using (MySqlConnection connect = new MySqlConnection(Connection.ConnectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connect))
                    {
                        command.CommandTimeout = 60;

                        try
                        {
                            connect.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {

                                        LblId.Text = reader.GetString(0);
                                        age = reader.GetInt32(7);
                                    }
                                }
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Query error: " + x.Message);
                        }
                    }
                }


            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            age += 1;
            string query = "UPDATE userinfo SET  age = " + age + ", pension ='" + CbxPension.Text + "' WHERE residentId = " + Connection.IdContent + "";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                }
                else
                {
                    MessageBox.Show("Informarion have been Saved");
                    LblId.Text = "id";
                    CbxPension.ResetText();

                    MainForm mf = new MainForm();
                }

            }
            catch (Exception c)
            {
                MessageBox.Show("Query error: " + c.Message);
            }
        }
    }
}
