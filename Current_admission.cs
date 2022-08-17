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
    public partial class Current_admission : Form
    {
        public Current_admission()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ittrainingEntities db = new ittrainingEntities();
                int Sid = Convert.ToInt32(textBox1.Text);
                string Sname = textBox2.Text;
                string Course = textBox3.Text;
                string dcourse = textBox4.Text;
                int fees = Convert.ToInt32(textBox5.Text);
                string bname = textBox6.Text;
                string Sex = textBox7.Text; 
                int eno = Convert.ToInt32(textBox8.Text);   
                string City = textBox9.Text;
               trainingcentre ob=new trainingcentre();
                ob.studentid = Sid;
                ob.studentname = Sname;
                ob.course = Course;
                ob.durationofcourse = dcourse;
                ob.fee = fees;
                ob.batchname = bname;
                ob.sex = Sex;
                ob.enrollmentno= eno;
                ob.city = City;
                db.trainingcentres.Add(ob);
                int totalRows = db.SaveChanges();
                if (totalRows > 0)
                    MessageBox.Show("Data Saved");
                else
                    MessageBox.Show("Failed, Try Again");
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }
        }
    }
}
