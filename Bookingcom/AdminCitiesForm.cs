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
    public partial class AdminCitiesForm : Form
    {
        public AdminCitiesForm()
        {
            InitializeComponent();

            List<string> cities = SQLClass.MySelect("SELECT id, Name FROM cities");

            int y = 45;
            for(int i=0; i<cities.Count; i+=2)
            {
                Label lbl = new Label();
                lbl.Text = cities[i+1];
                lbl.Location = new Point(12, y);
                lbl.Size = new Size(200, 30);
                panel1.Controls.Add(lbl);

                y += 30;
            }
        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            if(AddCityTextBox.Text != "")
            {
                SQLClass.MyUpDate("INSERT INTO cities (Name) VALUES ('" + AddCityTextBox.Text + "')");
                MessageBox.Show("Успешно добавлено");
                AddCityTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Вы забыли ввести название города");
            }

        }
    }
}
