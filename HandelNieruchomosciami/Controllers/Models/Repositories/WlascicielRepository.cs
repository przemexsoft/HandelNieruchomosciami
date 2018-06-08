using HandelNieruchomosciami.Controllers.Models.Interfaces;
using HandelNieruchomosciami.Controllers.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models.Repositories
{
    public class WlascicielRepository : IWlascicielRepository
    {
        private readonly DatabaseContext _databaseContext;

        public WlascicielRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<Wlasciciel> GetAll()
        {
            return _databaseContext.Wlasciciels.ToList();
        }

        public Wlasciciel GetWlasciciel(int WlascicielId)
        {
            return _databaseContext.Wlasciciels.Where(wlasciciel => wlasciciel.WlascicielId == WlascicielId).FirstOrDefault();
        }

       
    }
}
