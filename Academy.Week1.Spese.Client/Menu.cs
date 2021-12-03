using Academy.Week1.Spese.Core.BusinessLayer;
using Academy.Week1.Spese.Core.Interfaces;
using Academy.Week1.Spese.Core.Models;
using Academy.Week1.Spese.Mock.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Client
{
    public class Menu
    {
        private static readonly IBusinessLayer mainBL = new SpeseBusinessLayer(new MockSpeseRepository(), new MockCategorieRepository(), new MockUtentiRepository());
        public static void Start()
        {
            Console.WriteLine("Benvenuto!");

            char choice;

            do
            {
                Console.WriteLine("Premere il tasto [1] per aggiungere una nuova spesa.\n" + 
                    "Premere il tasto [2] per approvare una spesa.\n" + 
                    "Premere il tasto [3] per visualizzare l'elenco delle spese approvate nel mese precedente.\n" +
                    "Premere il tasto [4] per visualizzare l'elenco delle spese di un utente.\n" +
                    "Premere il tasto [5] per visualizzare il totale delle spese di una categoria nel mese precedente.\n" +
                    "Premere il tasto [6] per visualizzare le spese registrate dalla più recente alla meno recente.\n" +
                    "Premere il tasto [Q] per uscire.");

                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        AddNewSpesa();
                        break;
                    case '2':
                        ApproveSpesa();
                        break;
                    case '3':
                        FetchApprovedSpeseLastMonth();
                        break;
                    case '4':
                        FetchSpeseByUtente();
                        break;
                    case '5':
                        FetchSpeseByCategoriaLastMonth();
                        break;
                    case '6':
                        SorteSpeseByDate();
                        break;
                    case 'Q':
                        Console.WriteLine("Arrivederci!");
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile. Riprovare.");
                        break;
                }
            } while(choice != 'Q'); 


        }

        public static void SorteSpeseByDate()
        {
            List<Spesa> sortedSpese = (List<Spesa>)mainBL.SortSpeseByDate();
            foreach (var spese in sortedSpese)
                Console.WriteLine($"Spesa ID: {spese.Id}\n" +
                    $"Data della spesa: {spese.Date}\n" +
                    $"Descrizione: {spese.Description}\n" +
                    $"Importo: {spese.Amount}\n" +
                    $"Stato approvato: {spese.Approved}\n" +
                    $"Codice ID della categoria: {spese.CategoriaId}\n" +
                    $"Codice ID dell'utente che ha effettuato la spesa: {spese.UtenteId}\n");

            Console.WriteLine();
        }

        public static void FetchSpeseByCategoriaLastMonth()
        {
            Console.WriteLine("\nInserire il codice ID della categoria di cui si vuole conoscere il totale delle spese effettuate nel mese precedente:");

            var categorieId = InMemoryStorage.Categorie.Select(c => c.Id).ToList();
            var categorieName = InMemoryStorage.Categorie.Select(c => c.Name).ToList();
            for (int i = 0; i < categorieId.Count; i++)
                Console.WriteLine($"ID:{categorieId[i]} => Categoria: {categorieName[i]}");

            int category;

            do
            {
                category = GetNumber2("il codice ID desiderato");

            } while (!mainBL.GetCategoriaById(category));

            decimal tot = mainBL.ComputeTotalAmountLastMonthByCategory(category);
        }

        public static void FetchSpeseByUtente()
        {
            Console.WriteLine("\nInserire il codice ID dell'utente di cui si vogliono visualizzare le spese:");

            var utenteId = InMemoryStorage.Utenti.Select(u => u.Id).ToList();
            var utenteName = InMemoryStorage.Utenti.Select(u => u.Name).ToList();
            var utenteLastName = InMemoryStorage.Utenti.Select(u => u.LastName).ToList(); //TODO

            for (int i = 0; i < utenteId.Count; i++)
                Console.WriteLine($"ID:{utenteId[i]} => Nome utente: {utenteName[i]} {utenteLastName[i]}");

            int utente;

            do
            {
                utente = GetNumber2("il codice ID desiderato");

            } while (!mainBL.GetUtenteById(utente));

            List<Spesa> outgoings = (List<Spesa>)mainBL.FetchSpeseByUtente(utente);

            if (outgoings == null)
                Console.WriteLine($"L'utente con ID={utente} non ha effettuato alcuna spesa.");
            else
                foreach (Spesa outgoing in outgoings)
                    Console.WriteLine($"L'utente con ID={utente} ha effettuato la spesa con ID={outgoing.Id}, in data {outgoing.Date}, con descrizione {outgoing.Description}, \ncon stato approvato={outgoing.Approved}, appartenente alla categoria {outgoing.CategoriaId}.");

            Console.WriteLine();
        }

        public static void FetchApprovedSpeseLastMonth()
        {
            IEnumerable<Spesa> speseApprovedLastMonth = mainBL.FetchApprovedSpeseLastMonth();

            foreach (var outgoing in speseApprovedLastMonth)
                Console.WriteLine($"Spesa ID: {outgoing.Id}\n" +
                    $"Data della spesa: {outgoing.Date}\n" +
                    $"Descrizione: {outgoing.Description}\n" +
                    $"Importo: {outgoing.Amount}\n" +
                    $"Stato approvato: {outgoing.Approved}\n" +
                    $"Codice ID della categoria: {outgoing.CategoriaId}\n" +
                    $"Codice ID dell'utente che ha effettuato la spesa: {outgoing.UtenteId}\n");
        }

        public static void ApproveSpesa()
        {
            Console.WriteLine("\nInserire il codice ID della spesa da approvare:");

            var speseNonApproved = mainBL.FetchSpeseNonApproved();

            foreach (var spese in speseNonApproved)
                Console.WriteLine($"ID: {spese.Id}");

            int spesaId;

            do
            {
                spesaId = GetNumber2("codice ID desiderato");

            } while (!mainBL.GetSpesaById(spesaId));


            bool isApproved = mainBL.ApproveSpesa(spesaId);

            if (isApproved)
                Console.WriteLine("Spesa approvata correttamente.");
            else
                Console.WriteLine("Ops... qualcosa è andato storto.");

            Console.WriteLine();
        }

        public static void AddNewSpesa()
        {
            Spesa newSpesa = new Spesa();

            DateTime date = DateTime.Today;

            string description = GetText("la descrizione della nuova spesa");

            decimal amount = GetNumber("l'importo della nuova spesa");

            Console.WriteLine("\nInserire il codice ID della categoria della nuova spesa:");

            var categorieId = InMemoryStorage.Categorie.Select(c => c.Id).ToList();
            var categorieName = InMemoryStorage.Categorie.Select(c => c.Name).ToList();
            for (int i = 0; i < categorieId.Count; i++)
                Console.WriteLine($"ID:{categorieId[i]} => Categoria: {categorieName[i]}");

            int category;

            do
            {
                category = GetNumber2("il codice ID desiderato");

            } while (!mainBL.GetCategoriaById(category));



            Console.WriteLine("\nInserire il codice ID dell'utente:");

            var utenteId = InMemoryStorage.Utenti.Select(u => u.Id).ToList();
            var utenteName = InMemoryStorage.Utenti.Select(u => u.Name).ToList();
            var utenteLastName = InMemoryStorage.Utenti.Select(u => u.LastName).ToList(); //TODO

            for (int i = 0; i < utenteId.Count; i++)
                Console.WriteLine($"ID:{utenteId[i]} => Nome utente: {utenteName[i]} {utenteLastName[i]}");

            int utente;

            do
            {
                utente = GetNumber2("il codice ID desiderato");

            } while (!mainBL.GetUtenteById(utente));


            newSpesa.Date = date;
            newSpesa.Description = description;
            newSpesa.Amount = amount;
            newSpesa.CategoriaId = category;
            newSpesa.UtenteId = utente;

            bool IsAdded = mainBL.AddNewSpesa(newSpesa);

            if (IsAdded)
                Console.WriteLine("Spesa aggiunta correttamente.");
            else
                Console.WriteLine("Ops... qualcosa è andato storto!");
            Console.WriteLine();

        }


        private static decimal GetNumber(string message)
        {
            decimal number;

            Console.WriteLine($"\nInserire {message}: ");

            while(decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("\nE' possibile inserire solo numeri decimali. Riprova: ");
            }

            return number;

        }

        public static int GetNumber2(string message)
        {
            int number;

            Console.WriteLine($"\nInserire {message}: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("\nE' possibile inserire solo numeri interi. Riprova:");
            }

            return number;
        }

        public static string GetText(string message)
        {
            string text;
            do
            {
                Console.WriteLine($"\nInserire {message}: ");
                text = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(text));

            return text;
        }
    }
}
