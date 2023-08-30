using SAARS.components;
using SAARS.models;
using SAARS.requests;
using SAARS.ui.dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAARS.ui.screens
{
    public partial class CreateAssessment : Form
    {
        Dashboard dash;
        string settings;
        public CreateAssessment(Dashboard dash)
        {
            InitializeComponent();
            this.dash = dash;
        }

        private void CreateAssessment_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            TextDialog textDialog = new TextDialog(findingsBox.Text, "Findings");
            textDialog.ValueSubmitted += TextDialog_ValueSubmitted;

            textDialog.ShowDialog();
        }

        private void TextDialog_ValueSubmitted(string value)
        {
            findingsBox.Text = value;
        }

        private void TextDialog_CA_ValueSubmitted(string value)
        {
            caTxtBox.Text = value;
        }

        private void TextDialog_RE_ValueSubmitted(string value)
        {
            remarksTxtBox.Text = value;
        }

        private void caTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextDialog textDialog = new TextDialog(caTxtBox.Text, "Corrective Action");
            textDialog.ValueSubmitted += TextDialog_CA_ValueSubmitted;

            textDialog.ShowDialog();
        }

        private void remarksTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextDialog textDialog = new TextDialog(remarksTxtBox.Text, "Remarks");
            textDialog.ValueSubmitted += TextDialog_RE_ValueSubmitted;

            textDialog.ShowDialog();
        }

        private string GetClassification()
        {
            if(unclass.Checked)
            {
                return "Unclassified";
            }else if(controlled.Checked)
            {
                return "Controlled Unclassified";
            }else if (confidential.Checked)
            {
                return "Confidential";
            }else if(secret.Checked)
            {
                return "Secret";
            }else if(topSecret.Checked)
            {
                return "Top Secret";
            }
            return "None";
        }

        private ArrayList GetAssessmentTypes()
        {
            ArrayList types = new ArrayList();
            if(onPremise.Checked)
            {
                types.Add("On Premise");
            }
            if(inCloud.Checked)
            {
                types.Add("In Cloud");
            }
            if (remoteChk.Checked)
            {
                types.Add("Remote");
            }
            return types;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            NewAssessmentModel assessmentModel = new NewAssessmentModel();
            assessmentModel.title = titleTxtBox.Text;
            assessmentModel.description = descTxtBox.Text;
            assessmentModel.conducted_date = StandardFunctions.ConvertDateStamp(conductedPicker.Text);
            assessmentModel.reported_date = StandardFunctions.ConvertDateStamp(reportedPicker.Text);
            assessmentModel.findings = findingsBox.Text;
            assessmentModel.corrective_action = caTxtBox.Text;
            assessmentModel.remarks = remarksTxtBox.Text;
            assessmentModel.scope = scopeSelect.Text;
            assessmentModel.classification = GetClassification();
            assessmentModel.assessment_types = GetAssessmentTypes();
            assessmentModel.documentSettings = settings;
            QueryFunctions funcs = new QueryFunctions();
            funcs.CreateAssessment(assessmentModel);
            dash.LoadGrid();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentSettings settingsDialog = new DocumentSettings();
            settingsDialog.SaveBtnClicked += DocumentSettings_SaveBtnClicked;

            settingsDialog.ShowDialog();
        }

        private void DocumentSettings_SaveBtnClicked(object sender, string settings)
        {
            this.settings = settings;
        }
    }
}