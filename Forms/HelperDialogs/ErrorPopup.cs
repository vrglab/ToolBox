﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox.Forms.HelperDialogs
{
    public partial class ErrorPopup : Form
    {
        public ErrorPopup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetError(string error)
        {
            label1.Text = error;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ErrorPopup_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = SystemIcons.Error.ToBitmap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
