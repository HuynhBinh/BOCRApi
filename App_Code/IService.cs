using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


[ServiceContract]
public interface IService
{
    [OperationContract]
    [WebGet]
    string Hello();

    [OperationContract]
    [WebInvoke(Method = "POST", UriTemplate = "BOCR/Extract", ResponseFormat = WebMessageFormat.Json)]
    string ExtractText(Stream file);
}
