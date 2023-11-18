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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            this.Hide();
            form13.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            this.Hide();
            form15.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }
    }
}
