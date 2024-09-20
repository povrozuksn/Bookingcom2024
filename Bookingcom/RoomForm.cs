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
        public RoomForm(string nameRoom)
        {
            InitializeComponent();

            Text = nameRoom;
            RoomPictureBox.Load("../../Pictures/" + nameRoom + ".jpg");
            RoomLabel.Text = nameRoom;
        }
    }
}
