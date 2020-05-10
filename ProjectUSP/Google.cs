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
    public partial class Google : Form
    {
        public Google()
        {
            InitializeComponent();
        }

        private void Google_Load(object sender, EventArgs e)
        {
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Google' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Brand"].ToString() + " " + dr["Model"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Google'";
            if (comboBox1.Text != "RAM")
            {
                sel = sel + "AND  [RAM] = '" + comboBox1.Text + "'";
            }
            if (comboBox2.Text != "OS")
            {
                sel = sel + "AND  [OS] = '" + comboBox2.Text + "'";
            }
            if (comboBox3.Text != "Storage")
            {
                sel = sel + "AND  [Storage] = '" + comboBox3.Text + "'";
            }
            if (comboBox4.Text != "Processor")
            {
                sel = sel + "AND  [Processor] = '" + comboBox4.Text + "'";
            }
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                listBox1.Items.Clear();
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Brand"].ToString() + " " + dr["Model"].ToString());
                }
            }
            else
            {
                MessageBox.Show("There isn't a smartphone with the requested parameteres !");
            }

            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Text = "RAM";
            comboBox2.Text = "OS";
            comboBox3.Text = "Storage";
            comboBox4.Text = "Processor";
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Google' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr["Brand"].ToString() + " " + dr["Model"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }
    }
}
