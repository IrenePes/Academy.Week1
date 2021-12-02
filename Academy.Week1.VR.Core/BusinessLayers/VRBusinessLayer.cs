using Academy.Week1.VR.Core.Interfaces;
using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Core.BusinessLayers
{
    public class VRBusinessLayer: IBusinessLayer
    {
        private readonly IRentalsRepository _rentalsRepository;
        private readonly IVehiclesRepository _vehiclesRepository;
        private readonly ICustomersRepository _customersRepository;
        private object mockRentalsRepo;

        public VRBusinessLayer(IRentalsRepository rentalsRepo, ICustomersRepository customersRepo, IVehiclesRepository vehiclesRepo)
        {
            _rentalsRepository = rentalsRepo;
            _vehiclesRepository = vehiclesRepo;
            _customersRepository = customersRepo;
        }

        public List<Rental> FetchAllRentals()
        {
            return _rentalsRepository.FetchAll();
        }

        public Rental FetchRentalById(int id)
        {
            return _rentalsRepository.FetchRentalById(id);
        }

        public List<Vehicle> FetchVehicles()
        {
            return _vehiclesRepository.FetchAll();
        }

        public Vehicle GetVehicleByPlate(string plate)
        {
            if (string.IsNullOrEmpty(plate))
                return null;
            else
                return _vehiclesRepository.GetByPlate(plate);
        }

        public bool CheckAvailability(string plate, int days, DateTime startDate)
        {
            return _rentalsRepository.CheckAvailability(plate, days, startDate);
        }

        public object GetCustomerByCF(string cf)
        {
            if (string.IsNullOrEmpty(cf))
                return null;
            else
                return _customersRepository.GetCustomerByCF(cf);
        }

    }
}
