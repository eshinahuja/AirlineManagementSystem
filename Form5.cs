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
    public partial class Form5 : Form
    {
        OracleConnection conn;
        public Form5()
        {
            InitializeComponent();
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("USER ID = system ; PASSWORD = vansh1234");
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
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int charge = int.Parse(textBox5.Text);
            //int id = int.Parse(textBox1.Text);

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
            comm2.CommandText = "update flight1 set flight_name='" + textBox2.Text + "' where flight_id='" + textBox1.Text+"'";
            comm2.CommandType = CommandType.Text;
            comm3.CommandText = "update flight1 set departure='" + textBox6.Text + "' where flight_id='" + textBox1.Text + "'";
            comm3.CommandType = CommandType.Text;
            comm4.CommandText = "update flight1 set arrival='" + textBox7.Text + "' where flight_id='" + textBox1.Text + "'";
            comm4.CommandType = CommandType.Text;
            comm5.CommandText = "update flight1 set dep_time='" + textBox3.Text + "' where flight_id='" + textBox1.Text + "'";
            comm5.CommandType = CommandType.Text;
            comm6.CommandText = "update flight1 set arr_time='" + textBox4.Text + "' where flight_id='" + textBox1.Text + "'";
            comm6.CommandType = CommandType.Text;
            comm7.CommandText = "update flight1 set charges='" + textBox5.Text + "' where flight_id='" + textBox1.Text + "'";
            comm7.CommandType = CommandType.Text;
            //command1.CommandText = "insert into flight values(" + id + ",'" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "'," + charge + ",'" + textBox3.Text + "','" + textBox4.Text + "')";
            //command1.CommandType = CommandType.Text;
            //MessageBox.Show("Inserted");
            //command1.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
            comm3.ExecuteNonQuery();
            comm4.ExecuteNonQuery();
            comm5.ExecuteNonQuery();
            comm6.ExecuteNonQuery();
            comm7.ExecuteNonQuery();
            MessageBox.Show("updated.");
            
            comm1.CommandText = "select * from flight1";
            comm1.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(comm1.CommandText, conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "flight1");
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
    }

