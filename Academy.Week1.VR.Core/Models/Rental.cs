using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Core.Models
{
        public class Rental
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int DayNumbers { get; set; }
        public decimal TotCost { get; set; }
        public string CFCustomer { get; set; }
        public string PlateVehicle { get; set; }
    }
}
