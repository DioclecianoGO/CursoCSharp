using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {
        int a = 10;
        public static void Executar() {
            // Acessar variável 'a' dentro do método Executar!
            DesafioAtributo letra = new DesafioAtributo();
            Console.WriteLine(letra.a);
        }
    }
}
