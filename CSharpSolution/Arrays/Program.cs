using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir string dizisi oluşturmak için kullanılan yöntem-1.
            string[] students = new string[4];
            students[0] = "Burak";
            students[1] = "Oğuzhan";
            students[2] = "Börü";

            // bir string dizisi oluşturmak için kullanılan yöntem-2.
            string[] students2 = { "ben", "sen", "o" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            // İki boyutlu string dizisi oluşturmak için kullanılan yöntem.
            string[,] regions = new string[5, 3]
            {
                { "İstanbul","izmir","balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Samsun","Trabzon","Rize"},
                { "İzmir","Muğla","Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("-------------------------------");
            }

            Console.ReadLine();
        }
    }
}
