using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421019-w04
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private int subjectUnit;
        private int subjectLecture;
        private int subjectLab;
        private Building building;
        private Room room;
        public Subject() { }
        public Subject(string n,string c)
        {
            this.subjectName = n;
            this.subjectCode = c;
        }
        public Subject(string c,Room r)
        {
            this.subjectCode = c;
            this.room = r;
        }
        public void setRoom(Room r)
        {
            this.room = r;
        }
        public Room getRoom()
        {
            return this.room;
        }
        public Subject(string c,Building b)
        {
            this.subjectCode = c;
            this.building = b;
        }
        public Subject(string c) { this.subjectCode = c; }
        public Subject(string c,string n,int u,int le,int la)
        {
            this.subjectCode = c;
            this.subjectName = n;
            this.subjectUnit = u;
            this.subjectLecture = le;
            this.subjectLab = la;
        }
        public void setBuilding(Building b)
        {
            this.building = b;
        }
        public Building getBuilding()
        {
            return this.building;
        }
        public string parameterBuilding(Building b)
        {
            return b.detail();
        }
        public string Getroom()
        {
            return "Subject code: " + this.subjectCode + " teaches at Room code: " + this.room.Getroom();
        }
        
        public string teach()
        {
            return " subject code: " + this.subjectCode
         + " that mean subject name: " + this.subjectName;
        }
        public override string ToString()
        {
            // return "Subject Code: "+this.subjectCode+"\t Subject Name: "+this.subjectName+"\t Subject Unit: "+this.subjectUnit+"\nSubject Lecture Time: "+this.subjectLecture+" hour\tSubject Lab Time: "+this.subjectLab+" hour.";
            return "Subject Code: " + this.subjectCode + " teaches " + parameterBuilding(this.building);
        }
    }
}
