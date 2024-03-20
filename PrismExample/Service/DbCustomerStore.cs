using PrismExample.Interface;
using PrismExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExample.Service
{
    public class DbCustomerStore : ICustomerStore
    {
        /// <summary>
        /// 取資料
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetAll()
        {
            List<Customer> lst = new List<Customer>();
            Customer a = new Customer() { cust_no = 1, cust_name = "客戶A"};
            Customer b = new Customer() { cust_no = 2, cust_name = "客戶B"};
            Customer c = new Customer() { cust_no = 3, cust_name = "客戶C"};
            lst.Add(a);
            lst.Add(b);
            lst.Add(c);
            
            return lst;
        }
    }
}
