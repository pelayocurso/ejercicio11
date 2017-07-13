using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class RecetaService : IReceta
    {
        public float peso_uno { get; set; }
        public float peso_dos { get; set; }

        public RecetaService() {
            this.peso_uno = 1;
            this.peso_dos = 1;
        }

        public RecetaService(float peso_uno, float peso_dos)
        {
            this.peso_uno = peso_uno;
            this.peso_dos = peso_dos;
        }

        private void RetirarExcedencias(Alimento alimento_uno, Alimento alimento_dos)
        {
            alimento_uno.peso = peso_uno;
            alimento_dos.peso = peso_dos;
        }

        public bool ValidarAlimentos(Alimento alimento_uno, Alimento alimento_dos)
        {
            if (alimento_uno != null && alimento_dos != null) {
                if ((alimento_uno.peso >= this.peso_uno && alimento_dos.peso >= this.peso_dos) &&
                    (!alimento_uno.cocinado && !alimento_dos.cocinado)) {
                    this.RetirarExcedencias(alimento_uno, alimento_dos);
                    return true;
                }
            }
            return false;
        }
    }
}
