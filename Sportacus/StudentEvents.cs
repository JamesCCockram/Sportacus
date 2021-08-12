using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sportacus
{
    public partial class StudentEvents : Form
    {
        public StudentEvents(string Student, DataView dataSet)
        {
            InitializeComponent();
            dataGridView1.DataSource = dataSet;
            this.dataGridView1.Columns["username"].Visible = false;
            label1.Text = Student + "'s Events";
        }

        private void StudentEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
