using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaovietServerBlazorApp.Models
{
    public class CovidPlanModel
    {
        [Key]
        [Required]
        public string WorkerId { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public string ProvinceId { get; set; }
        public string DistrictId { get; set; }
        public string CommuneId { get; set; }
        public string AddressDetail { get; set; }
        public string HeathStatus { get; set; }
        public DateTime CreatedTime { get; set; }

    }
}
