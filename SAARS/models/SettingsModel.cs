using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAARS.models
{
    [Serializable]
    public class SettingsModel
    {
        public bool showClassification { get; set; }

        public bool showPrivacyStatement { get; set; }

        public bool showRemarks { get; set; }

        public bool showFindings { get; set; }

        public bool showCorrectiveAction { get; set; }

        public bool showSignatureFields { get; set; }
    }
}
