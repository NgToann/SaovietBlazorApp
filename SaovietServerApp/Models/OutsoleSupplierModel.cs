using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaovietServerBlazorApp.Models
{
    public class OutsoleSupplierModel
    {
        [Key]
        public int OutsoleSupplierId { get; set; }
        public string Name { get; set; }
        public string SupplierOperation { get; set; }
        public string Remarks { get; set; }
    }
}
