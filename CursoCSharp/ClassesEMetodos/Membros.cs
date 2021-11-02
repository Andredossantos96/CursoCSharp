using System;


namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "André";
            sicrano.Idade = 25;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();


            var fulano = new Pessoa();
            fulano.Nome = "Diego";
            fulano.Idade = 24;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);

        }
    }
}
