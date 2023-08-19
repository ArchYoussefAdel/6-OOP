using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7oopPartial_class
{
    #region task 3 (partial class)

    public partial class Myclass //part 1
    {
        private string name;
        private int age;

    }
    public partial class Myclass //part 2
    {
        public void Setn(string x)
        {
            this.name = x;
        }
        public string Getn()
        {
            return name;
        }
    }
    public partial class Myclass //part 3
    {
        public void Seta(int y)
        {
            this.age = y;
        }
        public int Geta()
        {
            return age;
        }
    }
    public class Class1
    {
        public static void Main(string[] args)
        {
            Myclass partialtest = new Myclass();
            partialtest.Setn("omar");
            partialtest.Seta(26);

            Console.WriteLine("my name is :" + partialtest.Getn());
            Console.WriteLine("my age is  :" + partialtest.Geta());

            Console.ReadLine();

        }
    }



    #endregion
}
