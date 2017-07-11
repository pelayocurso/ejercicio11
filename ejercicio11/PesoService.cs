using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class PesoService : IPeso
    {
        public float Pesar(Alimento alimento)
        {
            return alimento.peso;
        } 
    }
}
