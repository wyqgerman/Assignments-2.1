namespace Assignments_2._1
{
    class Student
{
    private int studentId;
    private string studentFname;
    private string studentLname;
    private char studentGrade;

    public int StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    public string StudentFname
    {
        get { return studentFname; }
        set { studentFname = value; }
    }

    public string StudentLname
    {
        get { return studentLname; }
        set { studentLname = value; }
    }

    public char StudentGrade
    {
        get { return studentGrade; }
        set { studentGrade = value; }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.StudentId = 1;
            student.StudentFname = "John";
            student.StudentLname = "Smith";
            student.StudentGrade = 'A';

            Console.WriteLine("Student Information:");
            Console.WriteLine("ID: " + student.StudentId);
            Console.WriteLine("First Name: " + student.StudentFname);
            Console.WriteLine("Last Name: " + student.StudentLname);
            Console.WriteLine("Grade: " + student.StudentGrade);

        }
    }
}
