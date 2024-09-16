﻿namespace Bookingcom
{
    partial class RoomForm
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
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.RoomPictureBox = new System.Windows.Forms.PictureBox();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.RoomDescriptionTB = new System.Windows.Forms.TextBox();
            this.BookingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IndateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OutdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BookingButton = new System.Windows.Forms.Button();
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.BookingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomPanel
            // 
            this.RoomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RoomPanel.Controls.Add(this.RoomDescriptionTB);
            this.RoomPanel.Controls.Add(this.RoomLabel);
            this.RoomPanel.Controls.Add(this.RoomPictureBox);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoomPanel.Location = new System.Drawing.Point(0, 0);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(1053, 330);
            this.RoomPanel.TabIndex = 0;
            // 
            // RoomPictureBox
            // 
            this.RoomPictureBox.Location = new System.Drawing.Point(47, 31);
            this.RoomPictureBox.Name = "RoomPictureBox";
            this.RoomPictureBox.Size = new System.Drawing.Size(304, 222);
            this.RoomPictureBox.TabIndex = 0;
            this.RoomPictureBox.TabStop = false;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(43, 270);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(58, 22);
            this.RoomLabel.TabIndex = 1;
            this.RoomLabel.Text = "label1";
            // 
            // RoomDescriptionTB
            // 
            this.RoomDescriptionTB.Enabled = false;
            this.RoomDescriptionTB.Location = new System.Drawing.Point(382, 31);
            this.RoomDescriptionTB.Multiline = true;
            this.RoomDescriptionTB.Name = "RoomDescriptionTB";
            this.RoomDescriptionTB.ReadOnly = true;
            this.RoomDescriptionTB.Size = new System.Drawing.Size(644, 124);
            this.RoomDescriptionTB.TabIndex = 2;
            // 
            // BookingPanel
            // 
            this.BookingPanel.BackColor = System.Drawing.Color.White;
            this.BookingPanel.Controls.Add(this.BookingButton);
            this.BookingPanel.Controls.Add(this.OutdateTimePicker);
            this.BookingPanel.Controls.Add(this.IndateTimePicker);
            this.BookingPanel.Controls.Add(this.label2);
            this.BookingPanel.Controls.Add(this.label1);
            this.BookingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookingPanel.Location = new System.Drawing.Point(0, 330);
            this.BookingPanel.Name = "BookingPanel";
            this.BookingPanel.Size = new System.Drawing.Size(1053, 150);
            this.BookingPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заезда:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата выезда:";
            // 
            // IndateTimePicker
            // 
            this.IndateTimePicker.Location = new System.Drawing.Point(381, 36);
            this.IndateTimePicker.Name = "IndateTimePicker";
            this.IndateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.IndateTimePicker.TabIndex = 2;
            // 
            // OutdateTimePicker
            // 
            this.OutdateTimePicker.Location = new System.Drawing.Point(381, 74);
            this.OutdateTimePicker.Name = "OutdateTimePicker";
            this.OutdateTimePicker.Size = new System.Drawing.Size(200, 28);
            this.OutdateTimePicker.TabIndex = 3;
            // 
            // BookingButton
            // 
            this.BookingButton.Location = new System.Drawing.Point(606, 36);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(235, 65);
            this.BookingButton.TabIndex = 4;
            this.BookingButton.Text = "Забронировать";
            this.BookingButton.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 480);
            this.Controls.Add(this.BookingPanel);
            this.Controls.Add(this.RoomPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.BookingPanel.ResumeLayout(false);
            this.BookingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.PictureBox RoomPictureBox;
        private System.Windows.Forms.TextBox RoomDescriptionTB;
        private System.Windows.Forms.Panel BookingPanel;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.DateTimePicker OutdateTimePicker;
        private System.Windows.Forms.DateTimePicker IndateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}