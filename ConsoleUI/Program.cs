using System;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // vi kan tilgå private protected metoder så længe de er den samme assembly/projekt
            AccessDemo demo1 = new AccessDemo();
            InheritFromAccessDemo demo2 = new InheritFromAccessDemo();
            demo1.PublicDemo();

            // MakeDemoCalls();

            demo2.PublicDemo
        }
    }
}
