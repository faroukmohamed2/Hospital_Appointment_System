namespace HospitalAppointmentSystem
{
    partial class Appoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appoint));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appointlabel = new System.Windows.Forms.Label();
            this.Departments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetoAppoint = new System.Windows.Forms.DateTimePicker();
            this.addappoint = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hospitals = new System.Windows.Forms.ComboBox();
            this.Doctors = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // appointlabel
            // 
            this.appointlabel.AutoSize = true;
            this.appointlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointlabel.Location = new System.Drawing.Point(36, 119);
            this.appointlabel.Name = "appointlabel";
            this.appointlabel.Size = new System.Drawing.Size(158, 22);
            this.appointlabel.TabIndex = 36;
            this.appointlabel.Text = "Select Department";
            // 
            // Departments
            // 
            this.Departments.FormattingEnabled = true;
            this.Departments.Location = new System.Drawing.Point(223, 121);
            this.Departments.Name = "Departments";
            this.Departments.Size = new System.Drawing.Size(121, 24);
            this.Departments.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 39;
            this.label1.Text = "Select Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Select Doctor";
            // 
            // datetoAppoint
            // 
            this.datetoAppoint.Location = new System.Drawing.Point(424, 232);
            this.datetoAppoint.Name = "datetoAppoint";
            this.datetoAppoint.Size = new System.Drawing.Size(200, 22);
            this.datetoAppoint.TabIndex = 41;
            // 
            // addappoint
            // 
            this.addappoint.Image = ((System.Drawing.Image)(resources.GetObject("addappoint.Image")));
            this.addappoint.Location = new System.Drawing.Point(639, 232);
            this.addappoint.Name = "addappoint";
            this.addappoint.Size = new System.Drawing.Size(67, 57);
            this.addappoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addappoint.TabIndex = 42;
            this.addappoint.TabStop = false;
            this.addappoint.MouseHover += new System.EventHandler(this.Add_hover);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(712, 251);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(38, 20);
            this.Add.TabIndex = 43;
            this.Add.Text = "Add";
            this.Add.MouseHover += new System.EventHandler(this.addlabel_hover);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(520, 269);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 20);
            this.time.TabIndex = 45;
            // 
            // times
            // 
            this.times.FormattingEnabled = true;
            this.times.Location = new System.Drawing.Point(539, 269);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(85, 24);
            this.times.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Available Time";
            // 
            // Hospitals
            // 
            this.Hospitals.Enabled = false;
            this.Hospitals.FormattingEnabled = true;
            this.Hospitals.Location = new System.Drawing.Point(223, 188);
            this.Hospitals.Name = "Hospitals";
            this.Hospitals.Size = new System.Drawing.Size(121, 24);
            this.Hospitals.TabIndex = 48;
            // 
            // Doctors
            // 
            this.Doctors.Enabled = false;
            this.Doctors.FormattingEnabled = true;
            this.Doctors.Location = new System.Drawing.Point(223, 251);
            this.Doctors.Name = "Doctors";
            this.Doctors.Size = new System.Drawing.Size(121, 24);
            this.Doctors.TabIndex = 49;
            // 
            // Appoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(879, 509);
            this.Controls.Add(this.Doctors);
            this.Controls.Add(this.Hospitals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.times);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.addappoint);
            this.Controls.Add(this.datetoAppoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Departments);
            this.Controls.Add(this.appointlabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Appoint";
            this.Text = "Appoint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addappoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label appointlabel;
        private System.Windows.Forms.ComboBox Departments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetoAppoint;
        private System.Windows.Forms.PictureBox addappoint;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ComboBox times;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Hospitals;
        private System.Windows.Forms.ComboBox Doctors;
    }
}