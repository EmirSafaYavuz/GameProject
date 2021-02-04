using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerVerificationManager : ICustomerVerificationService
    {
        public bool CustomerControl(Customers customer)
        {
            return true;
        }
    }
}
