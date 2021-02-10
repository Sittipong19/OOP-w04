using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w04
{
    class Lecture
    {
        private string lectureFistName;
        private string lectureLastName;
        private string lecturePosition;
        private Subject subject;
        public Lecture(string f,string l,string p)
        {
            this.lectureFistName = f;
            this.lectureLastName = l;
            this.lecturePosition = p;
        }
        public Lecture() { }
        public Lecture(string f,string l ,Subject sj)
        {
            this.lectureFistName = f;
            this.lectureLastName = l;
            this.subject = sj;
        }
        public Lecture(string f,string l)
        {
            this.lectureFistName = f;
            this.lectureLastName = l;
        }
        public void setSubject(Subject sj)
        {
            this.subject = sj;
        }
        public Subject getSubject()
        {
            return this.subject;
        }
        public Subject createSubject(string n,string c)
        {
            return new Subject(n, c);
        }
        public string subjectTeacher()
        {
            return "Teacher " + this.lectureFistName + " " + this.lectureLastName + " teaches";
        }
        public override string ToString()
        {
            return "Teacher: "+this.lectureFistName+" "+this.lectureLastName+"\t Position: "+this.lecturePosition;
        }
    }
}
