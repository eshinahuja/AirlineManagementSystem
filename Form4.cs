using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace airline_management_system
{
    public partial class Form4 : Form
    {
        OracleConnection conn;
        public Form4()
        {
            InitializeComponent();
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("USER ID=system;PASSWORD=vansh1234");
            try
            {
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "insert into passenger values('" +textBox4.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            command1.CommandType = CommandType.Text;
            MessageBox.Show("Account Created! Press ok to login");
            command1.ExecuteNonQuery();
            command1.Dispose();
            conn.Close();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
