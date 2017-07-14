using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Receta : IReceta
    {
        public float peso_uno { get; set; }
        public float peso_dos { get; set; }

        public Alimento alimento_uno { get; set; }
        public Alimento alimento_dos{ get; set; }

        public Receta() {
            this.alimento_uno = new Alimento("chope", 1, false);
            this.alimento_dos = new Alimento("mortadela", 1, false);
        }

        public Receta(Alimento alimento_uno, Alimento alimento_dos)
        {
            this.alimento_uno = alimento_uno;
            this.alimento_dos = alimento_dos;
        }

        private void RetirarExcedencias(Alimento alimento_uno, Alimento alimento_dos)
        {
            alimento_uno.peso = alimento_uno.peso;
            alimento_dos.peso = alimento_dos.peso;
        }

        public bool ValidarAlimentos(Alimento alimento_uno, Alimento alimento_dos)
        {
            if (alimento_uno != null && alimento_dos != null) {
                if ((alimento_uno.nombre.Equals(this.alimento_uno.nombre) && alimento_dos.nombre.Equals(this.alimento_dos.nombre)) &&
                    (alimento_uno.peso >= this.alimento_uno.peso && alimento_dos.peso >= this.alimento_dos.peso) &&
                    (!alimento_uno.cocinado && !alimento_dos.cocinado)) {
                    this.RetirarExcedencias(alimento_uno, alimento_dos);
                    return true;
                }
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            return (this.alimento_uno.Equals(((Receta)obj).alimento_uno)
                    && this.alimento_uno.Equals(((Receta)obj).alimento_uno));
        }
    }
}
