using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models
{
    public class Umowa
    {
        public int UmowaId { get; set; }
        public string UmowaNumerUmowy { get; set; }
        public DateTime UmowaDataSporzadzeniaUmowy { get; set; }
        public int UmowaKwotaPLN { get; set; }

        public virtual int UmowaNieruchomoscId { get; set; }
        public virtual Nieruchomosc Nieruchomosc { get; set; }

        public virtual int UmowaSprzedajacyId { get; set; }
        public virtual Wlasciciel Wlasciciel { get; set; }

        public virtual int UmowaKontrahentId { get; set; }
        public virtual Kontrahent Kontrahent { get; set; }


    }
}
