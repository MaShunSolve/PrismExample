using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExample.Model
{
    public class Customer : BindableBase
    {
        protected LoadInput _loadinput = new LoadInput();
        public LoadInput LoadInput
        {
            get { return _loadinput; }
            set => SetProperty(ref _loadinput, value);
        }

        protected SaveInput _saveinput = new SaveInput();
        public SaveInput SaveInput
        {
            get { return _saveinput; }
            set => SetProperty(ref _saveinput, value);
        }
    }
    /// <summary>
    /// 載入輸入
    /// </summary>
    public class LoadInput
    {
        public int cust_id { get; set; }
    }
    /// <summary>
    /// 儲存輸入
    /// </summary>
    public class SaveInput:Rowid
    {
        private int _customerNo;
        public int cust_no
        {
            get { return _customerNo; }
            set => SetProperty(ref _customerNo, value);
        }

        private string? _custName;
        public string cust_name
        {
            get { return _custName; }
            set => SetProperty(ref _custName, value);
        }
        private string? _createDate;
        public string create_date
        {
            get { return _createDate; }
            set => SetProperty(ref _createDate, value);
        }
    }
}
