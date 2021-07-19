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
        public StudentEvents()
        {
            InitializeComponent();
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"StudentData.xml");
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
