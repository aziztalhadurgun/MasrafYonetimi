using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class Constants
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MasrafDB"].ConnectionString;
    }
}
