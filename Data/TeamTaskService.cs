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
        
        public async Task<List<TeamTask>> GetTasksAsync()
        {
            var result = _context.TeamTasks;
            return await Task.FromResult(result.ToList());
        }

        public async Task<TeamTask> GetTeamTaskByIdAsync(int id)
        {
            return await _context.TeamTasks.FindAsync(id);
        }

        public async Task<TeamTask> InsertTeamTaskAsync(TeamTask teamTask)
        {
            _context.TeamTasks.Add(teamTask);
            await _context.SaveChangesAsync();
            return teamTask;
        }

        public async Task<TeamTask> UpdateTeamTaskAsync(int id, TeamTask s)
        {
            var teamTask = await _context.TeamTasks.FindAsync(id);
            
            if(teamTask == null)
            {
                return null;
            }
            teamTask.TeamName = s.TeamName;
            teamTask.Value = s.Value;
            teamTask.Points = s.Points;
            teamTask.Date = s.Date;

            _context.TeamTasks.Update(teamTask);
            await _context.SaveChangesAsync();

            return teamTask;
        }

        public async Task<TeamTask> DeleteTeamTaskAsync(int id)
        {
            var teamTask = await _context.TeamTasks.FindAsync(id);

            if(teamTask == null)
            {
                return null;
            }

            _context.TeamTasks.Remove(teamTask);
            await _context.SaveChangesAsync();

            return teamTask;
        }

        private bool SolutionExists(int id)
        {
            return _context.TeamTasks.Any(e => e.ID == id);
        }
    }
}
