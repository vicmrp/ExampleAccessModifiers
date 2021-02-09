using System;

namespace DemoLibrary
{
    public class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo(); // tillades igennem nedarvningen.
            InternalDemo(); // tillades under samme projekt/assembly
            PrivateProtectedDemo(); // kun tillat fra egen klasse eller fra klassen som nedarver
            ProtectedInternalDemo(); // nedarves fra andre assembly, men kan tilgås public fra egen assembly
        }
    }
}