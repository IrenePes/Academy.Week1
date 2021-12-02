using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Mock.Repositories
{
    public class inMemoryStorageVehicles
    {
        public static List<Vehicle> Vehicles { get; set; } = new List<Vehicle>()
        {
            new Car()
            {
                Plate = "AX743HJ",
                Model = "Fiat Panda",
                DailyCost = 55,
                Seats = 4
            },

            new Car()
            {
                Plate = "GJ924LR",
                Model = "Fiat Punto",
                DailyCost = 60,
                Seats = 5
            },

            new Car()
            {
                Plate = "UY248QW",
                Model = "Fiat Tipo",
                DailyCost = 65,
                Seats = 5
            },

            new Car()
            {
                Plate = "GK823NB",
                Model = "Smart fortwo coupe'",
                DailyCost = 70,
                Seats = 2
            },

            new Van()
            {
                Plate = "TY467WE",
                Model = "Fiat Ducato",
                DailyCost = 125,
                CapKg = 750
            },

            new Van()
            {
                Plate = "GH567KU",
                Model = "Fiat Ducato",
                DailyCost = 100,
                CapKg = 450
            }

        };
    }
}
