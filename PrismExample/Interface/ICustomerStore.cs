using PrismExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExample.Interface
{
    public interface ICustomerStore
    {
        List<Customer> GetAll();
    }
}
