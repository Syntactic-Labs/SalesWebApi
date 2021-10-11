using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime GetDate { get; set; }
        [StringLength(90), Required]
        public string Description { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public Order() { }
    }
}
