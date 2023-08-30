using SAARS.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAARS.ui.dialogs
{
    public partial class DocumentSettings : Form
    {

        public delegate void SaveBtnClickedEventHandler(object sender, string settings);
        public event SaveBtnClickedEventHandler SaveBtnClicked;

        public DocumentSettings()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string settingsString = $"{classChk.Checked}, {remarksChk.Checked}, {findingsChk.Checked}, {CAchk.Checked}, {signChk.Checked}, {privacyChk.Checked}";

            SaveBtnClicked.Invoke(this, settingsString);

            this.Close();
        }
    }
}
