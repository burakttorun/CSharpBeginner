using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20);
            Console.WriteLine(result);
            Console.ReadLine();
            int number1 = 20;
            int number2;
            var result2 = Add3(ref number1, out number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(1, 2, 3));
            Console.WriteLine(Multiply(1, 2));
            Console.WriteLine(Add4(1, 2, 3, 4));
            Console.ReadLine();


        }

        static void Add()
        {
            Console.WriteLine("Added.");

        }

        static int Add2(int number1, int number2 = 20)
        {
            return number1 + number2;
        }
        /*Bu methoda gönderilen iki farklı parametre "ref" ve "out" anahtar kelimeleriyle karşılanır. 
        Bunlar referans tipi parametre göndermek için kullanılır. Aralarındaki fark "ref" başlangıç değeri tanımlamak 
        zorunda olduğun bir anahtar kelimedir."Out" için böyle bir gereklilik yoktur.*/
        static int Add3(ref int number1, out int number2)
        {
            number1 = 30;
            number2 = 5;
            return number1 + number2;
        }

        // Method Overloading basit örnek.  
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //Burada kullanılan "params" anahtar kelimesi kullanıcının istediği kadar veri girebilmesini sağlar.
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
