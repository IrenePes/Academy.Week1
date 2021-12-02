using Academy.Week1.VR.Core.Interfaces;
using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Mock.Repositories
{
    public class MockRentalsRepository : IRentalsRepository
    {
        public bool Add(Rental item)
        {
            throw new NotImplementedException();
        }

        public bool CheckAvailability(string plate, int days, DateTime startDate)
        {
            List<Rental> rentals = FetchAll();

            DateTime endDate = startDate.AddDays(days);

            foreach (Rental item in rentals)
            {
                DateTime storedEndDate = item.Date.AddDays(item.DayNumbers);
                if (item.PlateVehicle == plate && storedEndDate > startDate && endDate < item.Date)
                {
                    return false; //ovvero non disponibile
                }
            }
            return true; // ovvero disponibile
        }

        public bool Delete(Rental item)
        {
            throw new NotImplementedException();
        }

        public List<Rental> FetchAll()
        {
            return InMemoryStorageRentals.Rentals;

        }

        public Rental FetchRentalById(int id)
        {
            List<Rental> rentals = InMemoryStorageRentals.Rentals;

            foreach(Rental rental in rentals)
            {
                if(rental.ID == id)
                    return rental;
            }
            return null;
           
        }

        public Rental GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Rental item)
        {
            throw new NotImplementedException();
        }
    }
}
