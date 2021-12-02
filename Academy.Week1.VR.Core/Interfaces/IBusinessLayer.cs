using Academy.Week1.VR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.VR.Core.Interfaces
{
    public interface IBusinessLayer
    {
        // firma del metodo che restituisce la lista di tutti i noleggi
        List<Rental> FetchAllRentals();

        // firma del metodo che restituisce la lista di tutti i veicoli
        List<Vehicle> FetchVehicles();

        // firma del metodo che restituisce le info su un veicolo conoscendo la targa
        Vehicle GetVehicleByPlate(string plate);

        // firma del metodo che resituisce la disponibilità di un veicolo al noleggio 
        // conoscendo la targa, la data di inizio del noleggio e il numero di giorni del noleggio

        bool CheckAvailability(string plate, int days, DateTime date);

        // firma del metodo che restituisce un cliente conoscendo il codice fiscale

        object GetCustomerByCF(string cf);


    }
}
