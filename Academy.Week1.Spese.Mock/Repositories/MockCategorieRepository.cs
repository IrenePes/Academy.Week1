using Academy.Week1.Spese.Core.Interfaces;
using Academy.Week1.Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Mock.Repositories
{
    public class MockCategorieRepository : ICategorieRepository
    {
        public bool GetCategoriaById(int category)
        {
            List<Categoria> categories = InMemoryStorage.Categorie;

            foreach (var cat in categories)
                if (cat.Id == category)
                    return true;
            return false;
        }
    }
}
