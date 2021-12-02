using Academy.Week1.VR.Core.Interfaces;
using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Mock.Repositories
{
    public class MockVehiclesRepository : IVehiclesRepository
    {
        public bool Add(Vehicle item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Vehicle item)
        {
            throw new NotImplementedException();
        }

        public List<Vehicle> FetchAll()
        {
            return inMemoryStorageVehicles.Vehicles;
        }

        public Vehicle GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Vehicle GetByPlate(string plate)
        {
            List<Vehicle> vehicles = FetchAll();

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Plate == plate)
                    return vehicle;
            }

            return null;
        }

        public bool Update(Vehicle item)
        {
            throw new NotImplementedException();
        }
    }
}
