using System;
using Nemetos.Project.Library;

namespace Nemetos.Project.ConsoleApplication
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine(new NemetosClass().ToString());
        }
    }
}
