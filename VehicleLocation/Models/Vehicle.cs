using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleLocation.Models
{
    public class Vehicle
    {
        public int id { get; set; }
        public string IpAddress { get; set; }
        public string RouteName { get; set; }
    }
}
