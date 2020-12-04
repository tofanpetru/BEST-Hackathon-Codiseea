using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Hackathon_Codiseea.Models
{
    public class TeamRepository
    {
        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
        public string RepositoryLink { get; set; }
    }
}
