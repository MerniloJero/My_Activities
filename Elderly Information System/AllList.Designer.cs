namespace Elderly_Information_System
{
    partial class AllList
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
            this.DGVAllList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVAllList
            // 
            this.DGVAllList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DGVAllList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVAllList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAllList.Location = new System.Drawing.Point(42, 147);
            this.DGVAllList.Name = "DGVAllList";
            this.DGVAllList.Size = new System.Drawing.Size(682, 399);
            this.DGVAllList.TabIndex = 0;
            this.DGVAllList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAllList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(263, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of All Citizen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Double Click the Content in the Data Grid View to Edit and Delete";
            // 
            // TbxSearch
            // 
            this.TbxSearch.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.TbxSearch.Location = new System.Drawing.Point(554, 83);
            this.TbxSearch.Name = "TbxSearch";
            this.TbxSearch.Size = new System.Drawing.Size(157, 30);
            this.TbxSearch.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImage = global::Elderly_Information_System.Properties.Resources.browse;
            this.BtnSearch.Image = global::Elderly_Information_System.Properties.Resources.search;
            this.BtnSearch.Location = new System.Drawing.Point(717, 83);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(50, 30);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // AllList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Elderly_Information_System.Properties.Resources.back23;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVAllList);
            this.Name = "AllList";
            this.Size = new System.Drawing.Size(784, 563);
            this.Load += new System.EventHandler(this.AllList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVAllList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxSearch;
        private System.Windows.Forms.Button BtnSearch;
    }
}
