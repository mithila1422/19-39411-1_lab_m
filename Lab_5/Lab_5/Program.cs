
namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student ("Methela", "193411",3.5f );
            Student s1 = new Student("Meth", "193412", 3.55f);
            Student s2 = new Student("Mim", "193413", 3.61f);

            Department d = new Department("Computer Science", "CS");
            Department d1 = new Department("Electrical Engineering", "EEE");
            s.Dept = d;
            d.AddStudent(s);
            d.AddStudent(s1);
            s1.Dept = d;
            s2.Dept = d1;
            d.AddStudent(s2);

            s.ShowDdepartmentDetails();
            s2.ShowDdepartmentDetails();
            Console. Writeline("*****");
            d.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
                 s1.ShowDdepartmentDetails();
             Console.WriteLine("*****");
            d.PrintStudent();
        }
    }
}
