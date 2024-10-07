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

            List<string> cities = SQLClass.MySelect("SELECT id, Name FROM cities");
            List<string> hotels = SQLClass.MySelect("SELECT id, name, rating, id_city FROM hotels");
          

            for(int i=0; i<cities.Count; i+=2)
            {
                CityComboBox.Items.Add(cities[i] + ". "+ cities[i+1]);
            }

           
            FiltrPanel.Height = FiltrButton.Height;
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
            HotelForm hotelForm = new HotelForm(lbl.Text.ToString());
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
