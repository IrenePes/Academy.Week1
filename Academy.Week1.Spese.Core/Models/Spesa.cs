using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Core.Models
{
    public class Spesa
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool Approved { get; set; }
        public int CategoriaId { get; set; }
        public int UtenteId { get; set; }

    }
}
