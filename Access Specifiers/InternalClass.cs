using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Access_Specifiers
{
    internal class InternalClass: PublicClass
    {
        public string name;
        private int age;
        internal string gender;
        protected string height;
        private protected int accNo;
        protected internal int netWorth;

        InternalClass ic = new InternalClass();
        PublicClass pc = new PublicClass();

        InternalClass()     //Constructor can have all these specifiers.
        {
            InternalClass ic1 = new InternalClass();
            
        }
        public void PublicMethod()
        {
            InternalClass ic2 = new InternalClass();
            ic.InternalMethod();
            ic.PrivateMethod();
            ic.PrivateProtectedMethod();
            ic.ProtectedMethod();
            ic.ProtectedInternalMethod();
            ic.PublicMethod();


        }
        private void PrivateMethod()
        {
            InternalClass ic3 = new InternalClass();
            ic.InternalMethod();
            ic.PrivateMethod();
            ic.PrivateProtectedMethod();
            ic.ProtectedMethod();
            ic.ProtectedInternalMethod();
            ic.PublicMethod();


        }
        internal void InternalMethod()
        {
            InternalClass ic4 = new InternalClass();
            ic.InternalMethod();
            ic.PrivateMethod();
            ic.PrivateProtectedMethod();
            ic.ProtectedMethod();
            ic.ProtectedInternalMethod();
            ic.PublicMethod();


        }
        protected void ProtectedMethod()
        {
            InternalClass ic5 = new InternalClass();
            ic.InternalMethod();
            ic.PrivateMethod();
            ic.PrivateProtectedMethod();
            ic.ProtectedMethod();
            ic.ProtectedInternalMethod();
            ic.PublicMethod();
        }
        private protected void PrivateProtectedMethod()
        {
            InternalClass ic6 = new InternalClass();
            ic.InternalMethod();
            ic.PrivateMethod();
            ic.PrivateProtectedMethod();
            ic.ProtectedMethod();
            ic.ProtectedInternalMethod();
            ic.PublicMethod();
        }
        protected internal void ProtectedInternalMethod()
        {
            InternalClass ic7 = new InternalClass();
            ic.InternalMethod();
            ic.PrivateMethod();
            ic.PrivateProtectedMethod();
            ic.ProtectedMethod();
            ic.ProtectedInternalMethod();
            ic.PublicMethod();
        }
    }
}
