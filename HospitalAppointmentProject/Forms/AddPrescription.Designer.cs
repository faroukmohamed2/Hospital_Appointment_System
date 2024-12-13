namespace HospitalAppointmentSystem
{
    partial class AddPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescription));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pEmail = new System.Windows.Forms.TextBox();
            this.FNlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.TextBox();
            this.Ddiscription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.preDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Label();
            this.addappoint = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Location = new System.Drawing.Point(632, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 468);
            this.toolStrip1.TabIndex = 53;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pEmail
            // 
            this.pEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEmail.Location = new System.Drawing.Point(187, 126);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(170, 22);
            this.pEmail.TabIndex = 54;
            // 
            // FNlabel
            // 
            this.FNlabel.AutoSize = true;
            this.FNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNlabel.Location = new System.Drawing.Point(53, 126);
            this.FNlabel.Name = "FNlabel";
            this.FNlabel.Size = new System.Drawing.Size(108, 20);
            this.FNlabel.TabIndex = 55;
            this.FNlabel.Text = "Pateint Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Disease Name";
            // 
            // DName
            // 
            this.DName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DName.Location = new System.Drawing.Point(187, 175);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(170, 22);
            this.DName.TabIndex = 56;
            // 
            // Ddiscription
            // 
            this.Ddiscription.Location = new System.Drawing.Point(187, 229);
            this.Ddiscription.Name = "Ddiscription";
            this.Ddiscription.Size = new System.Drawing.Size(170, 96);
            this.Ddiscription.TabIndex = 58;
            this.Ddiscription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Disease Discription";
            // 
            // preDate
            // 
            this.preDate.Location = new System.Drawing.Point(187, 354);
            this.preDate.Name = "preDate";
            this.preDate.Size = new System.Drawing.Size(200, 22);
            this.preDate.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "date";
            this.label3.Visible = false;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(466, 353);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(38, 20);
            this.Add.TabIndex = 63;
            this.Add.Text = "Add";
            // 
            // addappoint
            // 
            this.addappoint.Image = ((System.Drawing.Image)(resources.GetObject("addappoint.Image")));
            this.addappoint.Location = new System.Drawing.Point(393, 334);
            this.addappoint.Name = "addappoint";
            this.addappoint.Size = new System.Drawing.Size(67, 57);
            this.addappoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addappoint.TabIndex = 62;
            this.addappoint.TabStop = false;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(672, 468);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.addappoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.preDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ddiscription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.FNlabel);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPrescription";
            this.Text = "AddPrescription";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).EndInit();
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
        private System.Windows.Forms.TextBox pEmail;
        private System.Windows.Forms.Label FNlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.RichTextBox Ddiscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker preDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.PictureBox addappoint;
    }
}