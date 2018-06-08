using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models.Interfaces
{
    public interface ITransakcjaRepository 
    {
        List<Transakcja> GetAll();
        Transakcja GetTransakcja(int TransakcjaId);
    }
}
