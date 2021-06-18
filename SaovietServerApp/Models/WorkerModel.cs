using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaovietServerBlazorApp.Models
{
    public class WorkerModel
    {
        [Key]
        public string WorkerId { get; set; }
        public string CardId { get; set; }
        public string FullName { get; set; }
        public string SectionName { get; set; }
        public string LineName { get; set; }
        public string Factory { get; set; }
    }
}
