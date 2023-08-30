using SAARS.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAARS.components
{
    public class DateComparer : IComparer
    {
        public string sortingFrom;
        public DateComparer(string sortingFrom)
        {
            this.sortingFrom = sortingFrom;
        }
        public int Compare(object x, object y)
        {
            ReportModel dataObjectX = (ReportModel)x;
            ReportModel dataObjectY = (ReportModel)y;
            if (sortingFrom == "conducted_date")
            {
                return DateTime.Compare(DateTime.Parse(dataObjectY.conducted_date), DateTime.Parse(dataObjectX.conducted_date));
            }
            else
            {
                return DateTime.Compare(DateTime.Parse(dataObjectY.reported_date), DateTime.Parse(dataObjectX.reported_date));
            }
        }
    }
}
