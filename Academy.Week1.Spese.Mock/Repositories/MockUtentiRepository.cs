using Academy.Week1.Spese.Core.Interfaces;
using Academy.Week1.Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Mock.Repositories
{
    public class MockUtentiRepository : IUtentiRepository
    {
        public bool GetUtenteById(int utente)
        {
            List<Utente> users = InMemoryStorage.Utenti;

            foreach(var user in users)
                if(user.Id == utente)
                    return true;
            return false;
        }
    }
}
