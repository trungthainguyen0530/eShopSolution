using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public int productId { get; set; }
        public decimal quantity { get; set; }
        public decimal price { get; set; }

        public Guid UserId { get; set; }

        public DateTime DateCreated { get; set; }

        public Product Product { get; set; }
    }
}
