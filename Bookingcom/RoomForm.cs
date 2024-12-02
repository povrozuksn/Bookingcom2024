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
        string idRoom;
        public RoomForm(string _idRoom)
        {
            InitializeComponent();

            idRoom = _idRoom;

            SaveButton.Visible = Convert.ToBoolean(MainForm.isAdmin);

            RoomDescriptionTB.ReadOnly = !Convert.ToBoolean(MainForm.isAdmin);
            RoomDescriptionTB.Enabled = Convert.ToBoolean(MainForm.isAdmin);

            PriceTextBox.Visible = Convert.ToBoolean(MainForm.isAdmin);
            SpaceTextBox.Visible = Convert.ToBoolean(MainForm.isAdmin);

            List<string> room = SQLClass.MySelect("SELECT * FROM rooms WHERE id = " + idRoom);

            Text = room[1];
            RoomPictureBox.Load("../../Pictures/" + room[3]);
            RoomLabel.Text = room[1];
            RoomDescriptionTB.Text = room[6];
            PriceLabel.Text = "Цена, руб. " + room[4];
            SpaceLabel.Text = "Площадь, кв.м. " + room[5];
            PriceTextBox.Text = room[4];
            SpaceTextBox.Text = room[5];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SQLClass.MyUpDate("UPDATE rooms SET opis = '" + RoomDescriptionTB.Text + "', price = '" + PriceTextBox.Text + "', space = '" + SpaceTextBox.Text + "' WHERE id = " + idRoom);
            MessageBox.Show("Сохранено");
        }
    }
}
