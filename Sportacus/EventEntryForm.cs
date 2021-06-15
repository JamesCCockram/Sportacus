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
    public partial class EventEntryForm : Form
    {
        private int year;
        public EventEntryForm(int year, string name)
        {
            this.year = year;
            InitializeComponent();
        }
    }
}
