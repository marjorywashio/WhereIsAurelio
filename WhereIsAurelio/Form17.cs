﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsAurelio
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormErro formErro = new FormErro();
            this.Hide();
            formErro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAcerto formAcerto = new FormAcerto();
            this.Hide();
            formAcerto.ShowDialog();
        }
    }
}
