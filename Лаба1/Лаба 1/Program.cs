using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Adress> adresik = new List<Adress>();
            string city;
            string street;
            int dom;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите город: ");
                city = Console.ReadLine();
                Console.Write("Введите улицу: ");
                street = (Console.ReadLine());
                Console.Write("Введите номер дома: ");
                dom = int.Parse(Console.ReadLine());
                adresik.Add(new Adress(city, street, dom));
                Console.WriteLine("-------------------------------------------------: ");
            }

            Console.WriteLine("Вывод списка");
            foreach (Adress a in adresik)
            {
                Console.WriteLine("Город: " + a.city);
                Console.WriteLine("Улица: " + a.street);
                Console.WriteLine("Номер дома: " + a.dom);
                Console.WriteLine("=======");

            }

            Console.ReadLine();

        }
    }
}
