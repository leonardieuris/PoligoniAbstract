using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligono
{
    public class Triangolo : PoligonoEquilatero
    {
        public Triangolo() : base(3)
        {

        }

        public override string GetNomePoligono() => "Triangolo";

        protected override int Perimetro(int lato)
        {

            return 3 * lato;
        }
    }
}
