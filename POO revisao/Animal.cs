using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_revisao
{
    internal class Animal
    {
        public double Peso { get; set; }
        public double Altura { get; set; }

       public Animal(double peso, double altura)
       {
            Peso = peso;
            Altura = altura;
       }

        public virtual void Barulho() //polimorfismo
        {
            Console.WriteLine("auauau");
        }

    }
}
