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
        public HotelForm(string nameHotel)
        {
            InitializeComponent();

            Text = nameHotel;
            //HotelPictureBox.Load("../../Pictures/" + nameHotel + ".jpg");
            HotelLabel.Text = nameHotel; 
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
