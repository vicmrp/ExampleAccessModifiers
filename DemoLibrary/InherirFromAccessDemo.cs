using System;

namespace DemoLibrary
{
    class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo(); // tillades igennem nedarvningen.
            InternalDemo(); // tillades under samme projekt/assembly
        }
    }
}