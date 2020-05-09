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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelSubMenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AddPhone());
           /* string connectionString;
            OleDbConnection cnn;
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb";
            cnn = new OleDbConnection(connectionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            openChildForm(new LG());
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'LG' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                
            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            openChildForm(new Samsung());
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Samsung' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            openChildForm(new Apple());
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Apple' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            openChildForm(new Google());
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Apple' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {

            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            openChildForm(new Huawei());
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Huawei' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {

            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            openChildForm(new Sony());
            OleDbConnection cnn;
            cnn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\DatabaseUSP\\Database3.mdb");
            cnn.Open();
            string sel = "SELECT * FROM Phones WHERE [Brand] = 'Sony' ";
            OleDbCommand com = new OleDbCommand(sel, cnn);
            OleDbDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {

            }
            else
            {
                MessageBox.Show("Error");
            }

            cnn.Close();
        }
    }
}
