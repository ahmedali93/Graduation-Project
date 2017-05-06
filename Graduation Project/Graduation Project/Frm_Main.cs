﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Project
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_SizeChanged(object sender, EventArgs e)
        {
            int x = this.Width;
            lab_address.Location = new Point(x / 2, 10);
        }

        private void label_booking_patient_Click(object sender, EventArgs e)
        {
            Frm_Patients_search_engine frm = new Frm_Patients_search_engine();
            frm.Show();
        }
    }
}
