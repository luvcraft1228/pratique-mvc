using MVC_1B2.Db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LOTRMaps.Models
{
    public class Location : MVC_1B2.Db.Model

    {
        public string Short { get; set; }
        public string Long { get; set; }
       
        public override Model FromDataRow(DataRow row)
        {
            this.Short = row["short"].ToString();
            this.Long = row["long"].ToString();
            return this;
        }
    }
}
