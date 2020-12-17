using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringIntro();
            StringMethods();
            Console.ReadLine();

        }

        private static void StringMethods()
        {
            string sentence = "My name is Burak Torun";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is İlber Ortaylı";

            
            bool result3 = sentence.EndsWith("n");//Bu metot cümlenin parantez içerisinde verilen parametreyle bitip bitmediğini kontrol eder.
            bool result4 = sentence.StartsWith("My name");//Bu metot cümlenin parantez içerisinde verilen parametre ile mi başladığını kontrol eder.

            var result5 = sentence.IndexOf("name");//Bu metot cümlede parantez içerisinde verilen parametrenin varlığını kontrol eder ve index değerini döndürür.
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");//Bu metot cümleye tersten başlayarak parantez içerisinde verilen parametrenin varlığını kontrol eder ve index değerini döndürür.
            var result8 = sentence.Insert(0, "Hello, ");//Bu metot cümleye belirtilen indexten itibaren başlayarak parantez içerisindeki parametreyi ekler.
            var result9 = sentence.Substring(3, 4);//Bu metot belirtilen indexten başlayıp, belirtildiği kadar karakteri seçip geri döndürür.
            var result10 = sentence.ToLower();//Bu metot cümledeki bütün karakterleri küçük harfe dönüştürür.
            var result11 = sentence.ToUpper();//Bu metot cümledeki bütün karakterleri büyük harfe dönüştürür.
            var result12 = sentence.Replace("m", "o");//Bu metot cümledeki bütün "m" karakterlerinin yerine "o" karakteri yerleştirir.
            var result13 = sentence.Remove(2, 5);//Bu metot cümlede belirtilmiş indexten itibaren belirtilen karakter kadar siler.

            Console.WriteLine(result5);
        }

        private static void StringIntro()
        {
            string city = "Ankara";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;

            // Console.WriteLine(result);
            Console.WriteLine(city + city2);
            Console.WriteLine("{0} {1}", city, city2);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
