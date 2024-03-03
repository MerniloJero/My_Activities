using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elderly_Information_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int age = 0;
        int id = 0;
        int birthyear = 0;
        int birthmonth = 0;
        int birthday = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            LblElder.Visible = false;
            LblInfo.Visible = false;

            if(Connection.check == true)
            {

                PLoad.BackgroundImage = null;
                PLoad.Controls.Clear();

                Add view = new Add();
                PLoad.Controls.Add(view);
                view.Show();

                LblElder.Visible = true;
                LblInfo.Visible = true;
            }

            if(Connection.checkaLL == true)
            {
                PLoad.BackgroundImage = null;
                PLoad.Controls.Clear();

                AllList al = new AllList();
                PLoad.Controls.Add(al);
                al.Show();

                LblElder.Visible = true;
                LblInfo.Visible = true;
                Connection.checkaLL = false;
            }

            DateTime currentDate = DateTime.Now;
            int month = currentDate.Month;
            int day = currentDate.Day;
            int year = currentDate.Year;
            System.Drawing.Bitmap myImage = Properties.Resources.notify;

            

            string query1 = $"SELECT * FROM userinfo WHERE DATE(dateregister) < '{currentDate.ToString("yyyy-MM-dd")}';";
            string query2 = $"SELECT * FROM userinfo WHERE MONTH(birthdate) = {month} AND DAY(birthdate) = {day} AND age = 59;";
            string query3 = $"SELECT * FROM userinfo WHERE MONTH(birthdate) = {month} AND DAY(birthdate) = {day} AND age < 59 OR age >= 60;";

            using (MySqlConnection connect = new MySqlConnection(Connection.ConnectionString))
            {
                using (MySqlCommand command1 = new MySqlCommand(query1, connect))
                {
                    command1.CommandTimeout = 60;

                    try
                    {
                        connect.Open();
                        using (MySqlDataReader reader1 = command1.ExecuteReader())
                        {
                            if (reader1.HasRows)
                            {
                                using (MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString))
                                using (MySqlCommand command2 = new MySqlCommand(query2, connect2))
                                {
                                    command2.CommandTimeout = 60;

                                    try
                                    {
                                        connect2.Open();
                                        using (MySqlDataReader reader2 = command2.ExecuteReader())
                                        {
                                            if (reader2.HasRows)
                                            {
                                             //   BtnNotification.Image = myImage;
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Query error: " + ex.Message);
                                    }
                                }

                                using (MySqlConnection connect3 = new MySqlConnection(Connection.ConnectionString))
                                using (MySqlCommand command3 = new MySqlCommand(query3, connect3))
                                {
                                    command3.CommandTimeout = 60;

                                    try
                                    {
                                        connect3.Open();
                                        using (MySqlDataReader reader3 = command3.ExecuteReader())
                                        {
                                            if (reader3.HasRows)
                                            {
                                                while (reader3.Read())
                                                {
                                                    // Assuming age is stored in the 8th column (index 7)
                                                     age = reader3.GetInt32(7);

                                                    // Assuming id is stored in the 1st column (index 0)
                                                     id = reader3.GetInt32(0);

                                                    // Assuming the birthdate is stored in the 7th column (index 6)
                                                    DateTime birthdate = reader3.GetDateTime(6);

                                                    // Extract year, month, and day
                                                     birthyear = birthdate.Year;
                                                     birthmonth = birthdate.Month;
                                                     birthday = birthdate.Day;


                                                    // Use the extracted values as needed
                                                    AddAge();
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Query error: " + ex.Message);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Query error: " + ex.Message);
                    }
                }
            }
        }

        public  void AddAge()
        {

            DateTime currentDate = DateTime.Now;
            int currentmonth = currentDate.Month;
            int currentday = currentDate.Day;
            int currentyear = currentDate.Year;


            int checkage = currentyear - birthyear;

           if( checkage == age)
           {

           }
           else
           {
                age += 1;

                string query = $"UPDATE userinfo SET age = {age} WHERE residentId = {id} AND status = '1' ";
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
                    }

                }
                catch (Exception c)
                {
                    MessageBox.Show("Query error: " + c.Message);
                }
           }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
           LoginForm loginForm = new LoginForm();
           this.Hide();
           loginForm.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PLoad.BackgroundImage = null;
            PLoad.Controls.Clear();

            Add view = new Add();
            PLoad.Controls.Add(view);
            view.Show();

            LblElder.Visible = true;
            LblInfo.Visible = true;
        }

        private void BtnAllList_Click(object sender, EventArgs e)
        {
            PLoad.BackgroundImage = null;
            PLoad.Controls.Clear();

            AllList al = new AllList();
            PLoad.Controls.Add(al);
            al.Show();

            LblElder.Visible = true;
            LblInfo.Visible = true;

        }

        private void BtnElderList_Click(object sender, EventArgs e)
        {
            PLoad.BackgroundImage = null;
            PLoad.Controls.Clear();

            Elderlist el = new Elderlist();
            PLoad.Controls.Add(el);
            el.Show();

            LblElder.Visible = true;
            LblInfo.Visible = true;

        }

        private void BtnNotification_Click(object sender, EventArgs e)
        {
            PLoad.BackgroundImage = null;
            PLoad.Controls.Clear();

            Notification el = new Notification();
            PLoad.Controls.Add(el);
            el.Show();

            LblElder.Visible = true;
            LblInfo.Visible = true;
        }

        private void BtnDeath_Click(object sender, EventArgs e)
        {
            PLoad.BackgroundImage = null;
            PLoad.Controls.Clear();

            Death el = new Death();
            PLoad.Controls.Add(el);
            el.Show();

            LblElder.Visible = true;
            LblInfo.Visible = true;
        }
    }
}
