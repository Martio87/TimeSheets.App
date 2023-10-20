using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheets.App.Data
{
    internal class TimeSheet
    {
        public int Id { get; set; }
        public int MinutesWorked { get; set; }
        public int StaffId { get; set; }
        public int ClientId { get; set; }
        public int LocationId { get; set; }

        // Relationships.
        public Staff Staff { get; set; } // Navigation property for the Staff relationship.
        public Clients Clients { get; set; } // Navigation property for the Client relationship.
        public Location Location { get; set; } // Navigation property for the Location relationship.

    }
}
