using System;
using System.Collections.Generic;
namespace LOTRMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DbContext.Instance.Paths.Database.Test();
            List<Models.Path> Paths = DbContext.Instance.Paths.Get();
            foreach (var item in Paths)
            {
                Console.WriteLine(item.From.Short);
            }
        }
    }
}
