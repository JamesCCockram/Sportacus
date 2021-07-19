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
        public StudentEvents(Main.Student Student, DataSet dataSet)
        {
            InitializeComponent();
            dataGridView1.DataSource = dataSet.Tables[0];
            label1.Text = Student.firstName + "'s Events";
        }
    }
}
