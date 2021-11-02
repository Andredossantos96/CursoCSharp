using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedade autoimplmentada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // Lambda
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Eletrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
