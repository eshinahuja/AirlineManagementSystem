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
    public partial class Form9 : Form
    {
        OracleConnection conn;
        public Form9()
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
        private void button1_Click(object sender, EventArgs e)
        {

            ConnectDB();
            OracleCommand comm = conn.CreateCommand();
            comm.CommandText = "insert into crew1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "')";
            comm.CommandType = CommandType.Text;
            MessageBox.Show("Inserted");
            comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 fm = new Form10();
            fm.Show();
        }
    }
}
