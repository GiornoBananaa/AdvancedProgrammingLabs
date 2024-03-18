using Microsoft.VisualBasic.FileIO;

List<Student> students = new List<Student>();

using (TextFieldParser textFieldParser = new TextFieldParser(@"C:/Users/Student/Downloads/eeerrr.csv"))
{
    textFieldParser.TextFieldType = FieldType.Delimited;
    textFieldParser.SetDelimiters(";");
    textFieldParser.ReadFields();
    while (!textFieldParser.EndOfData)
    {
        string[] rows = textFieldParser.ReadFields();

        Student student = new Student();
        
        student.Name = rows[0];
        student.Group = rows[1];
        student.Mark = int.Parse(rows[2]);
        student.Subject = rows[3];
        
        students.Add(student);
    }
}
// Задание 1
var studentsArseniy = from s in students 
    where s.Name == "Arseniy" 
    select s;

foreach (var student in studentsArseniy)
{
    Console.WriteLine(student);
}

// Задание 2
students.OrderBy(s=>s.Group);

string group = "";
foreach (var student in students)
{
    if (group != student.Group)
    {
        group = student.Group;
        Console.WriteLine($"В группе {group} учатся студенты:");
    }
    Console.WriteLine(student);
}

// Задание 3

var subjectOrder1 = students.Where(s=>);
var subjectOrder = from s in students 
    orderby s.Group
    select s;


class Student
{
    public string Name;
    public string Group;
    public int Mark;
    public string Subject;

    public override string ToString()
    {
        return $"{Name} {Group} {Mark} {Subject}";
    }
}