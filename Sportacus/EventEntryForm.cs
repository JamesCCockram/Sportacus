﻿using System;
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
        class Event
        {
            public string eventName;
            public string heat;
            public int yearLevel;
        }

        Event[] events;

        string filePath = "events.xml";
        private int year;

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
                theEvent.heat = event1["heat"].InnerText;
                theEvent.yearLevel = Convert.ToInt32(event1["eventYearLevel"].InnerText);
                events[i] = theEvent;
                i++;
            }
        }

        public EventEntryForm(int year, string name)
        {
            this.year = year;
            InitializeComponent();
        }

        private void EventEntryForm_Load(object sender, EventArgs e)
        {
            ReadXML(filePath);
            lblTrack.Text = events[1].eventName;
        }

        private void btn100m_Click(object sender, EventArgs e)
        {
            EventSelection view = new EventSelection();
            view.ShowDialog();
        }

        private void btn200m_Click(object sender, EventArgs e)
        {
            EventSelection view = new EventSelection();
            view.ShowDialog();
        }
    }
}
