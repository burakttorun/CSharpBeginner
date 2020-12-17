using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            //Nesne oluşturulmasına örnek.
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.FirstName = "Burak";
            customer.LastName = "Torun";
            customer.Id = 1;

            Customer customer2 = new Customer { Id = 2, FirstName = "Ömer", LastName = "Kafkas", City = "Ankara" };
            Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }

    
}
