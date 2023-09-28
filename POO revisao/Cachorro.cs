using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_revisao
{
    internal class Cachorro : Animal
    {
        public string Raca { get; set; }
        public string Nome { get; set; }

        public Cachorro(double peso, double altura, string raca, string nome) : base (peso,altura)
        {
            Raca = raca;
            Nome = nome;
        }
    }
}
