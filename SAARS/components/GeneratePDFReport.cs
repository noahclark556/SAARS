using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Azure;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SAARS.access;
using SAARS.models;
using SAARS.requests;

namespace SAARS.components
{
    public class GeneratePDFReport
    {
        PdfDocument pdfDocument;
        PdfPage page;
        XGraphics gfx;
        ReportModel report;
        XMLDataModel xmlDataModel;
        SettingsModel settings;

        XFont headerFont = new XFont("Roboto Thin", 20, XFontStyle.Regular);
        XFont subheadFont = new XFont("Roboto Thin", 12, XFontStyle.Regular);
        XFont bodyFont = new XFont("Roboto Thin", 12, XFontStyle.Regular, new XPdfFontOptions(PdfFontEncoding.Unicode));
        XFont bodyBold = new XFont("Roboto", 13, XFontStyle.Regular);

        int mdb = 0; // main down buffer
        int mlb = 0; // main left buffer
        int headerDB = 0;
        int introDB = 40;

        public SettingsModel ConvertToSettings(string settings)
        {
            string[] splitSettings = settings.Split(',');
            SettingsModel model = new SettingsModel();
            if (splitSettings[0].Trim() == "True")
            {
                model.showClassification = true;
            }
            else
            {
                model.showClassification = false;
            }
            if (splitSettings[1].Trim() == "True")
            {
                model.showRemarks = true;
            }
            else
            {
                model.showRemarks = false;
            }
            if (splitSettings[2].Trim() == "True")
            {
                model.showFindings = true;
            }
            else
            {
                model.showFindings = false;
            }
            if (splitSettings[3].Trim() == "True")
            {
                model.showCorrectiveAction = true;
            }
            else
            {
                model.showCorrectiveAction = false;
            }
            if (splitSettings[4].Trim() == "True")
            {
                model.showSignatureFields = true;
            }
            else
            {
                model.showSignatureFields = false;
            }
            if (splitSettings[5].Trim() == "True")
            {
                model.showPrivacyStatement = true;
            }
            else
            {
                model.showPrivacyStatement = false;
            }
            return model;
        }

        public GeneratePDFReport(ReportModel report)
        {
            pdfDocument = new PdfDocument();
            page = pdfDocument.AddPage();
            gfx = XGraphics.FromPdfPage(page);
            this.report = report;
            XMLParser parser = new XMLParser(report.report_data);
            xmlDataModel = parser.GetDataModel();
            settings = ConvertToSettings(report.documentSettings);
        }


