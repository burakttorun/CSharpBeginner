using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            long number1 = 2000000001256315325;  // sınırı -> 19 basamak (9223372036854775807/-9223372036854775808)  [64 bit]
            int number2 = 10;                  // sınırı  -> 10 basamak (2147483647/-2147483648)                    [32 bit]
            short number3 = 20153;              // sınırı   -> 5 basamak  (32768 /- 32768)                            [16 bit]
            byte number4 = 0;                 // sınırı    -> 3 basamak  (0 / 255)                                   [8 bit]
            double number5 = 10.4;             // [64 bit] (ondaliklı sayılar için , virgülden sonra 15-16 karakter tutabilir.)
            decimal number6 = 10.4M;          //  [128 bit] (ondaliklı sayılar için , virgülden sonra 28-29 karakter tutabilir.  )
            bool condition = false;         //   [1 bit]
            char character = 'A';          //    [16 bit] 
            var number7 = 10;              //   atanan tipi alır.
            var number8 = 'A';            // başta tipi int olduğu  için ascıı kodunu yazar.


            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine("Character is : {0}", (int)character); //ASCII
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday, Thursday, Friday, Saturday, Sunday

    }
}
  