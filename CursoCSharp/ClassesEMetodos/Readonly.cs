using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente("André Santos",
                new DateTime(1996, 7, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}
