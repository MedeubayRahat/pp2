using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year_of_study;
        public void PrintInfo()
        {
            Console.Write(name + " " + id + " " + (year_of_study+1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student A = new Student();
            A.name = Convert.ToString(Console.ReadLine());
            A.id = Convert.ToString(Console.ReadLine());
            A.year_of_study = Convert.ToInt32(Console.ReadLine());
            A.PrintInfo();

        }
    }
}
