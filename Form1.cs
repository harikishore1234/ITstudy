using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITstudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ittrainingEntities db = new ittrainingEntities();
            string User_id = textBox1.Text;
            string password = textBox2.Text;
            if (User_id == "hari"&& password == "kishore")
            {
                menuStrip1.Visible = true;
                MessageBox.Show("login sucess!", "sucess", MessageBoxButtons.OK);
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                textBox1.Visible= false;
                textBox2.Visible= false;
                label1.Visible=false;
                label2.Visible=false;
            }
            else
            {
                MessageBox.Show("invalis username or password", "Failed", MessageBoxButtons.OK);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible=false;
            button2.Visible=false;
            button3.Visible=false;
            button4.Visible=false;
            button5.Visible=false;
            button6.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible=true;
            MessageBox.Show("log out sucess");
            Form1 ob=new Form1();   
            ob.ShowDialog();

        }

        private void currentAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Current_admission ob = new Current_admission();
            ob.Show();
        }

        private void updateinfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updateinfo ob = new Updateinfo();
            ob.Show();
        }

        private void deleteinfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleteinfo ob = new Deleteinfo();
            ob.Show();
        }

        private void viewinfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewinfo ob = new viewinfo();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            batchwise ob = new batchwise();
            ob.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            coursewise ob = new coursewise();
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            citywise ob = new citywise();
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            revenue revenue = new revenue();
            revenue.Show();
        }
    }
}
