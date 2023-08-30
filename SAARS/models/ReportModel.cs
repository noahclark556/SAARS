using SAARS.ui.dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAARS.models
{
    public class ReportModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string conducted_date { get; set; }
        public string reported_date { get; set; }
        public string conducted_by { get; set; }
        public string report_data { get; set; }
        public string classification { get; set; }
        public string documentSettings { get; set; }
    }
}
