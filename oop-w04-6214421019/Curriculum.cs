using System;
using System.Collections.Generic;
using System.Text;

namespace oop-6214421017-w04
{
    class Curriculum
    {
        private string curriculumName;
        private string curriculumDegree;
        public Curriculum() { }
        public Curriculum(string cn,string cd)
        {
            this.curriculumName = cn;
            this.curriculumDegree = cd;
        }
        public override string ToString()
        {
            return "Majoring: "+this.curriculumName+"\t Degree: "+this.curriculumDegree;
        }
    }
}
