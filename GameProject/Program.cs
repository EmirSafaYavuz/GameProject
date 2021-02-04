using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {

        static void Main(string[] args)
        {
            //Customers customer = new Customers();
            //CustomerManager customerManager = new CustomerManager();

            //Console.WriteLine("Müşteri Adı: ");
            //customer.FirstName = Console.ReadLine();
            //Console.WriteLine("Müşteri Soyadı: ");
            //customer.LastName = Console.ReadLine();
            //Console.WriteLine("Müşteri TC: ");
            //customer.TCno = Console.ReadLine();
            //customer.Id = 1;
            //customer.Active = true;

            //customerManager.Add(customer);

            //customerManager.GetAll();

            ProgramControl control = new ProgramControl();
            control.First();
            Console.ReadLine();


        }
    }
}
