using System;
using System.Collections.Generic;
using System.Linq;

using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //[OperationContract]
        //string GetData(int value);
        //[OperationContract]
        //int AddNos(int i, int j);

        [OperationContract]
        [WebGet(UriTemplate = "CustomersJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Customer GetDataUsingDataContract();

        [OperationContract]
        [WebGet(UriTemplate = "CustomersXml", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml)]
        Customer GetDataUsingDataContractXML();


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Customer
    {
        
        string custName = "Hello ";
        [DataMember]
        public string CustName { get; set; }
    }
}
