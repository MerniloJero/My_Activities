using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elderly_Information_System
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
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

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (TbxUser.Text == "Username" || TbxCurrent.Text == "Password")
            {
                MessageBox.Show("Please enter your username and password to log in", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string username = TbxUser.Text;
                string currentPassword = TbxCurrent.Text;
                string newPassword = TbxNew.Text;
                string retypedNewPassword = TbxRTN.Text;

                // Hash the current password for comparison
                string hashedCurrentPassword = HashPassword(currentPassword);

                string query = "SELECT * FROM login WHERE username = @Username";

                using (MySqlConnection connect = new MySqlConnection(Connection.ConnectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        try
                        {
                            connect.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows && reader.Read())
                                {
                                    // Check if the entered current password matches the stored hashed password
                                    if (hashedCurrentPassword == reader.GetString(1))
                                    {
                                        if (newPassword == retypedNewPassword)
                                        {
                                            // Hash the new password before updating the database
                                            string hashedNewPassword = HashPassword(newPassword);

                                            // Use parameterized query to prevent SQL injection
                                            string updateQuery = "UPDATE login SET pass = @NewPassword WHERE username = @Username";

                                            using (MySqlConnection connect1 = new MySqlConnection(Connection.ConnectionString))
                                            {
                                                using (MySqlCommand command1 = new MySqlCommand(updateQuery, connect1))
                                                {
                                                    command1.Parameters.AddWithValue("@NewPassword", hashedNewPassword);
                                                    command1.Parameters.AddWithValue("@Username", username);

                                                    try
                                                    {
                                                        connect1.Open();
                                                        command1.ExecuteNonQuery();

                                                        MessageBox.Show("Password successfully changed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                        // Redirect to the login form
                                                        LoginForm loginForm = new LoginForm();
                                                        this.Hide();
                                                        loginForm.Show();
                                                    }
                                                    catch (Exception x)
                                                    {
                                                        Console.WriteLine("Query error: " + x.Message);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Passwords do not match. Please re-enter the passwords.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            TbxRTN.Clear();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Current password is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Account does not exist. Check the username and password and try again.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
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

        }


        private void BtnCurrent_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap hide = Properties.Resources.hide1;
            System.Drawing.Bitmap show = Properties.Resources.show3;


            if(current == false)
            {
                TbxCurrent.UseSystemPasswordChar = false;
                BtnCurrent.BackgroundImage = show;
                current = true;

            }
            else
            {
                TbxCurrent.UseSystemPasswordChar = true;
                BtnCurrent.BackgroundImage = hide;
                current = false;
            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap hide = Properties.Resources.hide1;
            System.Drawing.Bitmap show = Properties.Resources.show3;


            if (newP == false)
            {
                TbxNew.UseSystemPasswordChar = false;
                BtnNew.BackgroundImage = show;
                newP = true;

            }
            else
            {
                TbxNew.UseSystemPasswordChar = true;
                BtnNew.BackgroundImage = hide;
                newP = false;
            }
        }

        private void BtnRn_Click(object sender, EventArgs e)
        {
            System.Drawing.Bitmap hide = Properties.Resources.hide1;
            System.Drawing.Bitmap show = Properties.Resources.show3;


            if (rnewP == false)
            {
                TbxRTN.UseSystemPasswordChar = false;
                BtnRn.BackgroundImage = show;
                rnewP = true;

            }
            else
            {
                TbxRTN.UseSystemPasswordChar = true;
                BtnRn.BackgroundImage = hide;
                rnewP = false;
            }
        }

        bool current = false;
        bool newP = false;
        bool rnewP = false;


        private void ChangePass_Load(object sender, EventArgs e)
        {
            System.Drawing.Bitmap hide = Properties.Resources.hide1;
            current = false;
            newP = false;
            rnewP = false;
            BtnCurrent.BackgroundImage = hide;
            BtnNew.BackgroundImage = hide;
            BtnRn.BackgroundImage = hide;

        }
    }
}
