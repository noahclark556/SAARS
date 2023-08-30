using SAARS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SAARS.components
{
    public class XMLParser
    {
        XmlDocument mainDoc = new XmlDocument();
        public XMLParser(string data)
        {
            mainDoc.LoadXml(data);
        }

        public XMLDataModel GetDataModel()
        {
            XMLDataModel model = new XMLDataModel();
            foreach (XmlNode item in mainDoc.ChildNodes)
            {
               
                    model.types = item.SelectSingleNode("type").InnerText;
                    model.date = item.SelectSingleNode("date").InnerText;
                    model.findings = item.SelectSingleNode("findings").InnerText;
                    model.correctiveAction = item.SelectSingleNode("correctiveAction").InnerText;
                    model.remarks = item.SelectSingleNode("remarks").InnerText;
                    model.classification = item.SelectSingleNode("classification").InnerText;
                    model.scope = item.SelectSingleNode("scope").InnerText;
                
            }
            return model;
        }
    }
}
