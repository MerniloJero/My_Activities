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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_MouseHover(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            System.Threading.Thread.Sleep(300);
            loginForm.Show();

        }

        private void WelcomeForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            System.Threading.Thread.Sleep(300);
            loginForm.Show();

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
