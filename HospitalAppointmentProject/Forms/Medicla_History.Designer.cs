namespace HospitalAppointmentSystem
{
    partial class Medicla_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicla_History));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ybills = new System.Windows.Forms.Label();
            this.appointlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // Medicla_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appointlabel);
            this.Controls.Add(this.Ybills);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medicla_History";
            this.Text = "Medicla History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Ybills;
        private System.Windows.Forms.Label appointlabel;
    }
}