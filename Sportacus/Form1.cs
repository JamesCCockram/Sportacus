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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvailableEvents_Click(object sender, EventArgs e)
        {
            //this.Hide();
            EventEntryForm evf = new EventEntryForm();
            evf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get logged in user
            string username = Environment.UserName;

            //open studentXML file

        }
    }
}
