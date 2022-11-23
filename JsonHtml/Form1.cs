using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PeopleAppGlobals;
using PeopleLib;
using System.IO;
using System.Net;

namespace JsonHtml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Globals.AddCoursesSampleData();

            List<Teacher> teachers = new List<Teacher>();
            List<Student> students = new List<Student>();

            foreach(KeyValuePair<string,Person> keyValuePair in Globals.people.sortedList)
            {
                if(keyValuePair.Value.GetType() == typeof(Teacher))
                {
                    teachers.Add((Teacher)keyValuePair.Value);
                }
                else
                {
                    students.Add((Student)keyValuePair.Value);
                }
            }

            string s = JsonConvert.SerializeObject(students);
            string t = JsonConvert.SerializeObject(teachers);

            StreamWriter writers = new StreamWriter("c:/temp/students.json");
            writers.Write(s);
            writers.Close();

            StreamWriter writert = new StreamWriter("c:/temp/teachers.json");
            writert.Write(t);
            writert.Close();

            StreamReader readers = new StreamReader("c:/temp/students.json");
            s = readers.ReadToEnd();
            readers.Close();

            StreamReader readert = new StreamReader("c:/temp/teachers.json");
            t = readert.ReadToEnd();
            readert.Close();

            students = JsonConvert.DeserializeObject<List<Student>>(s);

            teachers = JsonConvert.DeserializeObject<List<Teacher>>(t);

            SortedList<string, Person> people = new SortedList<string, Person>();

            foreach(Student student in students)
            {
                people[student.email] = student;
            }

            foreach (Teacher teacher in teachers)
            {
                people[teacher.email] = teacher;
            }

            string url = "http://people.rit.edu/dxsigm/json.php";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            readers = new StreamReader(response.GetResponseStream());
            t = readers.ReadToEnd();
            readers.Close();
            response.Close();

            teachers = JsonConvert.DeserializeObject<List<Teacher>>(t);
        }
    }
}
