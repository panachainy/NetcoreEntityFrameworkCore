using System;
using System.Collections.Generic;

namespace NetCore_webapi_efcore.Models.DB
{
    public partial class Employees
    {
        public Employees()
        {
            SaleOrders = new HashSet<SaleOrders>();
        }

        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Departments Department { get; set; }
        public ICollection<SaleOrders> SaleOrders { get; set; }
    }
}
