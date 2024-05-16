using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline_management_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 fm = new Form11();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 fm = new Form9();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 fm =new Form12();
            fm.Show();
        }
    }
}
