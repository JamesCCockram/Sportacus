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
    public partial class Events : Form
    {
        public Events(string Student, DataView dataSet, bool isStudent, string House)
        {
            InitializeComponent();
            dataGridView1.DataSource = dataSet;

            //Hide Username Column
            dataGridView1.Columns["username"].Visible = false;

            //Rename Columns
            dataGridView1.Columns["firstname"].HeaderText = "First Name";
            dataGridView1.Columns["lastname"].HeaderText = "Last Name";
            dataGridView1.Columns["house"].HeaderText = "House";
            dataGridView1.Columns["yearLevel"].HeaderText = "Year Level";
            dataGridView1.Columns["eventName"].HeaderText = "Event Name";
            dataGridView1.Columns["heat"].HeaderText = "Heat";

            //Student View
            if (isStudent == true)
            {
                dataGridView1.Columns["firstName"].Visible = false;
                dataGridView1.Columns["lastName"].Visible = false;
                dataGridView1.Columns["house"].Visible = false;
                dataGridView1.Columns["yearLevel"].Visible = false;

                //Create a personalized label
                label1.Text = $"{Student}'s Events";
            }

            //Teacher View
            else
            {
                label1.Text = $"All Events for {House}";
            }

        }

        private void StudentEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
