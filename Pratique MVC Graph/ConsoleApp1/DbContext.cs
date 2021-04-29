using System;
using System.Collections.Generic;
using System.Text;

namespace LOTRMaps
{
    public class DbContext : MVC_1B2.Db.Database
    {
        public static DbContext Instance { get; } = new DbContext();
        
    }
}
