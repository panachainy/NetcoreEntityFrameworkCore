using System;
using System.Collections.Generic;

namespace NetCore_webapi_efcore.Models.DB
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
