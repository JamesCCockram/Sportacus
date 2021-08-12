using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Sportacus
{
    public partial class EventEntryForm : Form
    {
        /// <summary>
        /// Used to store events
        /// </summary>
        public class Event
        {
            public string eventName;
            public string heat;
            public int yearLevel;
        }

        //Public Variables
        Event[] events;
        Main.Student student;
        string filePath = "events.xml";

        /// <summary>
        /// Take the button name, then find it in the events array. Once the event is found in the array the button linked to the event, then prompting the event selection form
        /// </summary>
        /// <param name="targetEvent"></param>
        private void ButtonHandler(string targetEvent)
        {
            int location = -1;
            for (int i = 0; i < events.Length; i++)
            {
                if (events[i].eventName == targetEvent)
                {
                    location = i;
                }
            }
            try
            {
                EventSelection view = new EventSelection(student, events[location]);
                view.ShowDialog();
            }
            catch
            {
                MessageBox.Show("XML File not found", "XML file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reads XML file from provided file path, then writes to the events array
        /// </summary>
        /// <param name="filePath"></param>
        private void ReadXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList xmlEvents = doc.GetElementsByTagName("event1");

            //set array size
            events = new Event[xmlEvents.Count];
            //iterate through array
            int i = 0;
            foreach(XmlNode event1 in xmlEvents)
            {
                Event theEvent = new Event();

                theEvent.eventName = event1["eventName"].InnerText;
                //theEvent.heat = event1["heat"].InnerText;
                theEvent.yearLevel = Convert.ToInt32(event1["eventYearLevel"].InnerText);
                events[i] = theEvent;
                i++;
            }
        }

        public EventEntryForm(Main.Student studentDetails)
        {
            InitializeComponent();

            student = studentDetails;
        }

        private void EventEntryForm_Load(object sender, EventArgs e)
        {
            //Read XML file as program opens
            ReadXML(filePath);
        }

        //Link buttons using ButtonHandler()
        private void btn100m_Click(object sender, EventArgs e)
        {
            ButtonHandler(btn100m.Text);
        }

        private void btn200m_Click(object sender, EventArgs e)
        {
            ButtonHandler(btn200m.Text);
        }

        private void btn500m_Click(object sender, EventArgs e)
        {
            ButtonHandler(btn500m.Text);
        }

        private void btn1000m_Click(object sender, EventArgs e)
        {
            ButtonHandler(btn1000m.Text);
        }

        private void btnTripleJump_Click(object sender, EventArgs e)
        {
            ButtonHandler(btnTripleJump.Text);
        }

        private void btnLongJump_Click(object sender, EventArgs e)
        {
            ButtonHandler(btnLongJump.Text);
        }

        private void btnHighJump_Click(object sender, EventArgs e)
        {
            ButtonHandler(btnHighJump.Text);
        }

        private void btnShotPut_Click(object sender, EventArgs e)
        {
            ButtonHandler(btnShotPut.Text);
        }

        private void btnDiscus_Click(object sender, EventArgs e)
        {
            ButtonHandler(btnDiscus.Text);
        }
    }
}
