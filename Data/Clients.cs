using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheets.App.Data
{
    internal class Clients
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string BillingAddress { get; set; }
        public string ContactName { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactEmail { get; set; }

        // Relationships.
        public int LocationId { get; set; }
        public Location Location { get; set; } // One-to-one relationship with Location.
        public List<TimeSheet> TimeSheets { get; set; } // One-to-many relationship with TimeSheet.
    }
}
