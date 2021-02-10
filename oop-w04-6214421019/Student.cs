using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w04
{
    class Student
    {
        private string studentFirstName;
        private string studentLastName;
        private string studentId;
        private Curriculum curriculum;
        public Student() { }
      
        public string localCurriculum()
        {
            Curriculum c = new Curriculum("IT", "Bachelor of CSIT");
            return c.ToString();
        }
        public Student(string id,string f,string l)
        {
            this.studentId = id;
            this.studentFirstName = f;
            this.studentLastName = l;
        }
        public string studentcurri()
        {
            return "student id: "+this.studentId+" Student Name: " + this.studentFirstName + " " + this.studentLastName + " is studying at " + this.localCurriculum();
        }
        public override string ToString()
        {
            return "StudentID Card: "+this.studentId+"\tStudent Name: "+this.studentFirstName+" "+this.studentLastName;
        }
    }
}
