using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUSP
{
    public partial class AddPhone : Form
    {
        public AddPhone()
        {
            InitializeComponent();
        }

        private void AddPhone_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int success = 0;
            OleDbConnection cnn;

            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string strn = "SELECT * FROM Phones WHERE [Model] = '" + textBox1.Text + "'";
            OleDbCommand comd = new OleDbCommand(strn, cnn);
            OleDbDataReader datr = comd.ExecuteReader();
            if (datr.Read())
            {
                errorProvider1.SetError(textBox1, "This model is already in the database!");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                success++;
                
            }
            if (success == 1)
            {
                try
                {
                    string str = " INSERT into Phones([Brand],[Model],[Display],[Processor],[RAM],[Storage],[Battery],[OS],[Resolution],[Release Date]) VALUES('" + comboBox1.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + comboBox6.Text.ToString() + "','" + comboBox7.Text.ToString() + "','" + comboBox5.Text.ToString() + "','" + comboBox3.Text.ToString() + "','" + comboBox8.Text.ToString() + "','" + comboBox4.Text.ToString() + "','" + comboBox2.Text.ToString() + "','" + dateTimePicker1.Text.ToString() + "'); ";

                    OleDbCommand cmd = new OleDbCommand(str, cnn);
                    cmd.ExecuteNonQuery();
                    string str1 = "select max(ID) from Phones;";

                    OleDbCommand cmd1 = new OleDbCommand(str1, cnn);
                    OleDbDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("The smartphone is in the collection");
                    }
                }
                catch (OleDbException excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Brand";
            comboBox2.Text = "Resolution";
            comboBox3.Text = "Storage";
            comboBox4.Text = "OS";
            comboBox5.Text = "RAM";
            comboBox6.Text = "Display";
            comboBox7.Text = "Processor";
            comboBox8.Text = "Battery";
            textBox1.Text = "";
            dateTimePicker1.ResetText();
        }
    }
}
