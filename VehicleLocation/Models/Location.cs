using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleLocation.Models
{
    public class Location
    {
        public int Id { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string IpAddress { get; set; }
        public string RouteName { get; set; }

    }
}
