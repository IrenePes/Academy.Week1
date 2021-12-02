using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Agency.LINQ
{
    public class Building
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Code { get; set; } //codice postale
        public int Mq { get; set; } //metri quadri
        public bool Available { get; set; } //vero se ancora disponibile, falso se non lo è

    }
}
