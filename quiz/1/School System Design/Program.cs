using System;
using System.Collections.Generic;

// Common interface for both students and teachers
interface IPerson
{
    int Id { get; set; }
    string Name { get; set; }
    string Gender { get; set; }
}

// Class to represent a teacher
class Teacher : IPerson
{
    private static int lastAssignedId = 99;
    public Teacher()
    {
        Id = ++lastAssignedId;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Subject { get; set; }

}

// Class to represent a student
class Student : IPerson
{
    private static int lastAssignedId = 99;
    public Student()
    {
        Id = ++lastAssignedId;
    }
    public List<Teacher> Teachers { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Subject { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Teacher> teachers = new List<Teacher>();
        List<Student> students = new List<Student>();

        Console.Write("Enter the number of teachers: ");
        int numTeachers = int.Parse(Console.ReadLine());

        // Fill teacher data
        Console.WriteLine("\nEnter teacher data:");
        for (int i = 0; i < numTeachers; i++)
        {
            Console.WriteLine($"\nTeacher {i + 1}:");
            Console.Write("Name: ");
            string teacherName = Console.ReadLine();
            Console.Write("Gender (male/female): ");
            string teacherGender = Console.ReadLine();
            Console.Write("Subject assigned (math, arabic, science, english): ");
            string teacherSubject = Console.ReadLine();

            // Create a new teacher instance
            Teacher teacher = new Teacher
            {
                Name = teacherName,
                Gender = teacherGender,
                Subject = teacherSubject
            };

            // Add teacher to the list
            teachers.Add(teacher);
        }

        Console.Write("\nEnter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Fill student data
        Console.WriteLine("\nEnter student data:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.Write("Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Gender (male/female): ");
            string studentGender = Console.ReadLine();
            Console.Write("Subject (math, arabic, science, english): ");
            string studentSubject = Console.ReadLine();

            // Create a new student instance
            Student student = new Student
            {
                Name = studentName,
                Gender = studentGender,
                Subject = studentSubject,
                Teachers = new List<Teacher>()
            };

            // Find matching teacher for the student's subject
            Teacher matchingTeacher = null;

            for (int x = 0; x < teachers.Count; x++)
            {
                if (teachers[x].Subject == studentSubject)
                {
                    matchingTeacher = teachers[x];
                    break;
                }
            }

            if (matchingTeacher != null)
            {
                student.Teachers.Add(matchingTeacher);
            }

            // Add student to the list
            students.Add(student);
        }

        Console.Write("\nEnter the name of the student to search: ");
        string searchName = Console.ReadLine();

        bool found = false;

        foreach (var s in students)
        {
            if (s.Name == searchName)
            {
                Console.WriteLine("\nStudent data:");
                Console.WriteLine("ID: " + s.Id);
                Console.WriteLine("Name: " + s.Name);
                Console.WriteLine("Subject: " + s.Subject);
                Console.WriteLine("Teachers:");
                foreach (var t in s.Teachers)
                {
                    Console.WriteLine("- " + t.Name);
                }
                Console.WriteLine();

                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("\nStudent not found.");
        }

        Console.ReadLine();
    }
}