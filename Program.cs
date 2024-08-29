using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ExtruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Converções - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else  - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If  - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch  - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura For Each - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                // Classes & Métodos
                {"Membros - Classes & Métodos", Membros.Executar},
                {"Construtores - Classes & Métodos", Construtores.Executar},
                {"Metodos com Retorno - Classes & Métodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes & Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes & Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes & Métodos", DesafioAtributo.Executar},
                {"Params - Classes & Métodos", Params.Executar},
                {"Parametros Nomeados - Classes & Métodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes & Métodos", GetSet.Executar},
                {"Propriedades - Classes & Métodos", Props.Executar},
                {"Atributo Readonly - Classes & Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes & Métodos", ExemploEnum.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
