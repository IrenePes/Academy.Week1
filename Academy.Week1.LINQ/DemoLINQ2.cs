using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.LINQ
{
    internal class DemoLINQ2
    {
        public static void Demo()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee()
            {
                ID = 1,
                Name = "Mario Rossi",
                Salary = 1200
            };

            Employee employee2 = new Employee()
            {
                ID = 2,
                Name = "Marco Bianchi",
                Salary = 1500
            };
            Employee employee3 = new Employee()
            {
                ID = 3,
                Name = "Sara Verdi",
                Salary = 1670
            };

            Employee employee4 = new Employee()
            {
                ID = 4,
                Name = "Tania Verdi",
                Salary = 1670
            };

            Employee employee5 = new Employee()
            {
                ID = 5,
                Name = "Tania Verdi",
                Salary = 1670
            };

            employees.Add(employee4);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee);
            employees.Add(employee5);

            // Recupero impiegato con ID 2

            Console.WriteLine("Nome dell'impiegato con ID = 2");

            int id = 2;
            IEnumerable<Employee> filteredEmployees1 = employees.Where(e => e.ID == id).ToList();   // facendo il ToList() non mi trovo più
                                                                                                    // un Enumerable ma direttamente una lista
                                                                
            foreach(var e in filteredEmployees1)
                Console.WriteLine(e.Name);

            var filteredEmployees2 = employees.Where(e => e.Salary >= 1500).ToList();

            // recuperiamo tutti i nomi degli impiegati

            Console.WriteLine("Lista nomi di tutti gli impiegati:");

            var names = employees.Select(e => e.Name);

            foreach(var n in names)
                Console.WriteLine(n);

            // recuperiamo i nomi degli impiegati che hanno ID = 2

            Console.WriteLine("Lista nomi impiegati con ID = 2:");

            var filteredEmployees3 = employees.Where(e => e.ID == 2).Select(e => e.Name).ToList();

            foreach(var e in filteredEmployees3)
                Console.WriteLine(e);

            // recuperiamo il nome del primo impiegato che ha ID = 2

            Console.WriteLine("Nome del primo impiegato trovato nella lista con ID = 2:");

            var foundEmployee = employees.FirstOrDefault(e => e.ID == 2);

            Console.WriteLine(foundEmployee.Name);


            var foundEmployee2 = employees.FirstOrDefault(e => e.ID == 10);

            var foundEmployee3 = employees.SingleOrDefault(e => e.ID == 3);

            // var foundEmployee4 = employees.SingleOrDefault(e => e.Name == "Tania Verdi"); // si aspetta di trovarne solo uno e quindi va in eccezione

            // stampiamo i nomi ordinati

            Console.WriteLine("Elenco impiegati in ordine alfabetico:");

            var orderedEmployees = employees.OrderBy(e => e.Name);

            foreach(var o in orderedEmployees)
                Console.WriteLine(o.Name);

            // seleziono i nomi di tutti gli impiegati e li salvo tutti maiuscoli

            Console.WriteLine("Nomi maiuscoli:");

            var names2 = employees.Select(e =>e.Name.ToUpper());  // prende ogni elemento nome e me lo rende maiuscolo

            foreach(var n in names2)
                Console.WriteLine(n);

            var names3 = employees.Select(e => e.ID == 2);      // in questo caso mi viene restituito solo un booleano 
                                                                // nel caso sopra no perchè non c'era una condizione 







        }
    }
}
