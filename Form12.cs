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
    public partial class Form12 : Form
    {
        OracleConnection conn;
        public Form12()
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
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "insert into baggage values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            command1.CommandType = CommandType.Text;
            command1.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            command1.Dispose();
            conn.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
