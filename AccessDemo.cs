using System;

namespace DemoLibrary
{
    public class AccessDemo 
    {
        private void Demo()
        {
            PrivateDemo();
        }
        private void PrivateDemo()
        {

        }
        private protected void PrivateProtectedDemo()
        {
            System.Console.WriteLine("PrivateProtectedDemo");
        }
        protected void ProtectedDemo()
        {
            System.Console.WriteLine("ProtectedDemo");
        }
        protected internal void ProtectedInternalDemo()
        {
            System.Console.WriteLine("ProtectedInternalDemo");
        }
        internal void InternalDemo()
        {
            System.Console.WriteLine("InternalDemo");
        }
        public void PublicDemo()
        {
            System.Console.WriteLine("PublicDemo");
        }
    }
}