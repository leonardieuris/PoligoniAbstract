using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligono
{
    public class Quadrato : PoligonoEquilatero
    {
        public Quadrato() : base(4)
        {

        }
        public override string GetNomePoligono()
        {
            return "Quadrato";
        }

        protected override int Perimetro(int lato)
        {
            return 4 * lato;
        }
    }
}
