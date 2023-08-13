

//using System;

//public interface IImmovable
//{
//    void Move();
//    void Stop();
//    void Type();
//}

//public class Human : IImmovable
//{
//    public void Move()
//    {
//        Console.WriteLine("Human can move with legs.");
//    }

//    public void Stop()
//    {
//        Console.WriteLine("Human is stopped.");
//    }

//    public void Type()
//    {
//        Console.WriteLine("Type: Human");
//    }
//}

//public class Bird : IImmovable
//{
//    public void Move()
//    {
//        Console.WriteLine("Bird can move with wings.");
//    }

//    public void Stop()
//    {
//        Console.WriteLine("Bird is stopped.");
//    }

//    public void Type()
//    {
//        Console.WriteLine("Type: Bird");
//    }
//}

//public class Car : IImmovable
//{
//    public void Move()
//    {
//        Console.WriteLine("Car can move with petrol.");
//    }

//    public void Stop()
//    {
//        Console.WriteLine("Car is stopped.");
//    }

//    public void Type()
//    {
//        Console.WriteLine("Type: Car");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Human human = new Human();
//        human.Move();
//        human.Stop();
//        human.Type();

//        Bird bird = new Bird();
//        bird.Move();
//        bird.Stop();
//        bird.Type();

//        Car car = new Car();
//        car.Move();
//        car.Stop();
//        car.Type();
//    }
//}





using System;

public class Student
{
    private string name;
    private int age;
    private string school;

    public string Name
    {
        set { name = value; }
        get { return name; }
    }
    public int Age
    {
        set { age = value; }
        get { return age; }
    }
    public string School
    {
        set { school = value; }
        get { return school; }
    }

    public Student(string name, int age) : this(name, age, "Unknown")
    {
    }

    public Student(string name, string school) : this(name, 0, school)
    {
    }

    public Student(string name, int age, string school)
    {
        Name = name;
        Age = age;
        School = school;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, School: {School}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("samy", 20);
        student1.PrintInfo();

        Student student2 = new Student("mohamed", 22, "zzz School");
        student2.PrintInfo();

        Student student3 = new Student("menna", "GGG School");
        student3.PrintInfo();
    }
}






