﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HotelPB_Click(object sender, EventArgs e)
        {
            HotelForm hotelForm = new HotelForm();
            hotelForm.ShowDialog();
        }

        private void HotelLabel_Click(object sender, EventArgs e)
        {
            HotelForm hotelForm = new HotelForm();
            hotelForm.ShowDialog();
        }
    }
}