        public void DrawClassification()
        {
            if (settings.showClassification)
            {
                gfx.DrawString($"{xmlDataModel.scope} / {report.classification}", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 10 + mdb, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"{xmlDataModel.scope} / {report.classification}", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, page.Height - 20 + mdb, page.Width, 50), XStringFormats.TopCenter);
            }
            else
            {
                gfx.DrawString($"{xmlDataModel.scope}", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 10 + mdb, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"{xmlDataModel.scope}", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, page.Height - 20 + mdb, page.Width, 50), XStringFormats.TopCenter);
            }
        }

        public void SaveReport()
        {
            string filename = "C:\\Users\\Noah\\Desktop\\training\\SAARS\\Report.pdf";
            pdfDocument.Save(filename);
            Process.Start(filename);
        }

        public string SwitchNewline(string data)
        {
            string returnString = "";
            foreach (char c in data)
            {
                if(c.ToString() == "\n")
                {
                    returnString += "";
                }
                else
                {
                    returnString += c.ToString();
                }
            }
            return returnString;
        }

        public void GenerateReport()
        {

            QueryFunctions funcs = new QueryFunctions();
            
            DrawClassification();

            gfx.DrawString($"Security Assessment", headerFont, XBrushes.Black,
            new XRect(0 + mlb, 50 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"{report.title}", subheadFont, XBrushes.Black,
            new XRect(0 + mlb, 80 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"{report.description}", bodyFont, XBrushes.Black,
            new XRect(0 + mlb, 120 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);



            gfx.DrawString($"This security assessment was conducted by", bodyFont, XBrushes.Black,
            new XRect(0 + mlb, 180 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"{report.conducted_by}", bodyBold, XBrushes.Black,
            new XRect(0 + mlb, 200 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"On the following date", bodyFont, XBrushes.Black,
            new XRect(0 + mlb, 225 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"{report.conducted_date}", bodyBold, XBrushes.Black,
            new XRect(0 + mlb, 245 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"And reported on", bodyFont, XBrushes.Black,
            new XRect(0 + mlb, 270 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"{report.reported_date}", bodyBold, XBrushes.Black,
            new XRect(0 + mlb, 290 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"With a deployment model of", bodyFont, XBrushes.Black,
            new XRect(0 + mlb, 315 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            gfx.DrawString($"{xmlDataModel.types}", bodyBold, XBrushes.Black,
            new XRect(0 + mlb, 335 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

            if (settings.showClassification)
            {

                gfx.DrawString($"This report is classified as", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 375 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"{report.classification}", bodyBold, XBrushes.Black,
                new XRect(0 + mlb, 395 + mdb + introDB, page.Width, 50), XStringFormats.TopCenter);
            }

            // Begin main loop

            for (int o = 0; o < 3; o++)
            {
                string title = "";
                string currentElement = "";
                int counter = 0;
                int loopBuffer = 0;
                string mainString = "";
                int fullCounter = 0;


                // Switch between pages

                switch (o)
                {
                    case 0:
                        title = "Findings";
                        currentElement = SwitchNewline(xmlDataModel.findings);
                        break;
                    case 1:
                        title = "Corrective Action";
                        currentElement = SwitchNewline(xmlDataModel.correctiveAction);
                        break;
                    case 2:
                        title = "Remarks";
                        currentElement = SwitchNewline(xmlDataModel.remarks);
                        break;
                }

                Debug.WriteLine($"FI {settings.showFindings} RE {settings.showRemarks} CA {settings.showCorrectiveAction}");

                if (title == "Findings")
                {
                    if (settings.showFindings == false)
                    {
                        continue;
                    }
                }
                else if (title == "Corrective Action")
                {
                    if (settings.showCorrectiveAction == false)
                    {
                        continue;
                    }
                }
                else if (title == "Remarks")
                {
                    if (settings.showRemarks == false)
                    {
                        continue;
                    }
                }

                // Page 
                page = pdfDocument.AddPage();
                gfx = XGraphics.FromPdfPage(page);

                // Draw classification

                DrawClassification();

                // ----

                // Title

                gfx.DrawString(title, headerFont, XBrushes.Black,
                new XRect(0 + mlb, 50 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);
                


                // Overflow and newline algorithm

                foreach (char i in currentElement)
                {


                    if (counter <= 85)
                    {
                        mainString += i.ToString();
                    }
                    else
                    {
                        gfx.DrawString($"{mainString}", bodyFont, XBrushes.Black,
                        new XRect(0 + mlb, 120 + mdb + loopBuffer, page.Width, 50), XStringFormats.TopCenter);
                        loopBuffer += 20;
                        counter = 0;
                        mainString = "";
                        mainString += i.ToString();
                    }

                    if (fullCounter >= 1700)
                    {
                        fullCounter = 0;
                        loopBuffer = 0;
                        page = pdfDocument.AddPage();
                        gfx = XGraphics.FromPdfPage(page);

                        DrawClassification();

                        gfx.DrawString(title, headerFont, XBrushes.Black,
                        new XRect(0 + mlb, 50 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);
                    }
                    counter += 1;
                    fullCounter += 1;
                }

                // Final placements

                gfx.DrawString($"{mainString}", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 120 + mdb + loopBuffer, page.Width, 50), XStringFormats.TopCenter);
                loopBuffer += 20;
                counter = 0;
                fullCounter = 0;
                mainString = "";
            }

            page = pdfDocument.AddPage();
            gfx = XGraphics.FromPdfPage(page);

            DrawClassification();

            if (settings.showPrivacyStatement)
            {

                gfx.DrawString($"Confidentiality Notice", headerFont, XBrushes.Black,
                new XRect(0 + mlb, 50 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"Unauthorized Distribution Prohibited", subheadFont, XBrushes.Black,
                new XRect(0 + mlb, 80 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"This report, including any attachments, is intended solely for the use of the individual or entity to whom", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 120 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"it is addressed and may contain confidential or privileged information. Any unauthorized review, use,", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 140 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"disclosure, or distribution is prohibited. If you have received this report in error, please immediately", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 160 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"notify the sender by email or phone and delete the report and any attachments from your system.", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 180 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);


                gfx.DrawString($"This report is protected by law, and any unauthorized dissemination, distribution, or copying of its", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 220 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"content is strictly prohibited and may result in legal action. The information contained in this report", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 240 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"is subject to strict confidentiality obligations and is intended solely for the recipient's use.", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 260 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);

                gfx.DrawString($"Thank you for your cooperation and adherence to these confidentiality requirements.", bodyFont, XBrushes.Black,
                new XRect(0 + mlb, 300 + mdb + headerDB, page.Width, 50), XStringFormats.TopCenter);
            }

            if (settings.showSignatureFields)
            {


                XPen sign1 = new XPen(XColors.Black, .2);
                gfx.DrawLine(sign1, 60, page.Height - 180, 170, page.Height - 180);

                gfx.DrawString($"Reportee Sign / Date", bodyFont, XBrushes.Black,
                new XRect(60, page.Height - 160, page.Width, 50), XStringFormats.TopLeft);


                XPen sign2 = new XPen(XColors.Black, .2);
                gfx.DrawLine(sign2, page.Width - 170, page.Height - 180, page.Width - 60, page.Height - 180);

                gfx.DrawString($"Reporter Sign / Date", bodyFont, XBrushes.Black,
                new XRect(page.Width - 170, page.Height - 160, page.Width, 50), XStringFormats.TopLeft);
            }

            gfx.DrawString($"Valid Report, SAARS Generated, {funcs.GetDateTimeStamp()}", bodyFont, XBrushes.Black,
            new XRect(0, page.Height - 80, page.Width, 50), XStringFormats.BottomCenter);

            SaveReport();

            
        }
    }
}
