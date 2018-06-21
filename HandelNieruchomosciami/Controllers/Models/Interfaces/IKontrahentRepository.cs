using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models.Interfaces
{
    public interface IKontrahentRepository
    {
        List<Kontrahent> GetAllKontrahents();
        Kontrahent GetKontrahent(int KontrahentId);

        int AddKontrahent(Kontrahent kontrahent);
        int UpdateKontrahent(Kontrahent kontrahent);
        void DeleteKontrahent(Kontrahent kontrahent);
    }
}
