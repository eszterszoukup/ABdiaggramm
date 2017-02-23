using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
    public class B : A
    {
        protected void S4()
        {
            Console.WriteLine("B :: S4");
            V1();
        }

        public void S5()
        {
            Console.WriteLine("B :: S5");
            S3();
        }

        protected void S3()
        {
            throw new System.NotImplementedException();
        }

        public virtual void V2()
        {

            Console.WriteLine("B :: V2");
            V1();

        }

       protected virtual void V1()
        {
            Console.WriteLine("B :: V1");
            S5();
        }
    }
}