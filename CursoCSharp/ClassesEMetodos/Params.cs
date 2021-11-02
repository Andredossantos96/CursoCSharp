using System;

namespace CursoCSharp.ClassesEMetodos {
    class Params {
        public static void Recepcionar(params string[] pessoas) {
            foreach (var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar() {
            Recepcionar("Pedro", "André", "José", "Ana", "Paula");
        }
    }
}
