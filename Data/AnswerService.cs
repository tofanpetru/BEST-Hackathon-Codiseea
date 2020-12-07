using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Best_Hackathon_Codiseea.Models;

namespace Best_Hackathon_Codiseea.Data
{
    public class AnswerService
    {
        ApplicationDbContext _context;

        public AnswerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Answer>> GetAnswersAsync()
        {
            var result = _context.Answers;
            return await Task.FromResult(result.ToList());
        }
    }
}
