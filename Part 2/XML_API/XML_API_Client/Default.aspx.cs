using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

namespace XML_API_Client
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            verificationOutput.Visible = false;
            xpathOutput.Visible = false;
        }
        protected void verifyBtn_Click(object sender, EventArgs e)
        {
            string xmlUrl = xmlUrlInput.Text;
            string xsdUrl = xsdUrlInput.Text;

            string url = @"http://localhost:18136/Service1.svc/xmlVerification?xmlUrl=" + xmlUrl + "&xsdUrl=" + xsdUrl;
            string verifRes = readerResponse(url);
            verifRes = verifRes.Trim('"');

            resultsText.Text = verifRes;
            verificationOutput.Visible = true;
        }
        protected void tc1btn_Click(object sender, EventArgs e)
        {
            string hotelXMLpath = Server.MapPath("~/xmlDocs/Hotels.xml");
            string hotelXSDpath = Server.MapPath("~/xmlDocs/Hotels.xsd");

            xmlUrlInput.Text = hotelXMLpath;
            xsdUrlInput.Text = hotelXSDpath;

            verifyBtn_Click(sender, e);

        }
        protected void tc2btn_Click(object sender, EventArgs e)
        {
            string hotelXMLpath = Server.MapPath("~/xmlDocs/Hotels2.xml");
            string hotelXSDpath = Server.MapPath("~/xmlDocs/Hotels.xsd");

            xmlUrlInput.Text = hotelXMLpath;
            xsdUrlInput.Text = hotelXSDpath;

            verifyBtn_Click(sender, e);
        }
        protected void tc3btn_Click(object sender, EventArgs e)
        {
            string hotelXMLpath = Server.MapPath("~/xmlDocs/Hotels3.xml");
            string hotelXSDpath = Server.MapPath("~/xmlDocs/Hotels.xsd");

            xmlUrlInput.Text = hotelXMLpath;
            xsdUrlInput.Text = hotelXSDpath;

            verifyBtn_Click(sender, e);
        }
        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string xmlUrl = xmlSearchUrl.Text;
            string search = searchTerm.Text;

            string url = @"http://localhost:18136/Service1.svc/xmlXPathSearch?xmlUrl=" + xmlUrl +"&pathExpression=" + search;

            string searchRes = readerResponse(url);
            searchRes = searchRes.Trim('"');

            queryOutput.Text = searchRes;
            xpathOutput.Visible = true;
        }
        protected void searchTC1_Click(object sender, EventArgs e)
        {
            string hotelXMLpath = Server.MapPath("~/xmlDocs/Hotels.xml");
            string searchPath = "//Name";

            xmlSearchUrl.Text = hotelXMLpath;
            searchTerm.Text = searchPath;

            searchBtn_Click(sender, e);
        }
        protected void searchTC2_Click(object sender, EventArgs e)
        {
            string hotelXMLpath = Server.MapPath("~/xmlDocs/Hotels.xml");
            string searchPath = "//Phone";

            xmlSearchUrl.Text = hotelXMLpath;
            searchTerm.Text = searchPath;

            searchBtn_Click(sender, e);
        }
        protected void searchTC3_Click(object sender, EventArgs e)
        {
            string hotelXMLpath = Server.MapPath("~/xmlDocs/Hotels.xml");
            string searchPath = "/Hotels/Hotel[2]";

            xmlSearchUrl.Text = hotelXMLpath;
            searchTerm.Text = searchPath;

            searchBtn_Click(sender, e);
        }
        string readerResponse(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            return reader.ReadToEnd();
        }
    }
}