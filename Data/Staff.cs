using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheets.App.Data
{
    internal class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        // Relationships.
        public int LocationId { get; set; }
        public Location Location { get; set; } // One-to-one relationship with Location.
        public List<TimeSheet> TimeSheets { get; set; } // One-to-many relationship with TimeSheet.
    }
}

