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
            this.HotelPanel = new System.Windows.Forms.Panel();
            this.HotelLabel = new System.Windows.Forms.Label();
            this.HotelPictureBox = new System.Windows.Forms.PictureBox();
            this.RoomsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HotelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HotelPictureBox)).BeginInit();
            this.RoomsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelPanel
            // 
            this.HotelPanel.Controls.Add(this.HotelLabel);
            this.HotelPanel.Controls.Add(this.HotelPictureBox);
            this.HotelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HotelPanel.Location = new System.Drawing.Point(0, 0);
            this.HotelPanel.Name = "HotelPanel";
            this.HotelPanel.Size = new System.Drawing.Size(1094, 293);
            this.HotelPanel.TabIndex = 0;
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Location = new System.Drawing.Point(16, 247);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(58, 22);
            this.HotelLabel.TabIndex = 1;
            this.HotelLabel.Text = "label1";
            // 
            // HotelPictureBox
            // 
            this.HotelPictureBox.Location = new System.Drawing.Point(20, 17);
            this.HotelPictureBox.Name = "HotelPictureBox";
            this.HotelPictureBox.Size = new System.Drawing.Size(366, 214);
            this.HotelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HotelPictureBox.TabIndex = 0;
            this.HotelPictureBox.TabStop = false;
            // 
            // RoomsPanel
            // 
            this.RoomsPanel.Controls.Add(this.label1);
            this.RoomsPanel.Controls.Add(this.pictureBox1);
            this.RoomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsPanel.Location = new System.Drawing.Point(0, 293);
            this.RoomsPanel.Name = "RoomsPanel";
            this.RoomsPanel.Size = new System.Drawing.Size(1094, 362);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HotelPanel;
        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.PictureBox HotelPictureBox;
        private System.Windows.Forms.Panel RoomsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}