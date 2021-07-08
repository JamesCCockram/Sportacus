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
    public partial class EventSelection : Form
    {

        public EventSelection(Form1.Student studentDetails, EventEntryForm.Event eventDetails)
        {
            InitializeComponent();
            lblEventName.Text = eventDetails.eventName;
        }

        private void EventSelection_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {

        }
    }
}
