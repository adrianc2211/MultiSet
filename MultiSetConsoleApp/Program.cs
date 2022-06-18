using System;
using MultiSetLibrary;

namespace MultiSetConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiSet<char> m = new MultiSet<char>();
            m.Add('a');
            m.Add('a');
            m.Add('a');
            m.Add('b');
            m.Add('b');
            m.Add('c');
            m.ToString();
            
        }
    }
}
