using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models
{
    public class Kontrahent
    {
        public int KontrahentId { get; set; }
        public string KontrahentImie { get; set; }
        public string KontrahentNazwisko { get; set; }
        public int KontrahentPESEL { get; set; }
        public int KontrahentNIP { get; set; }
        public string KontrahentAdresKorespondencyjny { get; set; }
        public int KontrahentTelefon { get; set; }
        public string KontrahentEmail { get; set; }
    }
}
