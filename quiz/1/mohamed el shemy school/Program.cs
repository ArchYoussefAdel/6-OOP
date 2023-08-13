using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum Supject
{
    math = 1,
    Arabic = 2,
    Science = 3,
    English = 4

}
enum Gender
{
    male = 1,
    female = 2
}
abstract class Human
{
    public static int id = 0;
    public string Name { get; set; }
    public Gender Gen { get; set; }
    public Supject Sup { get; set; }

    public Human() { id++; }
    public Human(string name, Gender gender, Supject suppp)
    {
        id++;
        this.Name = name;
        Gen = gender;
        Sup = suppp;
    }
    public virtual void Print() { }


}
internal class Stydent : Human
{
    public Stydent() { }
    public Stydent(string name, Gender gender, Supject suppp)
    {

        this.Name = name;
        Gen = gender;
        Sup = suppp;
    }

    public static void Filldataa(Stydent[] b, Teacher[] sc)
    {
        int[] aff = new int[b.Length];
        for (int i = 0; i < b.Length; i++)
        {

            Console.WriteLine($"please enter name for stydent :{i + 1}");
            string s = Console.ReadLine();
            b[i].Name = s;

            Console.WriteLine("enter teacher no that he assinee to him");
            int sfw = int.Parse(Console.ReadLine());

            switch (sfw)
            {
                case 1:
                    Console.WriteLine($"assigne to {sc[i].Name}");
                    string result1 = Console.ReadLine();
                    if (result1 == "no")
                    {
                        Console.WriteLine($"assigne to {sc[i + 1].Name}");

                    }
                    string result2 = Console.ReadLine();
                    if (result2 == "no")
                    {
                        Console.WriteLine($"assigne to {sc[i + 2].Name}");
                    }
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine($"assigne to {sc[i + 1].Name}");
                    string result11 = Console.ReadLine();
                    if (result11 == "no")
                    {
                        Console.WriteLine($"assigne to {sc[i].Name}");
                    }
                    string result22 = Console.ReadLine();
                    if (result22 == "no")
                    {
                        Console.WriteLine($"assigne to {sc[i + 2].Name}");
                    }
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine($"assigne to {sc[i + 2].Name}");
                    string result111 = Console.ReadLine();
                    if (result111 == "no")
                    {
                        Console.WriteLine($"assigne to {sc[i].Name}");
                    }
                    string result2222 = Console.ReadLine();
                    if (result2222 == "no")
                    {
                        Console.WriteLine($"assigne to {sc[i + 1].Name}");
                    }
                    Console.Clear();
                    break;

            }
            if (i == 3)
            {
                break;
            }


        }


    }


    public static void Print(Stydent[] cz)
    {
        for (int i = 0; i < cz.Length; i++)
        {
            Console.WriteLine(cz[i].Name);
            Console.WriteLine(cz[i].Gen);
            Console.WriteLine(cz[i].Sup);
        }
    }
}
internal class Teacher : Human
{
    public Teacher() { }
    public Teacher(string name, Gender gender, Supject suppp)
    {
        id++;
        this.Name = name;
        Gen = gender;
        Sup = suppp;
    }
    public static void Filldata(Teacher[] c)
    {


        for (int i = 0; i < c.Length; i++)
        {
            Console.WriteLine($"plaese enter teacher name no{i + 1}");
            c[i].Name = Console.ReadLine();

            Console.WriteLine("plaese enter gender male/female ");

            bool aa = false;
            do
            {
                Gender teatcher_gender;
                if (Enum.TryParse(Console.ReadLine(), out teatcher_gender))
                {
                    string th_gen = teatcher_gender.ToString();
                    aa = true;
                }
                else
                {
                    Console.WriteLine("invalid gender input");
                    aa = false;
                }
                c[1].Gen = teatcher_gender;

            } while (!aa);


            Console.WriteLine("please enter suoject assien/math/ Arabic/ Science/ English ");

            Supject sT_sup;
            bool a = false;
            do
            {
                if (Enum.TryParse(Console.ReadLine(), out sT_sup))
                {
                    string st_supj = sT_sup.ToString();
                    a = true;
                }
                else
                {
                    Console.WriteLine("invalid supject input");
                    a = false;
                }

                c[1].Sup = sT_sup;

            } while (!a);
            Console.Clear();
        }


        Console.Clear();

    }

    public static void Print(Teacher[] cz)
    {

        for (int i = 0; i < cz.Length; i++)
        {
            Console.WriteLine(cz[i].Name);
            Console.WriteLine(cz[i].Gen);
            Console.WriteLine(cz[i].Sup);
        }



    }
}
class Enterypoint
{
    static void Main()
    {

        Teacher c = new Teacher();
        Teacher v = new Teacher();
        Teacher x = new Teacher();

        Teacher[] arr = { c, v, x };

        Stydent a = new Stydent();
        Stydent z = new Stydent();
        Stydent q = new Stydent();

        Stydent[] st = { a, z, q };

        Teacher.Filldata(arr);
        Stydent.Filldataa(st, arr);

        Teacher.Print(arr);
        Stydent.Print(st);

        Console.ReadLine();
    }
}
