namespace HospitalAppointmentSystem
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.Appoints = new System.Windows.Forms.PictureBox();
            this.greeting = new System.Windows.Forms.Label();
            this.curApp = new System.Windows.Forms.Label();
            this.addappoint = new System.Windows.Forms.PictureBox();
            this.appointlabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
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
            this.toolStrip1.Location = new System.Drawing.Point(950, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 476);
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
            // 
            // Appoints
            // 
            this.Appoints.Image = ((System.Drawing.Image)(resources.GetObject("Appoints.Image")));
            this.Appoints.Location = new System.Drawing.Point(165, 149);
            this.Appoints.Name = "Appoints";
            this.Appoints.Size = new System.Drawing.Size(67, 63);
            this.Appoints.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Appoints.TabIndex = 52;
            this.Appoints.TabStop = false;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(161, 102);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(51, 22);
            this.greeting.TabIndex = 53;
            this.greeting.Text = "Hello";
            // 
            // curApp
            // 
            this.curApp.AutoSize = true;
            this.curApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curApp.Location = new System.Drawing.Point(238, 171);
            this.curApp.Name = "curApp";
            this.curApp.Size = new System.Drawing.Size(184, 22);
            this.curApp.TabIndex = 54;
            this.curApp.Text = "Current Appointments";
            // 
            // addappoint
            // 
            this.addappoint.Image = ((System.Drawing.Image)(resources.GetObject("addappoint.Image")));
            this.addappoint.Location = new System.Drawing.Point(165, 234);
            this.addappoint.Name = "addappoint";
            this.addappoint.Size = new System.Drawing.Size(67, 63);
            this.addappoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addappoint.TabIndex = 56;
            this.addappoint.TabStop = false;
            // 
            // appointlabel
            // 
            this.appointlabel.AutoSize = true;
            this.appointlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointlabel.Location = new System.Drawing.Point(238, 252);
            this.appointlabel.Name = "appointlabel";
            this.appointlabel.Size = new System.Drawing.Size(146, 22);
            this.appointlabel.TabIndex = 55;
            this.appointlabel.Text = "New Prescription";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(165, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "Patient Info";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(990, 476);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addappoint);
            this.Controls.Add(this.appointlabel);
            this.Controls.Add(this.curApp);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.Appoints);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctor";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.PictureBox Appoints;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label curApp;
        private System.Windows.Forms.PictureBox addappoint;
        private System.Windows.Forms.Label appointlabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}