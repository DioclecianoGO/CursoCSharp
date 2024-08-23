using System;

namespace CursoCSharp {
    class Program {
        static void Main(String[] args) {
            Console.WriteLine("Hello, World!");
            {
                Console.WriteLine("Hello, World2!");
                {
                    Console.WriteLine("Testando");
                }
            }
        }
    }
}