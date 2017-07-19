using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.API.Models
{
    public class TrackingStatusDto
    {
        public DateTime DateAndTime { get; set; }
        public string Place { get; set; }
        public string Status { get; set; }
    }
}
