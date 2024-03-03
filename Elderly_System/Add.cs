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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elderly_Information_System
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }

        int id = 1;

        DateTime currentDate = DateTime.Now;


        public void testingP()
        {
            int desiredLength = 11; 

            // Check if the length of the text in the TextBox is not equal to the desired length
            if (TbxContactNum.Text.Length != desiredLength)
            {
                number = true;
            }
            else
            {
                number = false;
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            testingP();

            if (number == true)
            {
                number = false;
                MessageBox.Show("Phone Numbers to Short", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DateTime birthdate = DtpBirthDate.Value;
                int yearnow = currentDate.Year;
                int monthnow = currentDate.Month;
                int daynow = currentDate.Day;


                int year = birthdate.Year;
                int day = birthdate.Day;
                int month = birthdate.Month;
                string pension;

                if (Convert.ToInt32(TbxAge.Text) >= 60)
                {
                    pension = CbxPension.Text;
                }
                else
                {
                    pension = "Not Yet";
                }


                string query = "INSERT INTO userinfo(residentId,household,lastname,firstname,middlename,suffix,birthdate,age,sex,civilStatus,pension,contactNumber,purok,dateregister,status) VALUES ( " + LblId.Text + "," + TbxHouseholdNo.Text + ",'" + TbxLName.Text + "','" + TbxFName.Text + "','" + TbxMName.Text + "','" +
                CbxSuffix.Text + "','" + year + "-" + month + "-" + day + "','" + TbxAge.Text + "','" + CbxGender.Text + "','" + CbxCivilStatus.Text + "','" + pension + "','" + TbxContactNum.Text + "','" + TbxPurok.Text + "','" + yearnow + "-" + monthnow + "-" + daynow + "', '1');";
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
                        MessageBox.Show("Successfully Save");

                        TbxHouseholdNo.Clear();
                        TbxFName.Clear();
                        TbxMName.Clear();
                        TbxLName.Clear();
                        CbxSuffix.ResetText();
                        DtpBirthDate.ResetText();
                        TbxAge.Clear();
                        CbxGender.ResetText();
                        CbxCivilStatus.ResetText();
                        TbxContactNum.Clear();
                        TbxPurok.Clear();
                        CbxPension.ResetText();
                        id++;
                        LblId.Text = id.ToString();


                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
            }

        }

        private void Add_Load(object sender, EventArgs e)
        {
            LblPension.Visible = false;
            CbxPension.Visible = false;
            BtnDelete.Visible = false;
            BtnDeath.Visible = false;


            if (Connection.check == true)
            {
                Connection.check = false;
                BtnDelete.Visible = true;
                BtnDeath.Visible = true;

               BtnSave.Text = "UPDATE";
               
               BtnSave.Click -= BtnSave_Click;
               BtnSave.Click += BtnUpdate_Click;

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
                                        TbxHouseholdNo.Text = reader.GetString(1);
                                        TbxLName.Text = reader.GetString(2);
                                        TbxFName.Text = reader.GetString(3);
                                        TbxMName.Text = reader.GetString(4);
                                        CbxSuffix.Text = reader.GetString(5);
                                        DtpBirthDate.Text = reader.GetString(6);
                                        TbxAge.Text = reader.GetString(7);
                                        CbxGender.Text = reader.GetString(8);
                                        CbxCivilStatus.Text = reader.GetString(9);
                                        CbxPension.Text = reader.GetString(10);
                                        TbxContactNum.Text = reader.GetString(11);
                                        TbxPurok.Text = reader.GetString(12);

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
            else
            {

                string query = "SELECT count(*) from userinfo";
                MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command = new MySqlCommand(query, connect);

                connect.Open();
                long rowCount = (long)command.ExecuteScalar();
                connect.Close();
                if (rowCount == 0)
                {
                    LblId.Text = id.ToString();
                }
                else
                {
                    string query2 = "SELECT residentId from userinfo order by residentId desc limit 1;";
                    MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
                    MySqlCommand command2 = new MySqlCommand(query2, connect2);
                    connect2.Open();
                    id = (int)command2.ExecuteScalar();
                    id += 1;
                    LblId.Text = id.ToString();
                    connect2.Close();
                }
            }

        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {


            DateTime birthdate = DtpBirthDate.Value;
            int yearnow = currentDate.Year;
            int monthnow = currentDate.Month;
            int daynow = currentDate.Day;


            int year = birthdate.Year;
            int day = birthdate.Day;
            int month = birthdate.Month;
            string pension;

            if (Convert.ToInt32(TbxAge.Text) >= 60)
            {
                pension = CbxPension.Text;
            }
            else
            {
                pension = "Not Yet";
            }

            string query = "UPDATE userinfo SET residentId = " + LblId.Text + ", household = " + TbxHouseholdNo.Text + ", lastname = '" + TbxLName.Text + "', firstname = '" + TbxFName.Text + "', middlename = '" + TbxMName.Text +
                "', suffix = '" + CbxSuffix.Text + "', birthdate = '" + year + "-" + month + "-" + day + "', age = " + TbxAge.Text + ", sex = '" + CbxGender.Text + "', civilStatus = '" + CbxCivilStatus.Text + "', pension ='" + pension + "', contactNumber = " + TbxContactNum.Text + ", purok = " + TbxPurok.Text + " WHERE residentId = " + Connection.IdContent + "";
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
                    MessageBox.Show("Informarion have been Updated");
                    TbxHouseholdNo.Clear();
                    TbxFName.Clear();
                    TbxMName.Clear();
                    TbxLName.Clear();
                    CbxSuffix.ResetText();
                    DtpBirthDate.ResetText();
                    TbxAge.Clear();
                    CbxGender.ResetText();
                    CbxCivilStatus.ResetText();
                    TbxContactNum.Clear();
                    TbxPurok.Clear();
                    CbxPension.ResetText();

                    MainForm mf = new MainForm();
                    mf.Hide();
                    Connection.checkaLL = true;
                    mf.Show();
                }

            }
            catch (Exception c)
            {
                MessageBox.Show("Query error: " + c.Message);
            }
        }

        private void DtpBirthDate_Leave(object sender, EventArgs e)
        {
            int yearnow = currentDate.Year;
            int monthnow = currentDate.Month;
            int daynow = currentDate.Day;

            DateTime birthdate = DtpBirthDate.Value;
            int year = birthdate.Year;
            int month = birthdate.Month;
            int day = birthdate.Day;

            int diff = yearnow - year;

            if (diff == 60)
            {
                if (monthnow >= month)
                {
                    if (month == monthnow)
                    {
                        if (daynow >= day)
                        {
                            MessageBox.Show("Youre Already a Senior Citizen");
                            LblPension.Visible = true;
                            CbxPension.Visible = true;
                            TbxAge.Text = diff.ToString();
                        }
                        else
                        {
                            LblPension.Visible = false;
                            CbxPension.Visible = false;
                            diff -= 1;
                            TbxAge.Text = diff.ToString();
                        }   
                    }
                    else
                    {
                        MessageBox.Show("Youre Already a Senior Citizen");
                        LblPension.Visible = true;
                        CbxPension.Visible = true;
                        TbxAge.Text = diff.ToString();
                    }
                }
                else
                {
                    LblPension.Visible = false;
                    CbxPension.Visible = false;
                    int age = diff - 1;
                    TbxAge.Text = age.ToString();

                }
            }
            else if (diff > 60)
            {
                MessageBox.Show("Youre Already a Senior Citizen");
                LblPension.Visible = true;
                CbxPension.Visible = true;
                TbxAge.Text = diff.ToString();
            }
            else if (diff < 60)
            {
                if (monthnow >= month)
                {
                    if (month == monthnow)
                    {
                        if (daynow >= day)
                        {
                            TbxAge.Text = diff.ToString();
                        }
                        else
                        {
                            diff -= 1;
                            TbxAge.Text = diff.ToString();
                        }
                    }
                    else
                    {
                        TbxAge.Text = diff.ToString();
                    }

                }
                else
                {
                    int age = diff - 1;
                    TbxAge.Text = age.ToString();
                }
            }
            else
            {
                LblPension.Visible = false;
                CbxPension.Visible = false;
                TbxAge.Text = diff.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "UPDATE userinfo SET status = '2' WHERE residentId = '" + Connection.IdContent + "'";
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
                    MessageBox.Show("Informarion have been Deleted");

                    TbxHouseholdNo.Clear();
                    TbxFName.Clear();
                    TbxMName.Clear();
                    TbxLName.Clear();
                    CbxSuffix.ResetText();
                    DtpBirthDate.ResetText();
                    TbxAge.Clear();
                    CbxGender.ResetText();
                    CbxCivilStatus.ResetText();
                    TbxContactNum.Clear();
                    TbxPurok.Clear();
                    CbxPension.ResetText();

                    MainForm mf = new MainForm();
                    mf.Hide();
                    Connection.checkaLL = true;
                    mf.Show();
                }

            }
            catch (Exception b)
            {
                MessageBox.Show("Query error: " + b.Message);
            }
        }

        private void DtpBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        bool number = false;

        private void TbxContactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 46)
            {
                e.Handled = true;
            }

           
        }

        private void TbxPurok_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 46)
            {
                e.Handled = true;
            }
        }

        private void BtnDeath_Click(object sender, EventArgs e)
        {
            string query = "UPDATE userinfo SET status = '0' WHERE residentId = '" + Connection.IdContent + "'";
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
                    MessageBox.Show("Informarion have been Deleted");

                    TbxHouseholdNo.Clear();
                    TbxFName.Clear();
                    TbxMName.Clear();
                    TbxLName.Clear();
                    CbxSuffix.ResetText();
                    DtpBirthDate.ResetText();
                    TbxAge.Clear();
                    CbxGender.ResetText();
                    CbxCivilStatus.ResetText();
                    TbxContactNum.Clear();
                    TbxPurok.Clear();
                    CbxPension.ResetText();

                    MainForm mf = new MainForm();
                    mf.Hide();
                    Connection.checkaLL = true;
                    mf.Show();
                }

            }
            catch (Exception b)
            {
                MessageBox.Show("Query error: " + b.Message);
            }
        }

        private void TbxHouseholdNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 46)
            {
                e.Handled = true;
            }
        }
    }
}
