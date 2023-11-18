using System;
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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            this.Hide();
            form11.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            this.Hide();
            form14.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            this.Hide();
            form16.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            this.Hide();
            form12.ShowDialog();
        }
    }
}
