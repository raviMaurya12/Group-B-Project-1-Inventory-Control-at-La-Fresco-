﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            var m = new ManageCustomers();
            m.ShowDialog();
            
        }

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            var m = new Manageusers();
            m.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
