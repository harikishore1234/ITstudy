﻿using System;
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
    public partial class citywise : Form
    {
        public citywise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ittrainingEntities db = new ittrainingEntities();
            var display = (from r in db.trainingcentres
                           orderby r.city
                           select r).ToList();
            dataGridView1.DataSource = display;
        }
    }
}
