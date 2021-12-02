using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Core.Interfaces
{
    public interface ICustomersRepository : IRepository<Customer>
    {
        Rental FetchRentalById(int id);
        object GetCustomerByCF(string cf);
    }
}
