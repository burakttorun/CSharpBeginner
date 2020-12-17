using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();
            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This number is a prime number.");
            }
            else Console.WriteLine("This number is not a prime number.");
            Console.ReadLine();
        }


        //parametre olarak gönderilen değerin asal olup olmadığının kontrolünü yapan metot.
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }

            }
            return result;
        }
        private static void ForeachLoop()
        {
            string[] students = new string[] { "Engin", "Derin", "Salih" };

            //foreach dizide yer alan her bir elemanı teker teker dolaşan bir döngüdür.
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            // Döngünün başında herhangi bir kontrol yapmadan işlem yapılır daha sonra şart kontrol edilir.
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 10;

        //parantez içerisinde yer alan koşul sağlandığı ve döngü bilerek kırılmadığı taktirde sonsuza kadar devam edebilen bir döngü çeşitidir.
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("number is now {0}", number);
        }

        private static void ForLoop()
        {
            // 3 parçaya ayrılmış bir döngü olup bunlar sırayla: değer atanması, koşul belirtilmesi ve değer değişimidir.
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
