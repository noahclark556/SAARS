using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SAARS.access;
using SAARS.components;
using SAARS.models;

namespace SAARS.requests
{
    public class QueryFunctions
    {
        string ConnectionString = string.Empty;
        public QueryFunctions() { 
            DBConnector connector = new DBConnector();
            ConnectionString = connector.ConnectionString;
        }

        public string GetDateTimeStamp()
        {
            string date = DateTime.Now.ToString("MMM dd, yyyy");
            string time = DateTime.Now.ToString("h:mm tt");
            return $"{date} @ {time}";
        }

        public ArrayList GetReportModels()
        {
            ArrayList reportModels = new ArrayList();
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = $"SELECT * FROM [dbo].[{AccessVariables.companyName}]";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            ReportModel model = new ReportModel();
                            model.id = reader.GetInt32(0);
                            model.title = reader.GetString(1);
                            model.description = reader.GetString(2);
                            model.conducted_date = reader.GetString(3);
                            model.reported_date = reader.GetString(4);
                            model.conducted_by = reader.GetString(5);
                            model.report_data = reader.GetString(6);
                            model.classification = reader.GetString(7);
                            model.documentSettings = reader.GetString(8);
                            reportModels.Add(model);
                        }
                    }
                }
            }
            return reportModels;
        }

        public string BuildXml(NewAssessmentModel assessment)
        {
            string types = "";
            foreach (string type in assessment.assessment_types)
            {
                types += $"{type}, ";
            }
            types = types.Substring(0, types.Length - 2); // Remove space and comma at the end of string
            return $"<report>" +
                $"<type>{types}</type>" +
                $"<date>{assessment.conducted_date}</date>" +
                $"<scope>{assessment.scope}</scope>" +
                $"<findings>{assessment.findings}</findings>" +
                $"<correctiveAction>{assessment.corrective_action}</correctiveAction>" +
                $"<remarks>{assessment.remarks}</remarks>" +
                $"<classification>{assessment.classification}</classification>" +
                "</report>";
        }

        public void CreateAssessment(NewAssessmentModel assessment)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                 
                string sql = $"INSERT INTO [dbo].[{AccessVariables.companyName}] " +
                    $"(title, description, conducted_date, reported_date, conducted_by, report_data, classification, documentSettings) VALUES" +
                    $"('{assessment.title}', '{assessment.description}', '{assessment.conducted_date}', '{assessment.reported_date}'," +
                    $"'{AccessVariables.userID}', @assessXml, '{assessment.classification}', @serializedData)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@assessXml", BuildXml(assessment));
                    cmd.Parameters.AddWithValue("@serializedData", assessment.documentSettings);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteReports(ArrayList IDs)
        {
            string sql = $"DELETE FROM [dbo].[{AccessVariables.companyName}] WHERE id IN (";

            foreach (int id in IDs)
            {
                sql += id + ",";
            }
            sql = sql.Substring(0, sql.Length - 1);
            sql += ")";
            
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
