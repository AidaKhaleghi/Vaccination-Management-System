﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaVaccinationSystem
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }
    }
}