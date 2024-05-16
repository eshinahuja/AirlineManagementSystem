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
  
    public partial class Form7 : Form
    {
        OracleConnection conn;
        public Form7()
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
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Inserted");
            
            MessageBox.Show("TICKET booked");
          
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand comm1 = new OracleCommand();
            comm1.Connection = conn;
            comm1.CommandText = "SELECT * FROM FLIGHT1 WHERE ARRIVAL='"+textBox4.Text+"' AND FLIGHT_ID IN ( SELECT FLIGHT_ID FROM FLIGHT1 WHERE DEPARTURE='" + textBox2.Text+"')";
            comm1.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(comm1.CommandText, conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "flight1");
            dataGridView1.DataSource = ds.Tables[0];
            int t = ds.Tables[0].Rows.Count;
            MessageBox.Show(t.ToString());
            comm1.Dispose();
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
    }
}
