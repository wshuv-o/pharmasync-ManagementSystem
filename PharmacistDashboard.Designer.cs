namespace PharmacyManagementSystem
{
    partial class PharmacistDashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPhamacistsPortal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pB2PhamacistsPortal = new System.Windows.Forms.PictureBox();
            this.lblPhamacistsName = new System.Windows.Forms.Label();
            this.btnUpdateMedicine = new System.Windows.Forms.Button();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pB1PhamacistsPortal = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB2PhamacistsPortal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1PhamacistsPortal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 886);
            this.panel4.TabIndex = 3;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMedicine.Location = new System.Drawing.Point(0, 209);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(285, 79);
            this.btnAddMedicine.TabIndex = 2;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.addMedicineButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.bodyPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 945);
            this.panel2.TabIndex = 4;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodyPanel.Location = new System.Drawing.Point(285, 0);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1315, 942);
            this.bodyPanel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblPhamacistsPortal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 58);
            this.panel3.TabIndex = 4;
            // 
            // lblPhamacistsPortal
            // 
            this.lblPhamacistsPortal.AutoSize = true;
            this.lblPhamacistsPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhamacistsPortal.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblPhamacistsPortal.Location = new System.Drawing.Point(469, 9);
            this.lblPhamacistsPortal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhamacistsPortal.Name = "lblPhamacistsPortal";
            this.lblPhamacistsPortal.Size = new System.Drawing.Size(268, 33);
            this.lblPhamacistsPortal.TabIndex = 0;
            this.lblPhamacistsPortal.Text = "Phamacists Portal";
            this.lblPhamacistsPortal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.pB2PhamacistsPortal);
            this.panel1.Controls.Add(this.lblPhamacistsName);
            this.panel1.Controls.Add(this.btnUpdateMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.pB1PhamacistsPortal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(285, 945);
            this.panel1.TabIndex = 0;
            // 
            // pB2PhamacistsPortal
            // 
            this.pB2PhamacistsPortal.Image = global::PharmacyManagementSystem.Properties.Resources.new_user;
            this.pB2PhamacistsPortal.Location = new System.Drawing.Point(57, 827);
            this.pB2PhamacistsPortal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pB2PhamacistsPortal.Name = "pB2PhamacistsPortal";
            this.pB2PhamacistsPortal.Size = new System.Drawing.Size(28, 26);
            this.pB2PhamacistsPortal.TabIndex = 0;
            this.pB2PhamacistsPortal.TabStop = false;
            // 
            // lblPhamacistsName
            // 
            this.lblPhamacistsName.AutoSize = true;
            this.lblPhamacistsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhamacistsName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPhamacistsName.Location = new System.Drawing.Point(90, 828);
            this.lblPhamacistsName.Name = "lblPhamacistsName";
            this.lblPhamacistsName.Size = new System.Drawing.Size(147, 20);
            this.lblPhamacistsName.TabIndex = 10;
            this.lblPhamacistsName.Text = "PhamacistsName";
            // 
            // btnUpdateMedicine
            // 
            this.btnUpdateMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateMedicine.Location = new System.Drawing.Point(0, 367);
            this.btnUpdateMedicine.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.btnUpdateMedicine.Name = "btnUpdateMedicine";
            this.btnUpdateMedicine.Size = new System.Drawing.Size(285, 79);
            this.btnUpdateMedicine.TabIndex = 9;
            this.btnUpdateMedicine.Text = "Update Medicine";
            this.btnUpdateMedicine.UseVisualStyleBackColor = true;
            this.btnUpdateMedicine.Click += new System.EventHandler(this.updateMedicineButton_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewMedicine.Location = new System.Drawing.Point(0, 288);
            this.btnViewMedicine.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(285, 79);
            this.btnViewMedicine.TabIndex = 8;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.UseVisualStyleBackColor = true;
            this.btnViewMedicine.Click += new System.EventHandler(this.viewMedicineButton_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Location = new System.Drawing.Point(0, 862);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(285, 73);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // pB1PhamacistsPortal
            // 
            this.pB1PhamacistsPortal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pB1PhamacistsPortal.Image = global::PharmacyManagementSystem.Properties.Resources.Health_Care_Medical_Clinic_Center_Logo__4_;
            this.pB1PhamacistsPortal.Location = new System.Drawing.Point(0, 0);
            this.pB1PhamacistsPortal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pB1PhamacistsPortal.Name = "pB1PhamacistsPortal";
            this.pB1PhamacistsPortal.Size = new System.Drawing.Size(285, 209);
            this.pB1PhamacistsPortal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB1PhamacistsPortal.TabIndex = 1;
            this.pB1PhamacistsPortal.TabStop = false;
            // 
            // PharmacistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PharmacistDashboard";
            this.Size = new System.Drawing.Size(1600, 945);
            this.panel2.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB2PhamacistsPortal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB1PhamacistsPortal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPhamacistsPortal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateMedicine;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pB1PhamacistsPortal;
        private System.Windows.Forms.Label lblPhamacistsName;
        private System.Windows.Forms.PictureBox pB2PhamacistsPortal;
    }
}
