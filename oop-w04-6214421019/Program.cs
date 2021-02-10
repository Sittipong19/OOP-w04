using System;

namespace oop-6214421017-w04
{
    class Program
    {
        static void Main(string[] args)
        {
        /* Student s06 = new Student("6214421017", "Rungrat", "Sriwirun");
         Console.WriteLine(s06.ToString());
        Console.WriteLine("_____________________________________________________________");
         Room s01 = new Room("433", "Computer Lab", 8, 8);
         Console.WriteLine(s01.ToString());
        Console.WriteLine("_____________________________________________________________");
         Building s05 = new Building("04","Faculty of Computer Science and Information Technology","13.7442","100.4608");
         Console.WriteLine(s05.ToString());
        Console.WriteLine("_____________________________________________________________");
         Subject s02 = new Subject("9022081", "Web Programming", 3, 2, 2);
         Console.WriteLine(s02.ToString());
        Console.WriteLine("_____________________________________________________________");
         Lecture s03 = new Lecture("Nitat", "Ninchawee", "Master of Science (Electronic Transactions)");
         Console.WriteLine(s03.ToString());
        Console.WriteLine("_____________________________________________________________");
         Curriculum s04 = new Curriculum("Information Technology", "Bachelor");
         Console.WriteLine(s04.ToString());*/
        Lecture k01 = new Lecture("Nitat", " Ninchawee ");
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine(k01.subjectTeacher()+k01.createSubject("Object Oriented Programming", "9022081").teach());
            Console.WriteLine("_____________________________________________________________");
            Student k02 = new Student("6214421021", "Anocha", "Prungtaeng");
            Console.WriteLine(k02.studentcurri());
            Console.WriteLine("_____________________________________________________________");
            Subject k03 = new Subject("9022081",new Building("04"));
            Console.WriteLine(k03.ToString());
            Console.WriteLine("_____________________________________________________________");
            Subject k04 = new Subject("9022081", new Room("433"));
            Console.WriteLine(k04.Getroom());
            Console.WriteLine("_____________________________________________________________");
        }
    }
}
