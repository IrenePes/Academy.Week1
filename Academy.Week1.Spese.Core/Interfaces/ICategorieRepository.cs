using Academy.Week1.Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Core.Interfaces
{
    public interface ICategorieRepository : IRepository<Categoria>
    {
        bool GetCategoriaById(int category);
    }
}
