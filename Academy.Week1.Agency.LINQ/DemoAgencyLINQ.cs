using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Agency.LINQ
{
    public class DemoAgencyLINQ
    {
        public static void Demo()
        {
            List<Building> buildings = new List<Building>();

            Box box = new Box()
            {
                Id = 1,
                Address = "Via Roma, 11",
                City = "Milano",
                Code = 12345,
                Available = true,
                Mq = 80,
                ParkingSpaces = 3
            };

            Flat flat = new Flat()
            {
                Id = 2,
                Address = "Via dei girasoli, 10",
                City = "Milano",
                Code = 12345,
                Available = true,
                Mq = 85,
                BathRooms = 1,
                Rooms = 3
            };

            Villa villa = new Villa()
            {
                Id = 3,
                Address = "Via degli Achei, 27",
                City = "Milano",
                Code = 12345,
                Available = true,
                Mq = 120,
                BathRooms = 2,
                Rooms = 5,
                GardenMq = 50
            };

            Villa villa2 = new Villa()
            {
                Id = 4,
                Address = "Via degli Achei, 28",
                City = "Milano",
                Code = 12345,
                Available = false,
                Mq = 100,
                BathRooms = 2,
                Rooms = 4,
                GardenMq = 50
            };

            buildings.Add(villa);
            buildings.Add(villa2);  
            buildings.Add(box);
            buildings.Add(flat);

            // Si vuole visualizzare tutti gli immobili per indirizzo

            Console.WriteLine("Elenco di tutti gli indirizzi degli immobili:");

            var addresses = buildings.Select(build => build.Address);

            foreach(var address in addresses)
                Console.WriteLine(address);

            // Si vuole visualizzare tutti gli immobili con una superficie maggiore di 90

            Console.WriteLine("Elenco degli indirizzi degli immobili con superficie superiore o uguale a 90mq:");

            var buildingsBiggerThan = buildings.Where(build => build.Mq >= 90);

            foreach(var building in buildingsBiggerThan)
                Console.WriteLine(building.Address);

            // Si vuole visualizzare gli indirizzi degli immobili disponibili all'acquisto/affitto

            Console.WriteLine("Elenco degli indirizzi degli immobili disponibili all'acquisto/affitto:");

            var buildingsAvailable = buildings.Where(build => build.Available);

            foreach(var building in buildingsAvailable)
                Console.WriteLine(building.Address);


            // Si vuole visualizzare il tipo di immobili (villa, appartamento, box)


            
        }
    }
}
