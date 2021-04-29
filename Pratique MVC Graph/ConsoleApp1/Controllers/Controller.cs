using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LOTRMaps.Controllers
{
    public class Controller<T> : MVC_1B2.Db.Controller where T : MVC_1B2.Db.Model, new()
    {   
        protected List<T> Get(string sqlStatement)
        {
            List<T> result = new List<T>();
            SqlCommand command = new SqlCommand();
            command.CommandText = sqlStatement;

            foreach (DataRow row in this.Database.ExecuteDataRows(command))
            {
                T item = new T();
                item.FromDataRow(row);
                result.Add(item);
            }

            return result;
        }
    }
}
