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
        public List<SaveInput> GetAll()
        {
            List<SaveInput> lst = new List<SaveInput>();
            SaveInput a = new SaveInput() { cust_no = 1, cust_name = "客戶A", create_date = "20240317" };
            SaveInput b = new SaveInput() { cust_no = 2, cust_name = "客戶B", create_date = "20240318" };
            SaveInput c = new SaveInput() { cust_no = 3, cust_name = "客戶C", create_date = "20240319" };
            lst.Add(a);
            lst.Add(b);
            lst.Add(c);
            
            return lst;
        }
    }
}
