using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaovietServerBlazorApp.Data;
using SaovietServerBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SaovietServerBlazorApp.Services
{
    public class AddressService
    {
        private readonly SaovietContext _saovietContext;
        public AddressService(SaovietContext saovietContext)
        {
            _saovietContext = saovietContext;
        }
        public async Task<List<AddressModel>> GetAddresses()
        {
            var results = await _saovietContext.Addresses.ToListAsync();
            return results;
        }
    }
}
