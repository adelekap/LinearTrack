﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linear_Track_GUI
{
    public partial class exitConfirm : Form
    {
        public exitConfirm()
        {
            InitializeComponent();
        }

        private void exitConfirm_Load(object sender, EventArgs e)
        {
        }
        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RejectButtonClick(object sender, EventArgs e)
        {
            Close();
        }

    }
}
