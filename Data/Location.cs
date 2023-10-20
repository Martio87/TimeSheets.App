using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheets.App.Data
{
    internal class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // Relationships.
        public int LocationId { get; set; }
        public List<Staff> StaffMembers { get; set; } // One-to-many relationship with Staff.
        public List<Clients> Clients { get; set; } // One-to-many relationship with Client.
        public List<TimeSheet> TimeSheets { get; set; } // One-to-many relationship with TimeSheet.
    }
}
