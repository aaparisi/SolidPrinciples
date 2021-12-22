using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid.SingleResponsability.Correcto
{
    class Coche
    {
        string marca;

        Coche(String marca) { this.marca = marca; }

        string getMarcaCoche() { return marca; }
    }
}
