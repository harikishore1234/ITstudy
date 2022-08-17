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
    public partial class viewinfo : Form
    {
        public viewinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void viewinfo_Load(object sender, EventArgs e)
        {
            try
            {
                ittrainingEntities db = new ittrainingEntities();
                var result = db.trainingcentres.ToList();
                dataGridView1.DataSource = result;
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }
    }
}
