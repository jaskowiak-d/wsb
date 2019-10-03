using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszy_plik
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("wsb");
            Console.WriteLine("nowa linia");
            Console.Write("Podaj swoje imię: ");
            string name=Console.ReadLine();
            Console.Write("Masz na imię: ");
            Console.WriteLine(name);
            //typ int
            int age = 20;
            Console.WriteLine(age);
            //typ uint
            //typ float
            float z = 14.55F;
            //konkatenacja
            Console.WriteLine("Zmienna z wynosi: " +z);

            Console.WriteLine("Program obliczający pole prostokąta");
            Console.WriteLine("Podaj długość boku a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj długość boku b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Pole prostokąta wynosi: ");
            Console.WriteLine(a * b);
            int j, k = 10, l;
            //int zmienna = 10
            int zmienna = new int();
            Console.ReadKey();
            
        }
    }
}
