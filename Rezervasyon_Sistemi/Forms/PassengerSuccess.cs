﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon_Sistemi.Forms
{
    public partial class PassengerSuccess : Form
    {
        public string text { get; set; }
        public PassengerSuccess(string text)
        {
            this.text = text;

            InitializeComponent();
            this.successTextBox.Text = text;
        }

        private void PassengerSuccess_Load(object sender, EventArgs e)
        {

        }
    }
}
