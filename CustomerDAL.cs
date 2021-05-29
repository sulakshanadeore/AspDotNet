using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindLibBAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace NorthwindDAL
{
    public class CustomerDAL
    {
        public void AddCustomer(CustomerBAL customer)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwcnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("InsertCustomerRecord", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@p_custid", customer.CustID);
            cmd.Parameters.AddWithValue("@p_custname", customer.CustName);
            cmd.Parameters.AddWithValue("@p_city", customer.CustCity);
            cmd.ExecuteNonQuery();
            //Alos handle transactions here
            cn.Close();

        }

        public List<CustomerBAL> GetCustomers()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwcnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from customers",cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
          
            List<CustomerBAL> customers = new List<CustomerBAL>();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CustomerBAL customer = new CustomerBAL();
                customer.CustID = dt.Rows[i][0].ToString();
                customer.CustName = dt.Rows[i][1].ToString();
                customer.CustCity = dt.Rows[i][5].ToString();
                customers.Add(customer);
            }

            cn.Close();
            return customers;
        }

        public CustomerBAL GetCustomers(string  custid)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwcnString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from customers where customerid like '" + custid + "'",cn);
            cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            CustomerBAL customer = new CustomerBAL();
            if (dr.HasRows)
            {
                dr.Read();
                customer.CustID = dr["CustomerID"].ToString();
                customer.CustName = dr["CompanyName"].ToString();
                customer.CustCity = dr["City"].ToString();

            }
            
            cn.Close();
            return customer;


        }

    }
}
