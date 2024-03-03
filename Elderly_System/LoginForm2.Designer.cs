namespace Elderly_Information_System
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbxShowPass = new System.Windows.Forms.CheckBox();
            this.TbxPass = new System.Windows.Forms.TextBox();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.LblChangePass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.LblChangePass);
            this.panel1.Controls.Add(this.CbxShowPass);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.TbxPass);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TbxUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(495, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 450);
            this.panel1.TabIndex = 0;
            // 
            // CbxShowPass
            // 
            this.CbxShowPass.AutoSize = true;
            this.CbxShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CbxShowPass.Location = new System.Drawing.Point(97, 255);
            this.CbxShowPass.Name = "CbxShowPass";
            this.CbxShowPass.Size = new System.Drawing.Size(102, 17);
            this.CbxShowPass.TabIndex = 12;
            this.CbxShowPass.Text = "Show Password";
            this.CbxShowPass.UseVisualStyleBackColor = true;
            this.CbxShowPass.CheckedChanged += new System.EventHandler(this.CbxShowPass_CheckedChanged);
            // 
            // TbxPass
            // 
            this.TbxPass.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbxPass.Location = new System.Drawing.Point(57, 218);
            this.TbxPass.Name = "TbxPass";
            this.TbxPass.Size = new System.Drawing.Size(183, 31);
            this.TbxPass.TabIndex = 10;
            this.TbxPass.Text = "Password";
            this.TbxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxPass.Enter += new System.EventHandler(this.TbxPassword_Enter);
            this.TbxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxPass_KeyDown);
            this.TbxPass.Leave += new System.EventHandler(this.TbxPass_Leave);
            this.TbxPass.MouseLeave += new System.EventHandler(this.TbxPass_MouseLeave);
            // 
            // TbxUsername
            // 
            this.TbxUsername.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TbxUsername.Location = new System.Drawing.Point(57, 181);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(183, 31);
            this.TbxUsername.TabIndex = 8;
            this.TbxUsername.Text = "Username";
            this.TbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxUsername.Enter += new System.EventHandler(this.TbxUsername_Enter);
            this.TbxUsername.Leave += new System.EventHandler(this.TbxUsername_Leave);
            // 
            // LblChangePass
            // 
            this.LblChangePass.AutoSize = true;
            this.LblChangePass.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblChangePass.Location = new System.Drawing.Point(102, 373);
            this.LblChangePass.Name = "LblChangePass";
            this.LblChangePass.Size = new System.Drawing.Size(89, 15);
            this.LblChangePass.TabIndex = 13;
            this.LblChangePass.Text = "Change Password";
            this.LblChangePass.Click += new System.EventHandler(this.LblChangePass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BackgroundImage = global::Elderly_Information_System.Properties.Resources.bck3;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 450);
            this.panel2.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.Image = global::Elderly_Information_System.Properties.Resources.login;
            this.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogin.Location = new System.Drawing.Point(97, 331);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(101, 35);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.Text = "   LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Elderly_Information_System.Properties.Resources.photoBack2;
            this.pictureBox1.Location = new System.Drawing.Point(86, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.CheckBox CbxShowPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblChangePass;
    }
}