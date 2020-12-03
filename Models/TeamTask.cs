using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Best_Hackathon_Codiseea.Models
{
    public class TeamTask
    {
        public string ID { get; set; }
        public string TeamName { get; set; }
        public string ItemNumber { get; set; }
        public string Value { get; set; }
        public int Points { get; set; }
        public int Attempts { get; set; }
        public DateTime Date { get; set; }
    }
}
