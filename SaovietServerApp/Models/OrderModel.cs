using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaovietServerBlazorApp.Models
{
    public class OrderModel
    {
        [Key]
        public string ProductNo { get; set; }
        public int TypeOfShoes { get; set; }
        public string GTNPONo { get; set; }
        public string UCustomerCode { get; set; }
        public DateTime ETD { get; set; }
        public DateTime ShipDate { get; set; }
        public string ArticleNo { get; set; }
        public string ShoeName { get; set; }
        public int Quantity { get; set; }
        public string PatternNo { get; set; }
        public string MidsoleCode { get; set; }
        public string OutsoleCode { get; set; }
        public string LastCode { get; set; }
        public string Country { get; set; }
        public bool IsEnable { get; set; }
        public string Reviser { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ModifiedTime { get; set; }
    }
}
