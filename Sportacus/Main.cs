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
        /// <summary>
        /// Used to store user information
        /// </summary>
        public class Student
        {
            public string firstName;
            public string lastName;
            public string username;
            public string house;
            public int yearLevel;
            public bool isStudent;
        }

        //Public Variables
        string username;
        string filePath = "users.xml";
        int studentID;
        Student[] students;

        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Reads XML file from provided file path, then writes to the students array
        /// </summary>
        /// <param name="filePath"></param>
        private void ReadXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();

            //Try open users xml file, if it doesn't work throw error
            try
            {
                doc.Load(filePath);
            }
            catch
            {
                MessageBox.Show("User XML file not found, Please contact the admin to fix the issue", "Critical Error: User XML File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            XmlNodeList xmlStudents = doc.GetElementsByTagName("user");

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
                theStudent.isStudent = Convert.ToBoolean(student["isStudent"].InnerText);
                students[i] = theStudent;
                i++;
            }
        }
        private void btnAvailableEvents_Click(object sender, EventArgs e)
        {
            //Open Event Entry Form
            EventEntryForm evf = new EventEntryForm(students[studentID]);
            evf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read XML file
            ReadXML(filePath);

            //Get username of logged in user
            username = Environment.UserName;
            studentID = FindLoggedInUser(students, username);

            //Check if student exists
            if(studentID == -1)
            {
                MessageBox.Show("Student not found, Please contact the admin to fix the issue", "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            //Display Teacher view
            if(students[studentID].isStudent == false)
            {
                btnYourEvents.Text = "Student Event List";
                btnAvailableEvents.Hide();
            }
        }

        /// <summary>
        /// Finds who the logged in user is, then finds the username in the student list
        /// </summary>
        /// <param name="students"></param>
        /// <param name="username"></param>
        /// <returns>Location of the student in the array</returns>
        private int FindLoggedInUser(Student[] students, string username)
        {
            int location = -1;
            for (int i = 0; i < students.Length; i++)
            {
                if(students[i].username == username)
                {
                    location = i;
                }
            }
            return location;
        }

        private void btnYourEvents_Click(object sender, EventArgs e)
        {
            try
            {
                //Open and Convert XML file to DataSet
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"StudentData.xml");
                DataTable data = dataSet.Tables[0];
                DataView view = data.AsDataView();

                if (students[studentID].isStudent == true)
                {
                    //Open Table View of Student Events, and give function the data to display
                    //Only display student events, filter other students out of dataset
                    view.RowFilter = $"UserName='{students[studentID].username}'";

                    Events evf = new Events(students[studentID].firstName, view, students[studentID].isStudent, students[studentID].house);
                    evf.ShowDialog();
                }
                else
                {
                    //Teacher view, includes all students in events xml
                    Events evf = new Events(students[studentID].firstName, view, students[studentID].isStudent, students[studentID].house);
                    evf.ShowDialog();
                }


            }
            catch
            {
                //If the XML file isn't found, create an error box telling the user what is wrong
                MessageBox.Show("XML file not found, please signup to an event before viewing this page", "XML file not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}