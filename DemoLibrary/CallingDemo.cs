using System;

namespace DemoLibrary
{
    public class PublicDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();
            demo.InternalDemo();
        }
    }   
}