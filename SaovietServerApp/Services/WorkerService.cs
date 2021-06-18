using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaovietServerBlazorApp.Data;
using SaovietServerBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SaovietServerBlazorApp.Services
{
    public class WorkerService
    {
        private readonly SaovietContext _saovietContext;
        public WorkerService(SaovietContext saovietContext)
        {
            _saovietContext = saovietContext;
        }
        public async Task<List<WorkerModel>> GetWorkers()
        {
            var results = await _saovietContext.Workers.ToListAsync();
            return results;
        }
    }
}
