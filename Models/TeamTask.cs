using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Best_Hackathon_Codiseea.Models
{
    public class TeamTask
    {
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public string Points { get; set; }
        public DateTime Date { get; set; }
    }
}
