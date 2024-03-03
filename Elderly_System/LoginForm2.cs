using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elderly_Information_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        //Method
        private static void UsernameMethod(TextBox username)
        {
            if (username.Text != "admin")
            {
                username.Text = "Username";
                username.ForeColor = Color.DimGray;
            }
        }

        private static void PassMethod(TextBox pass , CheckBox ckBox )
        {
            if (pass.Text != "admin")
            {
                pass.Text = "Password";
                pass.ForeColor = Color.DimGray;
                pass.UseSystemPasswordChar = false;
                ckBox.Enabled = false;
            }
            else
            {
                ckBox.Enabled = true;
            } 
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CbxShowPass.Enabled = false;
        }

        private void TbxUsername_Enter(object sender, EventArgs e)
        {
            if (TbxUsername.Text == "Username")
            {
                TbxUsername.Text = "";
                TbxUsername.ForeColor = Color.Black;
            }
        }

        private void TbxPassword_Enter(object sender, EventArgs e)
        {
            if (TbxPass.Text == "Password")
            {
                TbxPass.Text = "";
                TbxPass.ForeColor = Color.Black;
                TbxPass.UseSystemPasswordChar = true;
            }
        }

        private void TbxUsername_Leave(object sender, EventArgs e)
        {
            if (TbxUsername.Text == "")
            {
                TbxUsername.Text = "Username";
                TbxUsername.ForeColor = Color.DimGray;
            }
        }

        private void CbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxShowPass.Checked)
            {
                TbxPass.UseSystemPasswordChar = false;
            }
            else
            {
                TbxPass.UseSystemPasswordChar = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (TbxUsername.Text == "Username" || TbxPass.Text == "Password")
            {
                MessageBox.Show("Please enter your username and password to log in", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                string username = TbxUsername.Text;
                string password = TbxPass.Text;

                string hashedPassword = HashPassword(password);

                string query = "SELECT * FROM login WHERE username = '" + username + "'";

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
                            string pass = reader.GetString(1);

                            if (pass == hashedPassword && username == reader.GetString(0))
                            {
                                MainForm mf = new MainForm();
                                this.Hide();
                                mf.Show();
                            }
                            else
                            {
                               MessageBox.Show("Account does not exist. Check the username and password and try again.","Warning", MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account does not exist. Check the username and password and try again.","Warning", MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
            }

        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashedBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void TbxPass_MouseLeave(object sender, EventArgs e)
        {
            if (TbxPass.Text == "")
            {
                TbxPass.Text = "Password";
                TbxPass.ForeColor = Color.DimGray;
                TbxPass.UseSystemPasswordChar = false;
                CbxShowPass.Enabled = false;
            }
            else
            {
                CbxShowPass.Enabled = true;
            } 
        }

        private void TbxPass_Leave(object sender, EventArgs e)
        {
            if (TbxPass.Text == "")
            {
                TbxPass.Text = "Password";
                TbxPass.ForeColor = Color.DimGray;
                TbxPass.UseSystemPasswordChar = false;
                CbxShowPass.Enabled = false;
            }
            else
            {
                CbxShowPass.Enabled = true;
            }
        }

        private void TbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TbxUsername.Text == "Username" || TbxPass.Text == "Password")
                {
                    MessageBox.Show("Please enter your username and password to log in", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string username = TbxUsername.Text;
                    string password = TbxPass.Text;

                    string hashedPassword = HashPassword(password);

                    string query = "SELECT * FROM login WHERE username = '" + username + "'";

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
                                string pass = reader.GetString(1);

                                if (pass == hashedPassword && username == reader.GetString(0))
                                {
                                    MainForm mf = new MainForm();
                                    this.Hide();
                                    mf.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                        }

                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Query error: " + x.Message);
                    }
                }



            }
        }

        private void LblChangePass_Click(object sender, EventArgs e)
        {
            ChangePass cs = new ChangePass();
            this.Hide();
            cs.Show();
        }
    }
}
