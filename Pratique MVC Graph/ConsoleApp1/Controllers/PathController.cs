using System;
using System.Collections.Generic;
using System.Text;

namespace LOTRMaps.Controllers
{
    public class PathController : Controller<Models.Path>
    {
        public List<Models.Path> Get()
        {
            return base.Get("select * from Path");
        }
    }
}

