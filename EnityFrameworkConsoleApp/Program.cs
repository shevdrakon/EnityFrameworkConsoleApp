using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnityFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new OnlineShopEntities();

            var k = -1;

            var gps = context.GoodsPositions;
            var gp = gps.First();
            var good = gp.Good;

            k = 100;

            var customer = gp.Order.GoodsPositions.Last().Good.Description;
        }
    }
}
