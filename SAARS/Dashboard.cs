using SAARS.components;
using SAARS.models;
using SAARS.requests;
using SAARS.ui;
using SAARS.ui.screens;
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
using System.Runtime.InteropServices;

namespace SAARS
{


    public partial class Dashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Dashboard()
        {
            InitializeComponent();
        }

        

        public void LoadGrid(string sortingFrom = "conducted_date")
        {
            QueryFunctions funcs = new QueryFunctions();
            ArrayList reports = funcs.GetReportModels();
            if (reports.Count > 0)
            {
                //BindingList<ReportModel> bindingList = CreateBindingList(reports);
                reports.Sort(new components.DateComparer(sortingFrom));
                reportsGrid.DataSource = null;
                reportsGrid.DataSource = reports;

                reportsGrid.Columns[0].HeaderText = "ID";
                reportsGrid.Columns[1].HeaderText = "Title";
                reportsGrid.Columns[2].HeaderText = "Description";
                reportsGrid.Columns[3].HeaderText = "Conducted Date";
                reportsGrid.Columns[4].HeaderText = "Reported Date";
                reportsGrid.Columns[5].HeaderText = "Conduct By";
                reportsGrid.Columns[6].Visible = false;
                reportsGrid.Columns[7].Visible = false;
                reportsGrid.Columns[8].Visible = false;
            }
        }

        private void ViewSelectedReport()
        {
            ReportModel model = new ReportModel();
            model.id = Int32.Parse(reportsGrid.CurrentRow.Cells[0].Value.ToString());
            model.title = reportsGrid.CurrentRow.Cells[1].Value.ToString();
            model.description = reportsGrid.CurrentRow.Cells[2].Value.ToString();
            model.conducted_date = reportsGrid.CurrentRow.Cells[3].Value.ToString();
            model.reported_date = reportsGrid.CurrentRow.Cells[4].Value.ToString();
            model.conducted_by = reportsGrid.CurrentRow.Cells[5].Value.ToString();
            model.report_data = reportsGrid.CurrentRow.Cells[6].Value.ToString();
            model.classification = reportsGrid.CurrentRow.Cells[7].Value.ToString();
            model.documentSettings = reportsGrid.CurrentRow.Cells[8].Value.ToString();
            
            GeneratePDFReport generator = new GeneratePDFReport(model);
            generator.GenerateReport();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void reportedDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGrid("reported_date");
        }

        private void conductedDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGrid("conducted_date");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reportsGrid.SelectedRows.Count > 0)
            {
                ArrayList rowIDs = new ArrayList();
                foreach (DataGridViewRow row in reportsGrid.SelectedRows)
                {
                    rowIDs.Add(Int32.Parse(row.Cells[0].Value.ToString()));
                }
                QueryFunctions funcs = new QueryFunctions();
                funcs.DeleteReports(rowIDs);
                LoadGrid();
            }
            else
            {
                MessageBox.Show("Please select which rows to delete, click the left side to select the entire row.", "Select Rows", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void assessmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAssessment creator = new CreateAssessment(this);
            creator.Show();
        }

        private void dashboardMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(reportsGrid.SelectedCells.Count > 0 && reportsGrid.SelectedRows.Count == 0)
            {
                ViewSelectedReport();                  
            }

            if(reportsGrid.SelectedRows.Count > 0) { 
                if(reportsGrid.SelectedRows.Count == 1)
                {
                    ViewSelectedReport();
                }
            }
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = SystemColors.ControlLight;
        }

        private void minimizeBtn_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.Red;
        }

        private void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = SystemColors.ControlLight;
        }

        private void reportsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
