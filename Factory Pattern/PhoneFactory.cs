using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Factory_Pattern
{
    public class PhoneFactory
    {
        public Phone makePhone(String phoneType)
        {
            if (phoneType.Equals("MiPhone"))
            {
                return new MiPhone();
            }
            else if (phoneType.Equals("iPhone"))
            {
                return new IPhone();
            }
            return null;
        }
    }
}
