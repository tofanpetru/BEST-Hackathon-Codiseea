using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Best_Hackathon_Codiseea.Models;

namespace Best_Hackathon_Codiseea.Data
{
    public class TeamTaskService
    {
        ApplicationDbContext _context;
 
        public TeamTaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TeamTask>> GetTasksAsync(string teamName, string items)
        {
            var result = _context.TeamTasks.Where(e => e.TeamName == teamName).Where(e => items.Contains(e.ItemNumber));
            return await Task.FromResult(result.ToList());
        }
        public async Task<List<TeamTask>> GetPersonalTasksAsync(string teamName)
        {
            var result = _context.TeamTasks.Where(e => e.TeamName == teamName).Where(e => e.Value == "Correct");
            return await Task.FromResult(result.ToList());
        }

        public async Task<List<TeamTask>> GetGlobalCorrectAnswersAsync()
        {
            var result = _context.TeamTasks.Where(e => e.Value == "Correct");
            return await Task.FromResult(result.ToList());
        }
        //
        public async Task<List<TeamTask>> GetNumberOfTeamsWhoAnswer()
        {
            var result = _context.TeamTasks.Where(e => e.TeamName != null).Where(e => e.Value == "Correct");
            return await Task.FromResult(result.ToList());
        }

        public async Task<TeamTask> InsertTeamTaskAsync(TeamTask teamTask)
        {
            _context.TeamTasks.Add(teamTask);
            await _context.SaveChangesAsync();
            return teamTask;
        }

        public async Task<TeamTask> UpdateTeamTaskAsync(string id, TeamTask s)
        {
            var teamTask = await _context.TeamTasks.FindAsync(id);

            if (teamTask == null)
            {
                return null;
            }
            teamTask.TeamName = s.TeamName;
            teamTask.Value = s.Value;
            teamTask.Points = s.Points;
            teamTask.Date = s.Date;
            teamTask.Attempts = s.Attempts;
            teamTask.ItemNumber = s.ItemNumber;

            _context.TeamTasks.Update(teamTask);
            await _context.SaveChangesAsync();

            return teamTask;
        }

        public async Task<TeamTask> DeleteTeamTaskAsync(string id)
        {
            var teamTask = await _context.TeamTasks.FindAsync(id);

            if (teamTask == null)
            {
                return null;
            }

            _context.TeamTasks.Remove(teamTask);
            await _context.SaveChangesAsync();

            return teamTask;
        }

        private bool SolutionExists(string id)
        {
            return _context.TeamTasks.Any(e => e.ID == id);
        }

        private int SumTasks(string teamName)
        {
            return _context.TeamTasks.Where(e => e.TeamName == teamName).Sum(e => e.Points);
        }
    }
}
