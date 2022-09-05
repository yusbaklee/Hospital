using System;
using System.Collections.Generic;

namespace Hospital.Models
{
    public partial class staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
