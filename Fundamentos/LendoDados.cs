using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {

        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // CultureInfo para mim, quando aplicado a (,) é ignorada e coloca tudo junto os numeros. Já o (.), vira virgula, caso seja zeros, ele nao apresenta os decimais. Sem o CultureInfo, é o inverso. Talvez essa seja uma solução para usar tanto (.) quanto (,):
            //
            //    class Program {
            //          static void Main(string[] args) {
            //
            //              Console.WriteLine("Digite o número:");
            //              float real = converter(Console.ReadLine());
            //
            //              Console.WriteLine(real + 5);
            //          }
            //
            //          static float converter(string valor) {
            //              var temp = valor.Replace(".", ",");
            //              return float.Parse(temp);
            //          }
            //     }

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
