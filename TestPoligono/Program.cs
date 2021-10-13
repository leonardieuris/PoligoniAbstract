using System;
using System.Collections.Generic;
using Poligono;

namespace TestPoligono
{
    class Program
    {
        static void Main(string[] args)
        {
            PoligonoEquilatero sonounquadrato = new Quadrato();
            PoligonoEquilatero sonountriangolo = new Triangolo();
            Quadrato sonounaltroquadrato = new Quadrato();
            Triangolo sonounaltrotriangolo = new Triangolo();
            var ancoraunquadrato = new Quadrato();
            var ancorauntriangolo = new Triangolo();

            var codaPoligoni = new Queue<PoligonoEquilatero>();

            codaPoligoni.Enqueue(sonounquadrato);
            codaPoligoni.Enqueue(sonountriangolo);
            codaPoligoni.Enqueue(sonounaltroquadrato);
            codaPoligoni.Enqueue(sonounaltrotriangolo);
            codaPoligoni.Enqueue(ancoraunquadrato);
            codaPoligoni.Enqueue(ancorauntriangolo);

            Print(codaPoligoni);
            Console.ReadLine();
        }


        private static void Print(Queue<PoligonoEquilatero> coda)
        {
            while (coda.Count > 0)
            {
                var miopoligono = coda.Dequeue();
                var lunghezzalato = new Random().Next(1, 100);
                var lati = miopoligono.GetLati();
                var perimetro = miopoligono.GetPerimetro(lunghezzalato);

                Console.WriteLine($"Sono un Poligono con {lati} lati quindi sono un {miopoligono.GetNomePoligono()} il mio perimetro è: {perimetro}");
            }
        }
    }
}
