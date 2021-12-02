using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Core.Interfaces
{
    public interface IRentalsRepository : IRepository<Rental>
    {
        Rental FetchRentalById(int id);
        bool CheckAvailability(string plate, int days, DateTime startDate);
    }
}
