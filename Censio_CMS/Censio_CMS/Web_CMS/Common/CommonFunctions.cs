using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;

namespace Censio_CMS.Web
{
    internal static class CommonFunctions
    {
        public static IEnumerable<DateTime> Range(this DateTime startDate, int numberOfDays) => Enumerable.Range(0, numberOfDays).Select(e => startDate.AddDays(e));

        public static int ID_ORGANIZATION =1;
        public static int Id_Product = 2;




    }
}