using Academy.Week1.Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Mock.Repositories
{
    public class InMemoryStorage
    {
        public static List<Spesa> Spese { get; set; } = new List<Spesa>()
        { new Spesa()
            {
                Id = 1,
                Date = new DateTime(2021, 11, 4),
                Description = "Alimentari",
                Amount = 29.4m,
                Approved = true,
                CategoriaId = 3,
                UtenteId = 1
            },
            new Spesa()
            {
                Id = 2,
                Date = new DateTime(2021, 11, 29),
                Description = "Logistica",
                Amount = 138.3m,
                Approved = true,
                CategoriaId = 2,
                UtenteId = 1
            },

            new Spesa() { 
                Id = 3,
                Date = new DateTime(2021, 12, 2),
                Description = "Alimentari",
                Amount = 12.5m,
                Approved = false,
                CategoriaId = 1,
                UtenteId = 2
            },

            new Spesa()
            {
                Id = 4,
                Date = new DateTime(2021, 12, 1),
                Description = "Alimentari",
                Amount = 31.8m,
                Approved = true,
                CategoriaId = 1,
                UtenteId = 1
            }
        };

        public static List<Utente> Utenti { get; set; } = new List<Utente>()
        {
            new Utente()
            {
                Id = 1,
                Name = "Valeria",
                LastName = "Bianchi"
            },

            new Utente()
            {
                Id = 2,
                Name = "Tommaso",
                LastName = "Rossi"
            }
        };

        public static List<Categoria> Categorie { get; set; } = new List<Categoria>()
        {
            new Categoria()
            {
                Id = 1,
                Name = "Viaggio"
            },

            new Categoria()
            {
                Id = 2,
                Name = "Trasferta"
            },

            new Categoria()
            {
                Id = 3,
                Name = "Pernottamento"
            }
        };
    }
}
