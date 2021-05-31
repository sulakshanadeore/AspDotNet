using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ConnectedBAL;
using ConnectedDAL;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int AddNos(int no1, int no2)
        {
            return no1 + no2;
        }

        public bool InsertProduct(Product p)
        {
            bool status=false;
            ConnectedDAL.ProductsDAL dal = new ProductsDAL();
            ConnectedBAL.Products p1 = new Products();
           // p1.ProductID = p.ProductID;
            p1.ProductName = p.ProductName;
            p1.UnitPrice = p.ProductPrice;
            p1.QtyPerUnit = p.ProductQty;
            p1.CategoryID = 1;
            p1.SupplierID = 1;
            status=dal.InsertProduct(p1);
            //Dal Code
            return status;
        }

        public bool PayService(int amt)
        {
            bool status = true;
            //Dal Code
            return status;
            //throw new NotImplementedException();
        }
    }
}
