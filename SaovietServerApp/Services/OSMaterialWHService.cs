using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaovietServerBlazorApp.Data;
using SaovietServerBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SaovietServerBlazorApp.Services
{
    public class OSMaterialWHService
    {
        private readonly SaovietContext _saovietContext;
        public OSMaterialWHService(SaovietContext saovietContext)
        {
            _saovietContext = saovietContext;
        }

        public async Task<List<OrderModel>> GetOrdersIsEnable()
        {
            var results = await _saovietContext.Orders.Where(w => w.IsEnable == true).ToListAsync();
            return results;
        }

        public async Task<List<OutsoleSupplierModel>> GetOutsoleSuppliers()
        {
            var results = await _saovietContext.OutsoleSuppliers.ToListAsync();
            return results;
        }

        public async Task<List<OSMaterialWHCheckModel>> GetOSMaterialByIndexNo(int indexNo)
        {
            var results = await _saovietContext.OutsoleMaterialCheckingList.Where(w => w.WorkingCard == indexNo && w.Quantity > 0).ToListAsync();
            return results;
        }

        public async Task<bool> ConfirmMaterial (OSMaterialWHCheckModel updateModel)
        {
            _saovietContext.OutsoleMaterialCheckingList.Attach(updateModel);
            _saovietContext.Entry(updateModel).Property(p => p.IsConfirm).IsModified = true;
            _saovietContext.Entry(updateModel).Property(p => p.ConfirmedTime).IsModified = true;

            await _saovietContext.SaveChangesAsync();
            return true;
        }
    }
}
