using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string AgentImie { get; set; }
        public string AgentNazwisko { get; set; }
        public int AgentPESEL { get; set; }
        public int AgentNIP { get; set; }
        public string AgentUlica { get; set; }
        public string AgentKodPocztowy { get; set; }
        public string AgentMiasto { get; set; }
        public int AgentTelefon { get; set; }
        public string AgentEmail { get; set; }
        public DateTime AgentZatrudnienieOd { get; set; }
        public string AgentNrLicencji { get; set; }
        public string AgentDataWaznosciLicencji { get; set; }        
    }
}
