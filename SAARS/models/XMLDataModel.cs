using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAARS.models
{
    public class XMLDataModel
    {
        public string types { get; set; }
        public string date { get; set; }
        public string findings { get; set; }
        public string correctiveAction { get; set; }
        public string remarks { get; set; }
        public string classification { get; set; }

        public string scope { get; set; }

    }
}
