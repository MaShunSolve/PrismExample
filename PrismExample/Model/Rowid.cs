using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace PrismExample.Model
{
    public class Rowid : BindableBase
    {
        public string kbsid { get; set; }
        public string action_type { get; set; }
    }
}
