using System;
using System.Collections.Generic;

namespace Hospital.Models
{
    public partial class School
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; } = null!;
        public string SchoolAddress { get; set; } = null!;
        public string SchoolEmail { get; set; } = null!;
        public int SchoolPhoneNumber { get; set; }
        public DateTime FoundedYear { get; set; }
    }
}
