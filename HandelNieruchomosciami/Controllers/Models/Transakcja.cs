using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models
{
    public class Transakcja
    {
        public int TransakcjaId { get; set; }
        public string TransakcjaNumer { get; set; }
        public DateTime TransakcjaDataUtworzenia { get; set; }

        public virtual int TransakcjaNieruchomoscId { get; set; }
        public virtual Nieruchomosc Nieruchomosc { get; set; }

        public virtual int TransakcjaSprzedawcaId { get; set; }
        public virtual Wlasciciel Wlasciciel { get; set; }

        public virtual int TransakcjaKontrahentId { get; set; }
        public virtual Kontrahent Kontrahent { get; set; }

        public virtual string TransakcjaNumerUmowy { get; set; }
        public virtual Umowa Umowa { get; set; }

        public virtual int TransakcjaAgentId { get; set; }
        public virtual Agent Agent { get; set; }

        public virtual int TransakcjaStatusTransakcjiId { get; set; }
        public virtual StatusTransakcji StatusTransakcji { get; set; }

    }
}
