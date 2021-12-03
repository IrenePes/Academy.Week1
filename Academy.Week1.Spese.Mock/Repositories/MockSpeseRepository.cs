using Academy.Week1.Spese.Core.Interfaces;
using Academy.Week1.Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Mock.Repositories
{
    public class MockSpeseRepository : ISpeseRepository
    {
        public bool Add(Spesa newSpesa)
        {
            if (newSpesa == null)
                return false;

            newSpesa.Id = InMemoryStorage.Spese.Max(s => s.Id) + 1;
            newSpesa.Approved = false;

            InMemoryStorage.Spese.Add(newSpesa);

            return true;
        }

        public bool ApproveSpesa(int spesaId)
        {
            List<Spesa> outgoings = InMemoryStorage.Spese;
            foreach(Spesa o in outgoings)
                if (o.Id == spesaId)
                { o.Approved = true;
                  return true; 
                }
            return false;
        }

        public IEnumerable<Spesa> FetchApprovedSpeseLastMonth()
        {
            List<Spesa> outgoings = InMemoryStorage.Spese;
            var approvedLastMonth = outgoings.Where(o => o.Approved && o.Date >= DateTime.Today.AddDays(-DateTime.Today.Day + 1).AddMonths(-1)
                                                        && o.Date <= DateTime.Today.AddDays(-DateTime.Today.Day));

            return approvedLastMonth;
        }

        public object FetchSpeseByUtente(int utente)
        {
            List<Spesa> spesaByUtente = new List<Spesa>();
            List<Spesa> outgoings = InMemoryStorage.Spese;

            foreach(Spesa o in outgoings)
            {
                if(o.UtenteId == utente)
                    spesaByUtente.Add(o);
            }

            return spesaByUtente;
        }

        public List<Spesa> FetchSpeseNonApproved()
        {
            List<Spesa> outgoings = InMemoryStorage.Spese;
            List<Spesa> SpeseNonApproved = new List<Spesa>();

            foreach(Spesa o in outgoings)
                if (!o.Approved)
                    SpeseNonApproved.Add(o);
            return SpeseNonApproved;
        }

        public bool GetSpesaById(int spesaId)
        {
            List<Spesa> outgoings = InMemoryStorage.Spese;

            foreach(Spesa o in outgoings)
                if(o.Id == spesaId)
                    return true;

            return false;
        }

        public object SortSpeseByDate()
        {
            List<Spesa> outgoings = InMemoryStorage.Spese;
            var orderedSpese = outgoings.OrderBy(o => o.Date).ToList();
            return orderedSpese;
        }
    }
}
