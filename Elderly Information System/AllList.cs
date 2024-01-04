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
    public partial class AllList : UserControl
    {
        public AllList()
        {
            InitializeComponent();
        }

        private void AllList_Load(object sender, EventArgs e)
        {
            DGVAllList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVAllList.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] {"Resident_Id","Household_No.","Last_Name", "First_Name", "Middle_Name","Suffix","Birthdate","Age","Sex","Civil_Status","Pension","Contact_Number","Purok"};

            DGVAllList.ColumnCount = 13;

            for (int a = 0; a < columnNames.Length; a++)
            {
                DGVAllList.Columns[a].Name = columnNames[a];
            }

            string query = "SELECT * FROM userinfo WHERE status = '1'";
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

                        DGVAllList.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), month + "/" + day + "/" + year , reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DGVAllList.Rows.Clear();

            DGVAllList.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVAllList.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "Resident_Id", "Household_No.", "Last_Name", "First_Name", "Middle_Name", "Suffix", "Birthdate", "Age", "Sex", "Civil_Status", "Pension", "Contact_Number", "Purok" };

            DGVAllList.ColumnCount = 13;
            string query = "";

            for (int a = 0; a < columnNames.Length; a++)
            {
                DGVAllList.Columns[a].Name = columnNames[a];
            }

            if(int.TryParse(TbxSearch.Text,out _))
            {
                query = "SELECT * FROM userinfo WHERE residentId = " + TbxSearch.Text + "  OR  household = " + TbxSearch.Text + " OR age = " + TbxSearch.Text +";";
            }
            else if (!string.IsNullOrEmpty(TbxSearch.Text))
            {
                query = "SELECT * FROM userinfo WHERE  firstname = '" + TbxSearch.Text + "' or middlename = '" + TbxSearch.Text +
                "' or lastname = '" + TbxSearch.Text + "' or sex = '" + TbxSearch.Text + "' or civilStatus = '" + TbxSearch.Text + "';";
            }



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
                        DGVAllList.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void DGVAllList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow;
                selectedrow = e.RowIndex;
                DataGridViewRow row = DGVAllList.Rows[selectedrow];

                Connection.IdContent = row.Cells[0].Value.ToString();
                Connection.check = true;


                MainForm mf = new MainForm();
                mf.Show();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }
    }
}
