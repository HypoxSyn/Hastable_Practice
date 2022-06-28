using System.Collections;

Hashtable studentsTable = new Hashtable();

Student stud1 = new Student(1, 21, "Frank");
Student stud2 = new Student(2, 21, "Abby");
Student stud3 = new Student(3, 21, "Maria");
Student stud4 = new Student(4, 21, "Tom");
Student stud5 = new Student(5, 21, "Bobby");
Student stud6 = new Student(6, 21, "Pearl");


Student storedStudent = (Student)studentsTable[stud1.ID]!;



foreach(DictionaryEntry entry in studentsTable)
{
    Student temp = (Student)entry.Value!;

    if (temp != null)
    {
        Console.WriteLine($"Student ID {temp.ID} | Age: {temp.Age} | Name: {temp.Name}");
    }
    else
    {
        Console.WriteLine("Value is null");
    }
}

Console.WriteLine($"Student ID {stud1.ID} | Age: {stud1.Age} | Name: {stud1.Name}");
Console.Read();




class Student
{
    public int ID { get; set; }
    public int Age { get; set; }
    public string Name { get; set; }


    public Student(int id, int age, string name)
    {
        this.ID = id;
        this.Age = age;
        this.Name = name;
    }

    public Student()
    {
        this.ID = 0;
        this.Age = 0;
        this.Name = "Default";
    }

}