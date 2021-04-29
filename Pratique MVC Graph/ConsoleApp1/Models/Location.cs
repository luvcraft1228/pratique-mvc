using MVC_1B2.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LOTRMaps.Models
{
    public class Location : MVC_1B2.Db.Model, IComparable<Location>

    {
        public string Short { get; set; }
        public string Long { get; set; }

        public int CompareTo(Location other)
        {
            return this.Short.ToLower().CompareTo(other.Short.ToLower());
        }

        public override Model FromDataRow(DataRow row)
        {
            this.Short = row["short"].ToString();
            this.Long = row["long"].ToString();
            return this;
        }
    }
}
