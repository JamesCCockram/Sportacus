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
    public partial class Form1 : Form
    {
        public class Student
        {
            public string firstName;
            public string lastName;
            public string username;
            public string house;
            public int yearLevel;
        }

        //open studentXML file
        string filePath = "students.xml";

        Student[] students;

        public Form1()
        {
            InitializeComponent();
        }
        private void ReadXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList xmlStudents = doc.GetElementsByTagName("student");

            //set array size
            students = new Student[xmlStudents.Count];
            //iterate through array
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
            //this.Hide();
            EventEntryForm evf = new EventEntryForm(students[1]);
            evf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get logged in user
            string username = Environment.UserName;

            ReadXML(filePath);

        }
    }
}
