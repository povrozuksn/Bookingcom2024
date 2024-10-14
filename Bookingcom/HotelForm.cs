using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookingcom
{
    public partial class HotelForm : Form
    {
        public HotelForm(string idHotel)
        {
            InitializeComponent();

            List<string> hotel = SQLClass.MySelect("SELECT id, name, rating, id_city, image, adress, tel, opis FROM hotels WHERE id = " + idHotel);

            Text = hotel[1];
            HotelPictureBox.Load("../../Pictures/" + hotel[4]);
            HotelLabel.Text = hotel[1];

            int rating = Convert.ToInt32(hotel[2]);
            int x = 450;
            for(int i=0; i<rating; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Load("../../Pictures/star.png");
                pb.Location = new Point(x, 15);
                pb.Size = new Size(48, 42);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                HotelPanel.Controls.Add(pb);

                x += 55;
            }

            AdresLabel.Text = hotel[5];
            TelLabel.Text = hotel[6];
            HotelDescriptionTB.Text = hotel[7];
        }

        private void RoomPB_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm roomForm = new RoomForm(pb.Tag.ToString());
            roomForm.ShowDialog();
        }

        private void Roomlabel_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            RoomForm roomForm = new RoomForm(lbl.Text.ToString());
            roomForm.ShowDialog();
        }
    }
}
