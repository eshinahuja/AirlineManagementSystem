using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace airline_management_system
{
    public partial class Form13 : Form
    {
        OracleConnection conn;
        public Form13()
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
            command1.CommandText = " update passenger set password='" + textBox2.Text + "' where username in (select username from passenger where username= '" + textBox1.Text + "')";
            command1.CommandType = CommandType.Text;
            command1.ExecuteNonQuery();
            MessageBox.Show("PASSWORD UPDATED");
            command1.Dispose();
            this.Close();
            conn.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
