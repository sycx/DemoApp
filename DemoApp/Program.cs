using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var cn = new NormalFolder.ClassInNormalFolder();

            var cs = new SymlinkFolder.ClassInSymlinkFolder();
        }
    }
}
