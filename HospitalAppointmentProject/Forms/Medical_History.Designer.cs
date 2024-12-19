namespace HospitalAppointmentSystem
{
    partial class Medical_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medical_History));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ybills = new System.Windows.Forms.Label();
            this.appointlabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.settings = new System.Windows.Forms.ToolStripSplitButton();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactus = new System.Windows.Forms.ToolStripButton();
            this.profile = new System.Windows.Forms.ToolStripSplitButton();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitprogram = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(588, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ybills
            // 
            this.Ybills.AutoSize = true;
            this.Ybills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ybills.Location = new System.Drawing.Point(73, 53);
            this.Ybills.Name = "Ybills";
            this.Ybills.Size = new System.Drawing.Size(0, 22);
            this.Ybills.TabIndex = 36;
            // 
            // appointlabel
            // 
            this.appointlabel.AutoSize = true;
            this.appointlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointlabel.Location = new System.Drawing.Point(95, 63);
            this.appointlabel.Name = "appointlabel";
            this.appointlabel.Size = new System.Drawing.Size(175, 22);
            this.appointlabel.TabIndex = 37;
            this.appointlabel.Text = "Your Medical History";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.settings,
            this.contactus,
            this.profile,
            this.exitprogram});
            this.toolStrip1.Location = new System.Drawing.Point(760, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 450);
            this.toolStrip1.TabIndex = 51;
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
            // settings
            // 
            this.settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.editToolStripMenuItem});
            this.settings.Image = ((System.Drawing.Image)(resources.GetObject("settings.Image")));
            this.settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(37, 24);
            this.settings.Text = "Settings";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.toolsToolStripMenuItem.Text = "tools";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.editToolStripMenuItem.Text = "Edit";
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
            this.editProfileToolStripMenuItem,
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
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.viewProfileToolStripMenuItem.Text = "view profile";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
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
            // Medical_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.appointlabel);
            this.Controls.Add(this.Ybills);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medical_History";
            this.Text = "Medicla History";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mh_close);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Ybills;
        private System.Windows.Forms.Label appointlabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripSplitButton settings;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton contactus;
        private System.Windows.Forms.ToolStripSplitButton profile;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitprogram;
    }
}