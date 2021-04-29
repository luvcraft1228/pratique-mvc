using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;



namespace LOTRMaps
{
    public class DbContext : MVC_1B2.Db.Database
    {
        public static DbContext Instance { get; } = new DbContext();
        public Controllers.LocationController Locations { get; set; } 
        public Controllers.PathController Paths { get; set; }
        public DbContext()
        {
            Locations = new Controllers.LocationController();
            Paths = new Controllers.PathController();
            this.SetConnection("DESKTOP-HRHC1F9\\SQLEXPRESS", "LOTRmaps");
            Locations.Database = Paths.Database = this;
            

        }
    }
}
