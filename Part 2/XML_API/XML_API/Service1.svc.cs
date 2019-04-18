using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Schema;
using System.Xml;

namespace XML_API
{
    
    public class Service1 : IService1
    {
        string validationResponse = "";

        public string xmlVerification(string xmlUrl, string xsdUrl)
        {
            XmlReaderSettings sets = new XmlReaderSettings();
            sets.ValidationType = ValidationType.Schema;
            sets.Schemas.Add(null, xsdUrl);
            sets.ValidationEventHandler += new ValidationEventHandler(validate);
            XmlReader xmlDoc = XmlReader.Create(xmlUrl, sets);

            while (xmlDoc.Read()) ;

            if (validationResponse == "")
            {
                validationResponse = "<h4>XML Validation Successful. No errors found.";
            }
            else
            {
                validationResponse = "<h4>XML document contains the following errors: <br /><pre>" + validationResponse;
            }

            return validationResponse;
        }

        public string xmlXPathSearch(string xmlUrl, string pathExpression)
        {

            return "";
        }

        void validate(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                validationResponse += "<br />Warning: " + e.Message;
            }
            else
            {
                validationResponse += "<br />Error Message: " + e.Message;
            }
        }
    }
}
