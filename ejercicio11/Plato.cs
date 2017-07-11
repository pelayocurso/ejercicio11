using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Plato
    {
        public IAlimento alimento_uno { get; set; }
        public IAlimento alimento_dos { get; set; }

        public Plato(IAlimento uno, IAlimento dos)
        {
            this.alimento_uno = uno;
            this.alimento_dos = dos;
        }
    }
}
