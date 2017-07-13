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

       public override bool Equals(Object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            if (this.alimento_uno == null || ((Plato)obj).alimento_uno == null) {
                if (!(this.alimento_uno == null && ((Plato)obj).alimento_uno == null)) {
                    return false;
                }
            } else {
                if (!this.alimento_uno.Equals( ((Plato)obj).alimento_uno )) {
                    return false;
                }
            }


            if (this.alimento_dos == null || ((Plato)obj).alimento_dos == null) {
                if (!(this.alimento_dos == null && ((Plato)obj).alimento_dos == null)) {
                    return false;
                }
            } else {
                if (!this.alimento_dos.Equals(((Plato)obj).alimento_dos)) {
                    return false;
                }
            }

            return true;
            /*return ( (this.alimento_uno != null && ((Plato)obj).alimento_uno != null) &&
                    (this.alimento_dos != null && ((Plato)obj).alimento_dos != null) &&
                    this.alimento_uno.Equals( ((Plato)obj).alimento_uno ) &&
                    this.alimento_dos.Equals( ((Plato)obj).alimento_dos ));*/
        }
    }
}
