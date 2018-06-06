using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models
{
    public class Nieruchomosc
    {
        public int NieruchomoscId { get; set; }
        public string NieruchomoscUlica { get; set; }
        public string NieruchomoscNrBudynku { get; set; }
        public string NieruchomoscKodPocztowy { get; set; }
        public string NieruchomoscMiasto { get; set; }
        public int NieruchomoscPowierzchnia { get; set; }
        public int NieruchomoscCzynsz { get; set; }
        public int NieruchomoscWlasciciel { get; set; }

        public virtual int NieruchomoscTypZabudowy { get; set; }
        public virtual TypZabudowy TypZabudowy{ get; set; }
    }
}
