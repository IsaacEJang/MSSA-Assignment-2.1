using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._1
{
    internal class Student
    {
        private int studentid;
        public int StudentId
        {
            get { return studentid; }
            set { studentid = value; }
        }

        private string studentfname;
        public string StudentFName
        {
            get { return studentfname; }
            set { studentfname = value; }
        }
        

        private string studentlname;
        public string StudentLName
        {
            get{ return studentlname;}
            set { studentlname = value; }

        }

        private char studentgrade;
        public char StudentGrade
        {
            get { return studentgrade;}
            set { studentgrade = value; }
        }

    }
}
