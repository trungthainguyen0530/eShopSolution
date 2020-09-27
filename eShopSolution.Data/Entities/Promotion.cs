using eShopSolution.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Boolean ApplyForAll { get; set; }
        public int? DiscountPercent { get; set; }
        public Decimal? DiscountAmount { get; set; }
        public int ProductIds { get; set; }
        public int ProductCategoryIds { get; set; }
        public Status status { get; set; }
        public string Name { get; set; }

    }
}
