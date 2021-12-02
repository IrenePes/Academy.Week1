using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.LINQ
{
    internal class DemoLINQ
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

            employees.Add(employee);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);

            foreach(Employee e in employees)
            {
                if(e.ID == 2)
                    Console.WriteLine("Nome dell'impiegato con ID 2 (foreach)" + e.Name);
            }

            IEnumerable<string> names =                 // mi trovo un oggetto di tipo enumerable di stringhe
                from e in employees                     // from mi specifica dove prendere i dati
                where e.ID == 2                         // where è una specie di filtro (cosa voglio fare)
                select e.Name;                          // specifica il tipo di ritorno

            Console.WriteLine(" Nome dell'impiegato con ID 2 (query sintax)");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            IEnumerable<Employee> filteredEmployees = // la variabile di query archivia i comandi della query
                from e in employees
                where e.ID == 2
                select e;

            Console.WriteLine(" Impiegato con ID 2:");
            foreach(var e in filteredEmployees)
                Console.WriteLine(e.Name);

            IEnumerable<Employee> filteredEmployees2 =
                from e in employees
                where e.Salary >= 1500
                select e;

            Console.WriteLine("Impiegati con salario maggiore di 1500:");
            foreach(var e in filteredEmployees2)
                Console.WriteLine(e.Name);

        
            // per ordinare degli elementi (cerchiamo di farlo tramite il nome)

            var orderedEmployees = 
                from e in employees
                orderby e.Name
                select e;

            Console.WriteLine("Impiegati in ordine alfabetico:");
            foreach(var e in orderedEmployees)
                Console.WriteLine(e.Name);


            // Possiamo usare anche le espressioni con l'operatore lambda

            // sono implementati con metodi detti extention method (metodo di estensione)

            // in LINQ estendono l'interfaccia Enumerable<T> e l'interfaccia IQuerable<T>

            // Reference: System.Linq


            



        }

    }
}
