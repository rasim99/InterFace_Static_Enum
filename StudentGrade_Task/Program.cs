namespace StudentGrade_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grade grade = new Grade("Math",Degree.B);
            Grade grade2= new Grade("Geography",Degree.A);
            Grade grade3 = new Grade("Informatica",Degree.C);
            Student student = new Student("Lorem", "Ipsum", 25);
            student.AddGrade(grade);
            student.AddGrade(grade2);
            student.AddGrade(grade3);
            student.AddGrade(grade3);
            student.GetAllGrades();
        }
    }
}
