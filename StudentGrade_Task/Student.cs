using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrade_Task
{
    internal class Student
    {
        private Grade[]grades;

        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public Grade[] Grades { get => grades; }

        public Student(string name,string surName, int age)
        {
            Name = name;
            SurName = surName;
            grades = new Grade[0];
            Age = age;

        }
        public void AddGrade(Grade grade)
        {
            int index=Array.IndexOf(grades,grade);
                if (index==-1)
                {
                    Array.Resize(ref grades, grades.Length + 1);
                    grades[grades.Length - 1] = grade;
                }
                else
                {
                    Console.WriteLine($"cannot add because {grade.Subject}  added");
                   Console.WriteLine("--------------------------------------");

                }



        }
        public void GetAllGrades()
        {
            foreach (var item in grades)
            {
                item.GetDetails();
            }
        }
    }
}
