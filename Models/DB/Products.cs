using System;
using System.Collections.Generic;

namespace NetCore_webapi_efcore.Models.DB
{
    public partial class Products
    {
        public Products()
        {
            SaleOrders = new HashSet<SaleOrders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }

        public ICollection<SaleOrders> SaleOrders { get; set; }
    }
}
