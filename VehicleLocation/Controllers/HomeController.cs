using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleLocation.Models;

namespace VehicleLocation.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext context;

        public HomeController(AppDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();

        }
        [HttpGet]
        public IActionResult ChooseYourBus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChooseYourBus(Vehicle vehicle)
        {


            //vcode = Convert.ToInt32(vehicle.VehicleCode);

            return RedirectToAction("ShowLocation", new { v = vehicle.RouteName });
        }
        public IActionResult ShowLocation(string v)
        {


            var model = context.locations.FromSql(@"select* from locations where Id in (select max(Id) from locations group by IpAddress )").ToList();

         
         
        
             
            return View(model);
        }
        [HttpGet]
        public IActionResult CatchLocation()
        {
            var model = context.vehicles.FromSql(@"select * from vehicles");
            return View(model);
        }
    
    [HttpPost]
    public IActionResult CatchLocation(Location buslocate)
    {

        //ipAddress = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress?.ToString();

        Location ll = new Location
        {
            longitude = buslocate.longitude,
            latitude = buslocate.latitude,
            IpAddress = buslocate.IpAddress,
            RouteName = buslocate.RouteName

        };



        context.locations.Add(ll);
        context.SaveChanges();
        return View();
    }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(Vehicle vehicle)
        {
            Vehicle vv = new Vehicle
            {
                IpAddress = vehicle.IpAddress,
                RouteName=vehicle.RouteName
                };
            context.vehicles.Add(vv);
            context.SaveChanges();

            return View();
        }
        [HttpGet]
        public IActionResult ShowAllData()
        {
            var model=context.locations.FromSql(@"select*from locations");

            return View(model);
        }
        public IActionResult DeleteLocation(int id)
        {
            var location = context.locations.Find(id);
            if (location != null)
            {
                context.locations.Remove(location);
                context.SaveChanges();
            }

            return RedirectToAction("ShowAllData");
        }
    }
}
