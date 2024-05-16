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
    public partial class Form10 : Form
    {
        OracleConnection conn;
        public Form10()
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
            OracleCommand comm1 = new OracleCommand();
            comm1.Connection = conn;
            OracleCommand comm2 = conn.CreateCommand();
            OracleCommand comm6 = conn.CreateCommand();
            OracleCommand comm5 = conn.CreateCommand();
            OracleCommand comm4 = conn.CreateCommand();
            OracleCommand comm3 = conn.CreateCommand();
            OracleCommand comm7 = conn.CreateCommand();
            MessageBox.Show("here1.");
            comm2.CommandText = "update crew1 set id='" + textBox1.Text + "' where flight_id='" + textBox4.Text + "'";
            comm2.CommandType = CommandType.Text;
            comm3.CommandText = "update crew1 set name='" + textBox2.Text + "' where flight_id='" + textBox4.Text + "'";
            comm3.CommandType = CommandType.Text;
            comm4.CommandText = "update crew1 set age='" + textBox3.Text + "' where flight_id='" + textBox4.Text + "'";
            comm4.CommandType = CommandType.Text;
            comm5.CommandText = "update crew1 set role='" + textBox5.Text + "' where flight_id='" + textBox4.Text + "'";
            comm5.CommandType = CommandType.Text;
            comm6.CommandText = "update crew1 set gender='" + textBox6.Text + "' where flight_id='" + textBox4.Text + "'";
            comm6.CommandType = CommandType.Text;
            //command1.CommandText = "insert into flight values(" + id + ",'" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "'," + charge + ",'" + textBox3.Text + "','" + textBox4.Text + "')";
            //command1.CommandType = CommandType.Text;
            //MessageBox.Show("Inserted");
            //command1.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            comm3.ExecuteNonQuery();
            comm4.ExecuteNonQuery();
            comm5.ExecuteNonQuery();
            comm6.ExecuteNonQuery();
          
            MessageBox.Show("updated.");

            comm1.CommandText = "select * from crew1";
            comm1.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(comm1.CommandText, conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "crew1");
            dataGridView1.DataSource = ds.Tables[0];
            int t = ds.Tables[0].Rows.Count;
            MessageBox.Show(t.ToString());
            command1.Dispose();
            comm2.Dispose();
            comm3.Dispose();
            comm4.Dispose();
            comm5.Dispose();
            comm6.Dispose();
            comm7.Dispose();
            conn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
