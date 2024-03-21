using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Vize
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 nesne = new Form5();
            nesne.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 nesne = new Form6();
            nesne.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 nesne = new Form7();
            nesne.Show();

        }
    }
}
