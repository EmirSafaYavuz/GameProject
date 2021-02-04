using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICustomerService
    {
        void Add(Customers customer);
        void Delete(Customers customer);
        void Update(Customers customer, Customers newCustomer);
        void GetAll();
    }
}
