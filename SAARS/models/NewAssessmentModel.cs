using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAARS.models
{
    public class NewAssessmentModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string conducted_date { get; set; }
        public string reported_date { get; set; }
        public string findings { get; set; }
        public string corrective_action { get; set; }
        public string remarks { get; set; }
        public string classification { get; set; }

        public string scope { get; set; }
        public ArrayList assessment_types { get; set; }

        public string documentSettings { get; set; }
    }
}
