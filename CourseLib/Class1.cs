using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseLib
{
    public class CourseLibClass
    {
        static public List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();

        public class Course
        {
            // the generic SortedList class uses a template <> to store indexed data
            // the first type is the data type to index on
            // the second type is the data type to store in the list
            // create a Sorted List indexed on email (string) and storing Person objects
            public SortedList<string, Course> sortedList = new SortedList<string, Course>();

            public virtual void Remove(string courseCode)
            {
                if (courseCode != null)
                {
                    sortedList.Remove(courseCode);
                }
            }

            // indexer property allows array access to sortedList via the class object
            // and catching missing keys and duplicate key exceptions 
            // notice the indexer property definition shows how it will be used in the calling code:
            // if we have:
            //     People people;
            // then we can call:
            //     people[email] to access the Person object with that email address
            // and value will be the Person object (person) being added to the list in the case of:
            //     people[email] = person;
            public virtual Course this[string courseCode]
            {
                get
                {
                    Course returnVal;
                    try
                    {
                        returnVal = (Course)sortedList[courseCode];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    try
                    {
                        // we can add to the list using these 2 methods
                        //      sortedList.Add(email, value);
                        sortedList[courseCode] = value;
                    }
                    catch
                    {
                        // an exception will be raised if an entry with a duplicate key is added
                        // duplicate key handling (currently ignoring any exceptions)
                    }
                }
            }
        }
    }
}
