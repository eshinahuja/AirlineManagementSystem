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


namespace airline_management_system
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += textBox1_TextChanged;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 v = new Form4();
            v.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            // Replace each character with an asterisk
            //textBox.Text = new string('*', textBox.Text.Length);
            // Move the caret to the end of the text
            //textBox.SelectionStart = textBox.Text.Length;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else{
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand command1 = conn.CreateCommand();
            command1.CommandText = "Select password from passenger where username='"+textBox2.Text+"'";
            command1.CommandType = CommandType.Text;
            OracleDataReader dr = command1.ExecuteReader();
            /*dr.Read();
            String p = string.Empty;
            p = dr.GetString(0);
            MessageBox.Show("Login Successful!");
            command1.Dispose();
            conn.Close();*/
            try
            {
                String p = string.Empty;
                dr.Read();
                p = dr.GetString(0);
                if(p == textBox1.Text)
                {
                    MessageBox.Show("LOGIN SUCCESSFUL!! PRESS OK TO GO AHEAD !");
                    Form form2 = new Form2();
                    form2.Show();
                    //new form
                }
                else
                {
                    MessageBox.Show("PASSWORD INVALID!!");
                }
                command1.Dispose();
                conn.Close();
                //Form form2 = new Form2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username doesnt exist ! \nCheck your username or SignUp !");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 fm = new Form13();
            fm.Show();
        }
    }
}
