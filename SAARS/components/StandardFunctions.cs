using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAARS.components
{
    public static class StandardFunctions
    {
        public static string ConvertDateStamp(string date)
        {
            DateTime parsedDate = DateTime.Parse(date);
            return parsedDate.ToString("MMM dd, yyyy");
        }

        public static string GetDateTimeStamp()
        {
            string date = DateTime.Now.ToString("MMM dd, yyyy");
            //string time = DateTime.Now.ToString("h:mm tt");
            return $"{date}";
        }
    }
}
