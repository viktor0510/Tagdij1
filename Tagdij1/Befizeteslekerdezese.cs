﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tagdij1
{
    public partial class Befizeteslekerdezese : Form
    {
        public Befizeteslekerdezese()
        {
            InitializeComponent();
        }

        private void Befizeteslekerdezese_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Program.nyito.Show();
        }
    }
}
