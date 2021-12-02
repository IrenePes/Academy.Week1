using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Agency.LINQ
{
    public class Flat : Building
    {
        //estende immobile.
        //ha anche: 

        public int Rooms { get; set; } //- numero di vani
        public int BathRooms { get; set; } //- numero di bagni
    }
}
