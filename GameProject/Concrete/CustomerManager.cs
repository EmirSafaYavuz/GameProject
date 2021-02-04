using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CustomerManager : ICustomerService
    {
        public List<Customers> _customerList;

        public CustomerManager()
        {
            _customerList = new List<Customers>()
            {
                new Customers {Id = 1, FirstName = "Emir Safa", LastName = "Yavuz" , BirthYear = "2002", TCno= "123", Active = true},
                new Customers {Id = 2, FirstName = "Oktay", LastName = "Korkut" , BirthYear = "2002", TCno= "456", Active = true},
                new Customers {Id = 3, FirstName = "Fatih", LastName = "Kürekçi" , BirthYear = "2002", TCno= "789", Active = true},
                new Customers {Id = 4, FirstName = "Berkay", LastName = "Aydemir" , BirthYear = "2002", TCno= "789", Active = true}
            };
        }

        public void Add(Customers customer)
        {
            CustomerVerificationManager verification = new CustomerVerificationManager();

            Console.WriteLine("Müşteri Ekleniyor...");

            if (verification.CustomerControl(customer))
            {
                _customerList.Add(customer);
                Console.WriteLine("-----------------");
                Console.WriteLine("Müşteri Eklendi");
            }
            else
            {
                Console.WriteLine("Bir Hata Meydana Geldi!");
            }
        }

        public void Delete(Customers customer)
        {
            Console.WriteLine("Müşteri Siliniyor...");
            customer.Active = false;
            Console.WriteLine("Müşteri Silindi");
        }

        public void GetAll()
        {
            foreach (var customer in _customerList)
            {
                Console.WriteLine("--------Müşteriler---------");
                if (customer.Active)
                {  
                    Console.WriteLine("Müşteri Id: "+customer.Id);
                    Console.WriteLine("Müşteri Adı: "+ customer.FirstName + " " + customer.LastName);
                    Console.WriteLine("-----------------");
                }
                Console.WriteLine("-----------------");
            }
        }

        public void Update(Customers customer, Customers newCustomer)
        {
            CustomerVerificationManager verification = new CustomerVerificationManager();

            Console.WriteLine("Müşteri Güncelleniyor...");

            if (verification.CustomerControl(newCustomer))
            {
                customer.FirstName = newCustomer.FirstName;
                customer.LastName = newCustomer.LastName;
                Console.WriteLine("Müşteri Güncellendi");
            }
            else
            {
                Console.WriteLine("Bir Hata Meydana Geldi!");
            }
        }
    }
}
