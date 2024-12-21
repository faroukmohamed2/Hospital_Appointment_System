namespace HospitalAppointmentSystem
{
    partial class Prescriptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prescriptions));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointlabel = new System.Windows.Forms.Label();
            this.Medicines = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.preNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pharmacies = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.profile = new System.Windows.Forms.ToolStripSplitButton();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pharmacies)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // appointlabel
            // 
            this.appointlabel.AutoSize = true;
            this.appointlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointlabel.Location = new System.Drawing.Point(56, 93);
            this.appointlabel.Name = "appointlabel";
            this.appointlabel.Size = new System.Drawing.Size(157, 22);
            this.appointlabel.TabIndex = 51;
            this.appointlabel.Text = "Your Prescriptions";
            // 
            // Medicines
            // 
            this.Medicines.FormattingEnabled = true;
            this.Medicines.ItemHeight = 16;
            this.Medicines.Location = new System.Drawing.Point(757, 140);
            this.Medicines.Name = "Medicines";
            this.Medicines.Size = new System.Drawing.Size(194, 132);
            this.Medicines.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // preNum
            // 
            this.preNum.FormattingEnabled = true;
            this.preNum.Location = new System.Drawing.Point(609, 140);
            this.preNum.Name = "preNum";
            this.preNum.Size = new System.Drawing.Size(121, 24);
            this.preNum.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "select prescription by number";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "select Medicine ";
            // 
            // Pharmacies
            // 
            this.Pharmacies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pharmacies.Location = new System.Drawing.Point(259, 372);
            this.Pharmacies.Name = "Pharmacies";
            this.Pharmacies.RowHeadersWidth = 51;
            this.Pharmacies.RowTemplate.Height = 24;
            this.Pharmacies.Size = new System.Drawing.Size(471, 150);
            this.Pharmacies.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "Medicine Available in";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.contactus,
            this.profile,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(1066, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 629);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Home
            // 
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(37, 24);
            this.Home.Text = "home page";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // contactus
            // 
            this.contactus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactus.Image = ((System.Drawing.Image)(resources.GetObject("contactus.Image")));
            this.contactus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.contactus.Name = "contactus";
            this.contactus.Size = new System.Drawing.Size(37, 24);
            this.contactus.Text = "contact us";
            this.contactus.Click += new System.EventHandler(this.contactus_Click);
            // 
            // profile
            // 
            this.profile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProfileToolStripMenuItem,
            this.removeAccountToolStripMenuItem});
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(37, 24);
            this.profile.Text = "Your profile";
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewProfileToolStripMenuItem.Text = "view profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeAccountToolStripMenuItem.Text = "Remove Account";
            // 
            // exitprogram
            // 
            this.exitprogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitprogram.Image = ((System.Drawing.Image)(resources.GetObject("exitprogram.Image")));
            this.exitprogram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitprogram.Name = "exitprogram";
            this.exitprogram.Size = new System.Drawing.Size(37, 24);
            this.exitprogram.Text = "exit";
            this.exitprogram.Click += new System.EventHandler(this.exitprogram_Click);
            // 
            // Prescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1106, 629);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pharmacies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Medicines);
            this.Controls.Add(this.appointlabel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prescriptions";
            this.Text = "Prescriptions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pre_close);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pharmacies)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label appointlabel;
        private System.Windows.Forms.ListBox Medicines;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox preNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Pharmacies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripSplitButton profile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitprogram;
    }
}