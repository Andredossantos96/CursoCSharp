using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPontp {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse {
        public static void Executar() {
            SPontp ponto1 = new SPontp { X = 1, Y = 3 };
            SPontp copiaPonto1 = ponto1; // Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // Atribuição por REFERÊMCIA!!!
            ponto2.X = 4; 

            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", ponto2.X);


        }
    }
}
