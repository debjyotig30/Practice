using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Access_Specifiers
{
    public class PublicClass
    {
        public string name;
        private int age;
        internal string gender;
        protected string height;
        private protected int accNo;
        protected internal int netWorth;


        public PublicClass()
        {
            
        }
        public void PublicMethod()
        {
            //InternalClass IC = new InternalClass(); not possible

            


        }
        private void PrivateMethod()
        {

        }
        internal void InternalMethod()
        {

        }
        protected void ProtectedMethod()
        {

        }
        private protected void PrivateProtectedMethod()
        {

        }
        protected internal void ProtectedInternalMethod()
        {

        }
    }
}
