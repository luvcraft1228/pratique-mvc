using MVC_1B2.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace LOTRMaps.Models
{
    public class Path : MVC_1B2.Db.Model
    {
        public Location From { get; set; }
        public Location To { get; set; }
        public double Distance { get; set; } 
        public double Time { get; set; }
        public override Model FromDataRow(DataRow row)
        {
            this.From = new Location() { Short = row["from"].ToString() };
            this.To = new Location() { Short = row["to"].ToString() };
            this.Distance = (double)row["Distance"];
            this.Time = (double)row["Time"];
            return this;
        }
    }
}
