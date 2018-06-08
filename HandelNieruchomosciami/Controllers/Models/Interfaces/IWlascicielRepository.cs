using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models.Interfaces
{
    public interface IWlascicielRepository
    {
        List<Wlasciciel> GetAll();
        Wlasciciel GetWlasciciel(int WlascicielId);
    }
}
