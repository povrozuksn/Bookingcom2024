namespace Bookingcom
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
            this.RoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomPanel
            // 
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
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 629);
            this.Controls.Add(this.RoomPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.PictureBox RoomPictureBox;
    }
}