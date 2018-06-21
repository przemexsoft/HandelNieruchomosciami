using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandelNieruchomosciami.Controllers.Models.Interfaces
{
    public interface IAgentRepository
    {
        List<Agent> GetAllAgents();
        Agent GetAgent(int AgentId);

        int AddAgent(Agent agent);
        int UpdateAgent(Agent agent);
        void DeleteAgent(Agent agent);
    }
}