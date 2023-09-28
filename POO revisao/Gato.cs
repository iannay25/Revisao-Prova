using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_revisao
{
    internal class Gato : Animal
    {
        public string Raca { get; set; }
        public string Nome { get; set; }

        public Gato(double peso, double altura, string nome,string raca) : base(peso,altura)
        {
            Raca = raca;
            Nome = nome;
        }

        public override void Barulho()
        {
            Console.WriteLine("Miauuuuu");
        }
    
    }
}
