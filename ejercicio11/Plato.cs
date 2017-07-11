using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Plato
    {
        public Alimento alimento_uno { get; set; }
        public Alimento alimento_dos { get; set; }

        public Plato(Alimento uno, Alimento dos)
        {
            this.alimento_uno = uno;
            this.alimento_dos = dos;
        }
    }
}
