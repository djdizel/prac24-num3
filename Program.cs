using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac24._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект с именем kadry,конструктор без параметров
            Kadry kadry = new Kadry();
            Console.WriteLine(kadry.ToString());
            //объект с именем kadry2,конструктор c параметрами
            Kadry kadry2 = new Kadry("Крикун", 70, "Лейтенант", 46);
            Console.WriteLine(kadry2.ToString());
            //конструктор с parse
            Console.WriteLine("Введите фамилию");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите должность");
            string dol = Console.ReadLine();
            Console.WriteLine("Введите стаж");
            int staj = int.Parse(Console.ReadLine());
            Kadry kadry3 = new Kadry(fam, age, dol, staj);
            Console.WriteLine($"{kadry3.ToString()}\n");
            Console.ReadLine();
        }
    }
}
