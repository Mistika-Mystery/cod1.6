using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cod1._6
{
    internal class appdb
    {
        public static TradeEntities db = new TradeEntities();
        public static User CurrentUser = new User();
    }
}
