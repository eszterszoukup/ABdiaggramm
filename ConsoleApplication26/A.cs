using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication26
{
    public class A
    {
        public void S1()
        {
            Console.WriteLine("A :: S1");
            V1();
        }

        private void S3()
        {
            Console.WriteLine("A :: S3"); 
            S1();
        }

        public void S2()
        {
            throw new System.NotImplementedException();
        }

        protected virtual void V1()
        {
            Console.WriteLine("A :: V1");
            S3();
        }
    }
}