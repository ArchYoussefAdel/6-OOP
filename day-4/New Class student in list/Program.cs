using System;
using System.Collections.Generic;

class Student
{
    private int[] grades;
    public Student()
    {
        grades = new int[10];
    }
    public string Name { get; set; }

    public int this[int subject]
    {
        get
        {
            if (subject >= 1 && subject <= 10)
                return grades[subject - 1];

            return 0;
        }
        set
        {
            if (subject >= 1 && subject <= 10)
                grades[subject - 1] = value;
        }
    }
    public int Total()
    {
        int total = 0;
        foreach (var grade in grades)
        {
            total += grade;
        }
        return total;
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.Write($"Enter the name of student {i + 1}: ");
            string name = Console.ReadLine();

            Student student = new Student();
            student.Name = name;

            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"Enter the grade for subject {j} for {name}: ");
                int grade = int.Parse(Console.ReadLine());
                student[j] = grade;
            }
            students.Add(student);
        }
        Console.WriteLine("\n--- Student Details ---");
        foreach (var student in students)
        {
            Console.WriteLine($"Total marks for {student.Name}: {student.Total()}");
        }
    }
}