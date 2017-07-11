using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class CocinaService : ICocina
    {
        public void Cocinar(Alimento alimento_uno, Alimento alimento_dos)
        {
            alimento_uno.cocinado = true;
            alimento_dos.cocinado = true;
        }
    }
}
