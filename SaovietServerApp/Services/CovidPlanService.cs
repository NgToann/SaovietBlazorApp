using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaovietServerBlazorApp.Data;
using SaovietServerBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SaovietServerBlazorApp.Services
{
    public class CovidPlanService
    {
        private readonly SaovietContext _saovietContext;
        public CovidPlanService(SaovietContext saovietContext)
        {
            _saovietContext = saovietContext;
        }
        public async Task<List<CovidPlanModel>> GetCovidPlans()
        {
            var results = await _saovietContext.CovidPlans.ToListAsync();
            return results;
        }

        public async Task<bool> AddCovidPlan(CovidPlanModel addModel)
        {
            using (_saovietContext)
            {
                _saovietContext.CovidPlans.Add(addModel);
                await _saovietContext.SaveChangesAsync();
                return true;
            }
        }
    }
}
