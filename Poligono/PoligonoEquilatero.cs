using System;

namespace Poligono
{
    public abstract class PoligonoEquilatero
    {
        private readonly int NumeroLati;

        public PoligonoEquilatero(int numeroLati)
        {
            NumeroLati = numeroLati;
        }


        public int GetPerimetro(int lato) => Perimetro(lato);



        protected abstract int Perimetro(int lato);

        public int GetLati() => NumeroLati;

        public abstract string GetNomePoligono();


    }
}
