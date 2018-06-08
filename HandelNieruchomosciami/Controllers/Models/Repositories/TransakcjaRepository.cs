using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandelNieruchomosciami.Controllers.Models.Interfaces;
using HandelNieruchomosciami.Controllers.Models.Database;

namespace HandelNieruchomosciami.Controllers.Models.Repositories
{
    public class TransakcjaRepository : ITransakcjaRepository
    {
        private readonly DatabaseContext _databaseContext;

        public TransakcjaRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext; 
        }

        public List<Transakcja> GetAll()
        {
            return _databaseContext.Transakcjas.ToList();
        }

        public Transakcja GetTransakcja (int TransakcjaId)
        {
            return _databaseContext.Transakcjas.Where(transakcja => transakcja.TransakcjaId == TransakcjaId).FirstOrDefault();
        }
    }
}
