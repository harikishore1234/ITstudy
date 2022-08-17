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
    public partial class Deleteinfo : Form
    {
        public Deleteinfo()
        {
            InitializeComponent();
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
                trainingcentre ob = new trainingcentre();
                ob.studentid = Sid;
                ob.studentname = Sname;
                ob.course = Course;
                ob.durationofcourse = dcourse;
                ob.fee = fees;
                ob.batchname = bname;
                ob.sex = Sex;
                ob.enrollmentno = eno;
                ob.city = City;
                var result = (from r in db.trainingcentres
                              where r.studentid == Sid
                              select r).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("Record not Found");
                else
                {
                    db.trainingcentres.Remove(result);
                    int totalRows = db.SaveChanges();
                    if (totalRows > 0)
                        MessageBox.Show("Deletion Sucessfull");
                    else
                        MessageBox.Show("Failed, Try Again");
                }
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }
    }
}
