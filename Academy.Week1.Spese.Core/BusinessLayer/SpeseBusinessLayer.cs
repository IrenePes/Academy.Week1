using Academy.Week1.Spese.Core.Interfaces;
using Academy.Week1.Spese.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese.Core.BusinessLayer
{
    public class SpeseBusinessLayer : IBusinessLayer
    {
        private readonly ISpeseRepository _speseRepository;
        private readonly ICategorieRepository _categorieRepository;
        private readonly IUtentiRepository _utentiRepository;

        public SpeseBusinessLayer(ISpeseRepository speseRepo, ICategorieRepository categorieRepo, IUtentiRepository utentiRepo)
        {
            _speseRepository = speseRepo;
            _categorieRepository = categorieRepo;
            _utentiRepository = utentiRepo;

        }

        public bool AddNewSpesa(Spesa newSpesa)
        {
            if(newSpesa == null)
                return false;

            return _speseRepository.Add(newSpesa);
        }

        public bool ApproveSpesa(int spesaId)
        {
            return _speseRepository.ApproveSpesa(spesaId);
        }

        public decimal ComputeTotalAmountLastMonthByCategory(int category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Spesa> FetchApprovedSpeseLastMonth()
        {
            return _speseRepository.FetchApprovedSpeseLastMonth();

        }

        public object FetchSpeseByUtente(int utente)
        {
            return _speseRepository.FetchSpeseByUtente(utente);
        }

        public List<Spesa> FetchSpeseNonApproved()
        {
            return _speseRepository.FetchSpeseNonApproved();
        }

        public bool GetCategoriaById(int category)
        {
            return _categorieRepository.GetCategoriaById(category);
        }

        public bool GetSpesaById(int spesaId)
        {
            return _speseRepository.GetSpesaById(spesaId);
        }

        public bool GetUtenteById(int utente)
        {
            return _utentiRepository.GetUtenteById(utente);
        }

        public object SortSpeseByDate()
        {
            return _speseRepository.SortSpeseByDate();
        }
    }
}
