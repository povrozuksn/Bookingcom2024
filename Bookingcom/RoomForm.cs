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
    public partial class RoomForm : Form
    {
        public RoomForm(string idRoom)
        {
            InitializeComponent();

            List<string> room = SQLClass.MySelect("SELECT * FROM rooms WHERE id = " + idRoom);

            Text = room[1];
            RoomPictureBox.Load("../../Pictures/" + room[3]);
            RoomLabel.Text = room[1];
            RoomDescriptionTB.Text = room[6];
            PriceLabel.Text = "Цена, руб. " + room[4];
            SpaceLabel.Text = "Площадь, кв.м. " + room[5];
        }
    }
}
