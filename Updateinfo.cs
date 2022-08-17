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
    public partial class Updateinfo : Form
    {
        public Updateinfo()
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
                var result = (from r in db.trainingcentres
                              where r.studentid == Sid
                              select r).FirstOrDefault();
                if (result == null)
                    MessageBox.Show("Record not Found");
                else
                {
                    result.studentname = Sname;
                    result.course= Course;
                    result.durationofcourse = dcourse;
                    result.fee = fees;
                    result.batchname = bname;
                    result.sex= Sex;
                    result.enrollmentno= eno;
                    result.city= City;
                    int totalRows = db.SaveChanges();
                    if (totalRows > 0)
                        MessageBox.Show("Updation Sucessfull");
                    else
                        MessageBox.Show("Failed, Try Again");
                }
            }
            catch (Exception U)
            {
                MessageBox.Show(U.Message);
            }
        }
    }
}
