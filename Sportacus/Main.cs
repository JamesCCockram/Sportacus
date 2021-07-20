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
    public partial class Main : Form
    {
        public class Student
        {
            public string firstName;
            public string lastName;
            public string username;
            public string house;
            public int yearLevel;
        }

        //Public Variables
        string username;
        string filePath = "students.xml";
        Student[] students;

        public Main()
        {
            InitializeComponent();
        }
        private void ReadXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList xmlStudents = doc.GetElementsByTagName("student");

            //Set array size
            students = new Student[xmlStudents.Count];

            //Iterate through array
            int i = 0;
            foreach(XmlNode student in xmlStudents)
            {
                Student theStudent = new Student();

                theStudent.username = student["username"].InnerText;
                theStudent.firstName = student["firstName"].InnerText;
                theStudent.lastName = student["lastName"].InnerText;
                theStudent.house = student["house"].InnerText;
                theStudent.yearLevel = Convert.ToInt32(student["yearLevel"].InnerText);
                students[i] = theStudent;
                i++;
            }
        }
        private void btnAvailableEvents_Click(object sender, EventArgs e)
        {
            EventEntryForm evf = new EventEntryForm(students[1]);
            evf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get username of logged in user
            username = Environment.UserName;

            //Read XML file
            ReadXML(filePath);

        }

        private void btnYourEvents_Click(object sender, EventArgs e)
        {
            try
            {
                //Open and Convert XML file to DataSet
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"StudentData.xml");

                //Open Table View of Student Events, and give function the data to display
                StudentEvents evf = new StudentEvents(students[1].firstName, dataSet);
                evf.ShowDialog();
            }
            catch
            {
                //If the XML file isn't found, create an error box telling the user what is wrong
                MessageBox.Show("XML File not Found", "XML File not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
