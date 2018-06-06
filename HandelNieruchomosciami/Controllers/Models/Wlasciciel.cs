using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models
{
    public class Wlasciciel
    {
        public int WlascicielId { get; set; }
        public string WlascicielImie { get; set; }
        public string WlascicielNazwisko { get; set; }
        public string WlascicielAdres { get; set; }
        public int WlascicielTelefon { get; set; }
        public string WlascicielEmail { get; set; }
    }
}
