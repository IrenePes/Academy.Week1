using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Mock.Repositories
{
    public class InMemoryStorageCustomers
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>()
        {
            new Customer()
            {
                Name = "Mario",
                Surname = "Rossi",
                CF = "RSSMRA76A01L219J"
            },
            new Customer()
            {
                Name = "Marco",
                Surname = "Rossi",
                CF = "RSSMRC80A01L219M"
            }
        };
    }
}
