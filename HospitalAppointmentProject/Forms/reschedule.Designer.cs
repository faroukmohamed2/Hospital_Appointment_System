namespace HospitalAppointmentSystem
{
    partial class reschedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reschedule));
            this.Appoints = new System.Windows.Forms.ComboBox();
            this.DocSearchlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AvaTimes = new System.Windows.Forms.ComboBox();
            this.changeappoint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Appoints
            // 
            this.Appoints.FormattingEnabled = true;
            this.Appoints.Location = new System.Drawing.Point(282, 131);
            this.Appoints.Name = "Appoints";
            this.Appoints.Size = new System.Drawing.Size(142, 24);
            this.Appoints.TabIndex = 35;
            // 
            // DocSearchlabel
            // 
            this.DocSearchlabel.AutoSize = true;
            this.DocSearchlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSearchlabel.Location = new System.Drawing.Point(33, 131);
            this.DocSearchlabel.Name = "DocSearchlabel";
            this.DocSearchlabel.Size = new System.Drawing.Size(165, 22);
            this.DocSearchlabel.TabIndex = 42;
            this.DocSearchlabel.Text = "Select Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Select new appointment time";
            // 
            // AvaTimes
            // 
            this.AvaTimes.FormattingEnabled = true;
            this.AvaTimes.Location = new System.Drawing.Point(282, 189);
            this.AvaTimes.Name = "AvaTimes";
            this.AvaTimes.Size = new System.Drawing.Size(142, 24);
            this.AvaTimes.TabIndex = 43;
            // 
            // changeappoint
            // 
            this.changeappoint.Location = new System.Drawing.Point(240, 247);
            this.changeappoint.Name = "changeappoint";
            this.changeappoint.Size = new System.Drawing.Size(75, 23);
            this.changeappoint.TabIndex = 45;
            this.changeappoint.Text = "submit";
            this.changeappoint.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // reschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(584, 356);
            this.Controls.Add(this.changeappoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvaTimes);
            this.Controls.Add(this.DocSearchlabel);
            this.Controls.Add(this.Appoints);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reschedule";
            this.Text = "reschedule";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Appoints;
        private System.Windows.Forms.Label DocSearchlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AvaTimes;
        private System.Windows.Forms.Button changeappoint;
    }
}