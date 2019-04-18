using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace XML_API
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/xmlVerification?xmlUrl={xmlUrl}&xsdUrl={xsdUrl}")]

        string xmlVerification(string xmlUrl, string xsdUrl);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/xmlXPathSearch?xmlUrl={xmlUrl}&pathExpression={pathExpression}")]

        string xmlXPathSearch(string xmlUrl, string pathExpression);

    }
}
