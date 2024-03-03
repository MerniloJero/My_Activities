namespace Elderly_Information_System
{
    partial class Death
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
            this.DGVDeath = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDeath)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDeath
            // 
            this.DGVDeath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDeath.Location = new System.Drawing.Point(55, 63);
            this.DGVDeath.Name = "DGVDeath";
            this.DGVDeath.Size = new System.Drawing.Size(669, 406);
            this.DGVDeath.TabIndex = 1;
            this.DGVDeath.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDeath_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(270, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of all Deads";
            // 
            // Death
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Elderly_Information_System.Properties.Resources.back21;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVDeath);
            this.Name = "Death";
            this.Size = new System.Drawing.Size(784, 563);
            this.Load += new System.EventHandler(this.Death_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDeath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDeath;
        private System.Windows.Forms.Label label1;
    }
}
