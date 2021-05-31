using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int AddNos(int no1, int no2);

        [OperationContract]
        bool PayService(int amt);

        [OperationContract]
        bool InsertProduct(Product p);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Product
    {
        private int ProdID;

        [DataMember]
        public int ProductID
        {
            get { return ProdID; }
            set { ProdID = value; }
        }


        private string ProdName;
        [DataMember]
        public string ProductName
        {
            get { return ProdName; }
            set { ProdName = value; }
        }

        private int Price;
        [DataMember]
        public int ProductPrice
        {
            get { return Price; }
            set { Price = value; }
        }

        private string Qty;
        [DataMember]
        public string ProductQty
        {
            get { return Qty; }
            set { Qty = value; }
        }






    }
}
