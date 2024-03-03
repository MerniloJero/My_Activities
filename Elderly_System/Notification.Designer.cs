namespace Elderly_Information_System
{
    partial class Notification
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVElderlist = new System.Windows.Forms.DataGridView();
            this.CbxPension = new System.Windows.Forms.ComboBox();
            this.LblPension = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVElderlist)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVElderlist
            // 
            this.DGVElderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVElderlist.Location = new System.Drawing.Point(59, 48);
            this.DGVElderlist.Name = "DGVElderlist";
            this.DGVElderlist.Size = new System.Drawing.Size(669, 391);
            this.DGVElderlist.TabIndex = 1;
            this.DGVElderlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVElderlist_CellContentClick);
            // 
            // CbxPension
            // 
            this.CbxPension.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.CbxPension.FormattingEnabled = true;
            this.CbxPension.Items.AddRange(new object[] {
            "SPISC",
            "SSS",
            "GSIS",
            "NONE"});
            this.CbxPension.Location = new System.Drawing.Point(138, 505);
            this.CbxPension.Name = "CbxPension";
            this.CbxPension.Size = new System.Drawing.Size(177, 30);
            this.CbxPension.TabIndex = 36;
            // 
            // LblPension
            // 
            this.LblPension.AutoSize = true;
            this.LblPension.BackColor = System.Drawing.Color.Transparent;
            this.LblPension.Font = new System.Drawing.Font("Cambria", 12F);
            this.LblPension.Location = new System.Drawing.Point(60, 511);
            this.LblPension.Name = "LblPension";
            this.LblPension.Size = new System.Drawing.Size(72, 19);
            this.LblPension.TabIndex = 35;
            this.LblPension.Text = "Pension: ";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(590, 494);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(138, 50);
            this.BtnSave.TabIndex = 37;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.Color.Transparent;
            this.LblId.Font = new System.Drawing.Font("Cambria", 12F);
            this.LblId.Location = new System.Drawing.Point(174, 472);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(22, 19);
            this.LblId.TabIndex = 39;
            this.LblId.Text = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Resident ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(56, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 14);
            this.label2.TabIndex = 40;
            this.label2.Text = "Double Click the Content in the Data Grid View to Edit and Delete";
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elderly_Information_System.Properties.Resources.back22;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbxPension);
            this.Controls.Add(this.LblPension);
            this.Controls.Add(this.DGVElderlist);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(784, 563);
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVElderlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVElderlist;
        private System.Windows.Forms.ComboBox CbxPension;
        private System.Windows.Forms.Label LblPension;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
