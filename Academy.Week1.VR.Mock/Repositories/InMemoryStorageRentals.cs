using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Mock.Repositories
{
    public class InMemoryStorageRentals
    {
        public static List<Rental> Rentals { get; set; } = new List<Rental>()
        { new Rental()
            {
                ID = 1,
                PlateVehicle = "AX743HJ",
                CFCustomer = "RSSMRA76A01L219J",
                Date = new DateTime(2021,11,29),
                DayNumbers = 5,
                TotCost = 275
            },
            new Rental()
            {
                ID = 2,
                PlateVehicle = "GJ924LR",
                CFCustomer ="RSSMRA76A01L219J",
                Date = new DateTime(2021,12,3),
                DayNumbers = 2,
                TotCost = 120
            },
            new Rental()
            {
                ID = 3,
                PlateVehicle = "UY248QW",
                CFCustomer = "RSSMRA76A01L219J",
                Date = new DateTime(2020,6,7),
                DayNumbers = 1,
                TotCost = 65
            },
            new Rental()
            {
                ID = 4,
                PlateVehicle = "AX743HJ",
                CFCustomer = "RSSMRA80A01L219M",
                Date = new DateTime(2021,10,10),
                DayNumbers = 1,
                TotCost = 70
            },
            new Rental()
            {
                ID = 5,
                PlateVehicle = "TY467WE",
                CFCustomer = "RSSMRA80A01L219M",
                Date = new DateTime(2021,12,29),
                DayNumbers = 5,
                TotCost = 625
            },
            new Rental()
            {
                ID = 6,
                PlateVehicle = "GH567KU",
                CFCustomer = "RSSMRA80A01L219M",
                Date = new DateTime(2020,4,19),
                DayNumbers = 3,
                TotCost = 600
            }
        };


    }
}
