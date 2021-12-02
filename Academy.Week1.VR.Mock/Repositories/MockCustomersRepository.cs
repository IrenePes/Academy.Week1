using Academy.Week1.VR.Core.Interfaces;
using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Mock.Repositories
{
    public class MockCustomersRepository : ICustomersRepository
    {
        public bool Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Customer item)
        {
            throw new NotImplementedException();
        }

        public List<Customer> FetchAll()
        {
            return InMemoryStorageCustomers.Customers;
        }

        public Rental FetchRentalById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public object GetCustomerByCF(string cf)
        {
            List<Customer> customers = FetchAll();

            foreach(Customer customer in customers)

                if (customer.CF == cf)
                    return customer;
            return null;
        }

        public bool Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
