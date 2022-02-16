using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Fakhri","Afandiyev","P127",90,true);
            Console.WriteLine(student.Fullname());
            Console.WriteLine(student.Allinfo());

            if (student.isGraduated)
            {
                Console.WriteLine("This student has graduated");
            }
            else
            {
                Console.WriteLine("This student hasn't graduated");
            }

            PossibleRetake(student.Point);
        }
        public static void PossibleRetake(int point)
        {
            if (point > 80)
            {
                Console.WriteLine("Your point is " + point + ". You can retake the exam");
            }
            else
            {
                Console.WriteLine("Your point is " + point + ". You cannot retake the exam");
            }
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool isGraduated;

        public Student(string name, string surname, string group, int point, bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = isgraduated;
        }
        public string Fullname()
        {
            return Name + " " + Surname;
        }
        public string Allinfo()
        {
            return $"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\nisGraduated: {isGraduated}";
        }        
    }
}
