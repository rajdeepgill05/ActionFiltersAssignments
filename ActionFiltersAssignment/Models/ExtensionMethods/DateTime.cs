using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionFiltersAssignment.Models.ExtensionMethods
{
    public static class DateTime
    {
       

        public static DateTime? ToAge(this DateTime Data)
        {
            var Today = System.DateTime.Today;
            return((Today ));
        }
    }
}