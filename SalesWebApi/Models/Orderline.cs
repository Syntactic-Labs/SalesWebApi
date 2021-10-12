using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SalesWebApi.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public String Name { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; }
        public int? OrderId { get; set; }

        public Orderline() { }
        [JsonIgnore]
        public virtual Order Order { get; set; }
    }   
}
