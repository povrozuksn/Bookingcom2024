namespace Bookingcom
{
    partial class HotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.HotelPanel = new System.Windows.Forms.Panel();
            this.HotelLabel = new System.Windows.Forms.Label();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.RoomsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HotelDescriptionTB = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdresLabel = new System.Windows.Forms.Label();
            this.TelLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HotelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.RoomsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelPanel
            // 
            this.HotelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HotelPanel.Controls.Add(this.TelLabel);
            this.HotelPanel.Controls.Add(this.label4);
            this.HotelPanel.Controls.Add(this.AdresLabel);
            this.HotelPanel.Controls.Add(this.label2);
            this.HotelPanel.Controls.Add(this.pictureBox2);
            this.HotelPanel.Controls.Add(this.HotelDescriptionTB);
            this.HotelPanel.Controls.Add(this.HotelLabel);
            this.HotelPanel.Controls.Add(this.HotelPictureBox);
            this.HotelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HotelPanel.Location = new System.Drawing.Point(0, 0);
            this.HotelPanel.Name = "HotelPanel";
            this.HotelPanel.Size = new System.Drawing.Size(1094, 320);
            this.HotelPanel.TabIndex = 0;
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Location = new System.Drawing.Point(16, 272);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(58, 22);
            this.HotelLabel.TabIndex = 1;
            this.HotelLabel.Text = "label1";
            // 
            // HotelPictureBox
            // 
            this.HotelPictureBox.Location = new System.Drawing.Point(20, 17);
            this.HotelPictureBox.Name = "HotelPictureBox";
            this.HotelPictureBox.Size = new System.Drawing.Size(366, 252);
            this.HotelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HotelPictureBox.TabIndex = 0;
            this.HotelPictureBox.TabStop = false;
            // 
            // RoomsPanel
            // 
            this.RoomsPanel.BackColor = System.Drawing.Color.White;
            this.RoomsPanel.Controls.Add(this.label1);
            this.RoomsPanel.Controls.Add(this.pictureBox1);
            this.RoomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsPanel.Location = new System.Drawing.Point(0, 320);
            this.RoomsPanel.Name = "RoomsPanel";
            this.RoomsPanel.Size = new System.Drawing.Size(1094, 335);
            this.RoomsPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HotelDescriptionTB
            // 
            this.HotelDescriptionTB.Enabled = false;
            this.HotelDescriptionTB.Location = new System.Drawing.Point(428, 114);
            this.HotelDescriptionTB.Multiline = true;
            this.HotelDescriptionTB.Name = "HotelDescriptionTB";
            this.HotelDescriptionTB.ReadOnly = true;
            this.HotelDescriptionTB.Size = new System.Drawing.Size(625, 155);
            this.HotelDescriptionTB.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(428, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес:";
            // 
            // AdresLabel
            // 
            this.AdresLabel.AutoSize = true;
            this.AdresLabel.Location = new System.Drawing.Point(757, 57);
            this.AdresLabel.Name = "AdresLabel";
            this.AdresLabel.Size = new System.Drawing.Size(30, 22);
            this.AdresLabel.TabIndex = 5;
            this.AdresLabel.Text = "    ";
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(757, 89);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(30, 22);
            this.TelLabel.TabIndex = 7;
            this.TelLabel.Text = "    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тел.:";
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 655);
            this.Controls.Add(this.RoomsPanel);
            this.Controls.Add(this.HotelPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            this.HotelPanel.ResumeLayout(false);
            this.HotelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).EndInit();
            this.RoomsPanel.ResumeLayout(false);
            this.RoomsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HotelPanel;
        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Panel RoomsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AdresLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox HotelDescriptionTB;
    }
}