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
        public float Distance { get; set; } 
        public float Time { get; set; }
        public override Model FromDataRow(DataRow row)
        {
            this.From = new Location() { Short = row["from"].ToString() };
            this.To = new Location() { Short = row["to"].ToString() };
            this.Distance = (float)row["Distance"];
            this.Time = (float)row["Time"];
            return this;
        }
    }
}
