using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExample.Model
{
    public class Customer : BindableBase
    {
        private int _customerNo;
        public int cust_no
        {
            get { return _customerNo; }
            set => SetProperty(ref _customerNo, value);
        }
        
        private string _custName;
        public string cust_name 
        {
            get { return _custName; }
            set => SetProperty(ref _custName, value);
        }
    }
}
