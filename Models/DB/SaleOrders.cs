using System;
using System.Collections.Generic;

namespace NetCore_webapi_efcore.Models.DB
{
    public partial class SaleOrders
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }
        public float Price { get; set; }
        public int Unit { get; set; }
        public float Total { get; set; }

        public Employees Employee { get; set; }
        public Products Product { get; set; }
    }
}
