using System;
namespace DemoLibrary {
    class InheritanceDemo : AccessDemo
    {
        private void Demo()
        {
            ProtectedDemo();
            ProtectedInternalDemo(); // nedarves fra andre assembly, men kan tilgås public fra egen assembly
        }
    }
}