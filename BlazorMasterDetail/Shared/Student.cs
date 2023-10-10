using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMasterDetail.Shared
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Dob { get; set; }
        public decimal? Fees { get; set; }
        public bool IsActive { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
