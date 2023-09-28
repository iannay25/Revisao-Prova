using System;
using POO_revisao;
 class Heranca
{
    static void Main(string[] args)
    {

        Animal a = new Animal(1, 5);

        Cachorro c = new Cachorro( 5, 2,  "Vira-lata", "Flavio");
        Cachorro c2 = new Cachorro(5, 5, "pitbull", "Dobby");
        Cachorro c3 = new Cachorro(7, 8, "pincher", "Luffy");
        c.Barulho();


        Gato g = new Gato(1, 2, "Simba", "sianes");
        Gato g1 = new Gato(2, 1, "Molly", "malhado");
        g.Barulho();

        Console.WriteLine("nome: " + c.Nome + " "+ "altura: " + c.Altura+ " "+ c.Peso+ " "+ "raça: "+ c.Raca);
        Console.WriteLine("nome: " + g.Nome + " " + "altura: " + g.Altura + " " + g.Peso + " " + "raça: " + g.Raca);


        List<Cachorro> listCachorro = new List<Cachorro>();
        listCachorro.Add(c);
        listCachorro.Add(c2);
        listCachorro.Add(c3);

        List<Gato> listGato = new List<Gato>();
        listGato.Add(g);
        listGato.Add(g1);

        listCachorro = listCachorro.OrderBy(x => x.Nome).ToList(); //ordenar a lista
        List<Cachorro> listComPesoGrande = listCachorro.OrderBy(x => x.Peso > 40).ToList();

        foreach(Cachorro cf in listCachorro)
        {
            Console.WriteLine($"O nome do cachorro é {cf.Nome} da raca {cf.Raca}");
        }

    }

}