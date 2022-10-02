using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string ProjectDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
