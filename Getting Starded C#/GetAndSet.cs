using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Starded_C_
{
    public class GetAndSet
    {
        private string _name = "Jobe";

        public string MutableName 
        { 
            get { return _name; } 
            set { _name = value; }
        }
    }
}
