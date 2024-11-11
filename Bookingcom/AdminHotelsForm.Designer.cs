namespace Bookingcom
{
    partial class AdminHotelsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameHotelTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.AddHotelBtn = new System.Windows.Forms.Button();
            this.PicHotelPictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddPicHotelBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicHotelPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 299);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.AddPicHotelBtn);
            this.panel2.Controls.Add(this.PicHotelPictureBox1);
            this.panel2.Controls.Add(this.AddHotelBtn);
            this.panel2.Controls.Add(this.CityComboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.NameHotelTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 300);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " №п/п";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование гостиницы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Добавление гостиницы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Название";
            // 
            // NameHotelTextBox
            // 
            this.NameHotelTextBox.Location = new System.Drawing.Point(34, 71);
            this.NameHotelTextBox.Name = "NameHotelTextBox";
            this.NameHotelTextBox.Size = new System.Drawing.Size(291, 27);
            this.NameHotelTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Город";
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(35, 136);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(289, 28);
            this.CityComboBox.TabIndex = 4;
            // 
            // AddHotelBtn
            // 
            this.AddHotelBtn.Location = new System.Drawing.Point(34, 223);
            this.AddHotelBtn.Name = "AddHotelBtn";
            this.AddHotelBtn.Size = new System.Drawing.Size(157, 40);
            this.AddHotelBtn.TabIndex = 5;
            this.AddHotelBtn.Text = "Добавить";
            this.AddHotelBtn.UseVisualStyleBackColor = true;
            // 
            // PicHotelPictureBox1
            // 
            this.PicHotelPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicHotelPictureBox1.Location = new System.Drawing.Point(368, 71);
            this.PicHotelPictureBox1.Name = "PicHotelPictureBox1";
            this.PicHotelPictureBox1.Size = new System.Drawing.Size(316, 192);
            this.PicHotelPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicHotelPictureBox1.TabIndex = 6;
            this.PicHotelPictureBox1.TabStop = false;
            // 
            // AddPicHotelBtn
            // 
            this.AddPicHotelBtn.Location = new System.Drawing.Point(368, 36);
            this.AddPicHotelBtn.Name = "AddPicHotelBtn";
            this.AddPicHotelBtn.Size = new System.Drawing.Size(316, 29);
            this.AddPicHotelBtn.TabIndex = 7;
            this.AddPicHotelBtn.Text = "Добавить картинку";
            this.AddPicHotelBtn.UseVisualStyleBackColor = true;
            this.AddPicHotelBtn.Click += new System.EventHandler(this.AddPicHotelBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminHotelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminHotelsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminHotelsForm";
            this.Load += new System.EventHandler(this.AdminHotelsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicHotelPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPicHotelBtn;
        private System.Windows.Forms.PictureBox PicHotelPictureBox1;
        private System.Windows.Forms.Button AddHotelBtn;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameHotelTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}