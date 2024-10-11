using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bookingcom
{
    public partial class MainForm : Form
    { 
        public MainForm()
        {
            InitializeComponent();

            FiltrPanel.Height = FiltrButton.Height;

            List<string> cities = SQLClass.MySelect("SELECT id, Name FROM cities");
            List<string> hotels = SQLClass.MySelect("SELECT id, name, rating, id_city, image FROM hotels");
          
            for(int i=0; i<cities.Count; i+=2)
            {
                CityComboBox.Items.Add(cities[i] + ". "+ cities[i+1]);
            }

            int x = 50;
            for(int i=0; i<hotels.Count; i+=5)
            {
                Label lbl = new Label();
                lbl.Text = hotels[i+1];
                lbl.Location = new Point(x, 330);
                lbl.Size = new Size(250, 20);
                lbl.Tag = hotels[i];
                lbl.Click += new EventHandler(HotelLabel_Click);
                MainPanel.Controls.Add(lbl);

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + hotels[i + 4]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 50);
                pb.Size = new Size(350, 250);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                MainPanel.Controls.Add(pb);

                x += 380;
            }

           
        }

        private void HotelPB_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            HotelForm hotelForm = new HotelForm(pb.Tag.ToString());
            hotelForm.ShowDialog();
        }

        private void HotelLabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            HotelForm hotelForm = new HotelForm(lbl.Tag.ToString());
            hotelForm.ShowDialog();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Height > 100)
            {
                FiltrPanel.Height = FiltrButton.Height;
            }
            else
            {
                FiltrPanel.Height = 150;
            }
        }
    }
}
