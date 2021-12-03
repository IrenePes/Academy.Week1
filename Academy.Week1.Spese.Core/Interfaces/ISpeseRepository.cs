using Academy.Week1.Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Core.Interfaces
{
    public interface ISpeseRepository : IRepository<Spesa>

    {
        bool Add(Spesa newSpesa);
        List<Spesa> FetchSpeseNonApproved();
        bool GetSpesaById(int spesaId);
        bool ApproveSpesa(int spesaId);
        object FetchSpeseByUtente(int utente);
        object SortSpeseByDate();
        IEnumerable<Spesa> FetchApprovedSpeseLastMonth();
    }
}
