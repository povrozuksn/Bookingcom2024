using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class AdminHotelsForm : Form
    {
        public AdminHotelsForm()
        {
            InitializeComponent();
        }

        private void AdminHotelsForm_Load(object sender, EventArgs e)
        {
            List<string> cities = SQLClass.MySelect("SELECT id, Name FROM cities");

            CityComboBox.Items.Clear();
            for (int i = 0; i < cities.Count; i += 2)
            {
                CityComboBox.Items.Add(cities[i] + ". " + cities[i + 1]);
            }


            List<string> hotels = SQLClass.MySelect("SELECT id, name, id_city FROM hotels");

            int y = 50;
            for(int i=0; i<hotels.Count; i+=3)
            {
                Label lbl1 = new Label();
                lbl1.Text = hotels[i];
                lbl1.Location = new Point(20, y);
                lbl1.Size = new Size(50, 30);
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Text = hotels[i+1];
                lbl2.Location = new Point(100, y);
                lbl2.Size = new Size(200, 30);
                panel1.Controls.Add(lbl2);

                List<string> city = SQLClass.MySelect("SELECT Name FROM cities WHERE id = '" + hotels[i + 2] + "'");

                Label lbl3 = new Label();
                lbl3.Text = city[0];
                lbl3.Location = new Point(350, y);
                lbl3.Size = new Size(200, 30);
                panel1.Controls.Add(lbl3);

                y += 40;
            }
        }

        string adress;
        private void AddPicHotelBtn_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                PicHotelPictureBox1.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }
    }
}
