using Academy.Week1.VR.Core.BusinessLayers;
using Academy.Week1.VR.Core.Models;
using Academy.Week1.VR.Mock.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Client
{
    public class Menu
    {
        //private static readonly AgencyBusinessLayer mainBL = new AgencyBusinessLayer(new MockBuildingsRepository());

        private static readonly VRBusinessLayer mainBL = new Core.BusinessLayers.VRBusinessLayer(new MockRentalsRepository(), new MockCustomersRepository(), new MockVehiclesRepository());

        //private static readonly VRBusinessLayer mainBL = new VRBusinessLayer(new EFRentalsRepository(), new EFCustomersRepository(), new EFVehiclesRepository());
        
        internal static void Start()
        {
            Console.WriteLine("Benvenuto!");

            char choice;

            do
            {
                Console.WriteLine("Scegli [1] per visualizzare tutti i noleggi, con i dati del veicolo e del cliente.\n" + 
                    "Scegli [2] per visualizzare i noleggi di un certo veicolo.\n" + 
                    "Scegli [3] per visualizzare i dettagli di un certo noleggio.\n" +
                    "Scegli [4] per visualizzare i noleggi attivi.\n" + 
                    "Scegli [5] per inserire un nuovo noleggio.\n" + 
                    "Scegli [6] per calcolare il totale in euro dei noleggi.\n" + 
                    "Scegli [7] per ricavare il totale in euro dei noleggi di automobili.\n" +
                    "Scegli [Q] per uscire.");

                choice = Console.ReadKey().KeyChar;

                Console.WriteLine();

                switch(choice)
                {
                    case '1':
                        FetchAllRentals();
                        break;
                    case '2':
                        FetchVehicleRentals();
                        break;
                    case '3' :
                        FetchRentalsDetails();
                        break;
                    case '4':
                        FetchActiveRentals();
                        break;
                    case '5':
                        AddNewRental();
                        break;
                    case '6':
                        TotalProfitRentals();
                        break;
                    case '7':
                        TotalProfitCarRentals();
                        break;
                    case 'Q':
                        Console.WriteLine("Arrivederci.");
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }


            } while (choice != 'Q');
        }

        private static void TotalProfitCarRentals()
        {
            throw new NotImplementedException();
        }

        private static void TotalProfitRentals()
        {
            throw new NotImplementedException();
        }

        private static void AddNewRental() // aggiungere un nuovo noleggio 
        {
            string plate;
            Vehicle vehicle;

            // voglio mostrare tutti i possibili veicoli da noleggiare

            Console.WriteLine("Quale veicolo si vuole noleggiare?");

            List<Vehicle> vehicles = mainBL.FetchVehicles();

            foreach (var v in vehicles)

                Console.WriteLine(v);

            do
            {
                plate = GetData("targa del veicolo che si vuole noleggiare.");
                vehicle = mainBL.GetVehicleByPlate(plate);

                if (vehicle == null)
                    Console.WriteLine("Targa inserita non corretta. Riprovare.");

             } while (vehicle == null);

            int days;
            DateTime date;

            Console.WriteLine("Inserire la data di inizio noleggio.");

            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Inserire un formato corretto di data.");
            }

            do
            {
                Console.WriteLine("Inserire il numero di giorni che si vuole noleggiare il veicolo.");

            } while (!int.TryParse(Console.ReadLine(), out days) || days <= 0);

            bool available = mainBL.CheckAvailability(plate, days, date);

            if (available)
            {
                string cf = GetData("codice fiscale del cliente:");

                var customer = mainBL.GetCustomerByCF(cf);

                if(customer != null)
                {
                    decimal cost = vehicle.DailyCost * days;
                    Console.WriteLine($"Il costo del noleggio è {cost} euro.");

                    Rental rental = new Rental()
                    {
                        PlateVehicle = plate,
                        CFCustomer = cf,
                        TotCost = cost,
                        Date = date,
                        DayNumbers = days

                    };

                }
            
            }

        }


        private static string GetData(string v)
        {
            string text;
            do
            {
                Console.WriteLine("Inserire " + v);
                text = Console.ReadLine();
            } while(string.IsNullOrWhiteSpace(text));

            return text;
        }

        private static void FetchActiveRentals()
        {
            throw new NotImplementedException();
        }

        private static void FetchVehicleRentals() // visualizzare i noleggi di un certo veicolo
        {
            // voglio ricevere in input la targa di un veicolo

            string plate;

            Console.WriteLine("Inserire la targa del veicolo desiderato.");
            plate = Console.ReadLine();

            

        }

        private static void FetchRentalsDetails() // visualizzare i dettagli di un certo noleggio
        {
            // voglio ricevere in input il codice id del noleggio 

            int id;
            bool parse;

            do
            {
                Console.WriteLine("Inserire il codice ID del noleggio desiderato.");
                parse = int.TryParse(Console.ReadLine(), out id);
            }
            while (!parse);



            Rental rent = mainBL.FetchRentalById(id);

            Console.WriteLine(rent.ToString());
        }

        private static void FetchAllRentals()
        {
            List<Rental> rentals = mainBL.FetchAllRentals();
        }

    }
}
