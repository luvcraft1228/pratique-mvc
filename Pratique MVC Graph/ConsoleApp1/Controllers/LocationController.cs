using System;
using System.Collections.Generic;
using System.Text;

namespace LOTRMaps.Controllers
{
    public class LocationController : Controller<Models.Location>
    {
        public List<Models.Location> Get()
        {
            return base.Get("select * from Location");
        }
    }
}
