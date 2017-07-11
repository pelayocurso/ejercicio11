using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Termomix
    {
        private static Termomix instance;

        public IAlimento alimento_uno { get; set; }
        public IAlimento alimento_dos { get; set; }

        private Termomix() {}

        public static Termomix Instance
        {
            get
            {
                if (instance == null) {
                    instance = new Termomix();
                }
                return instance;
            }
        }

        public double Pesar(IAlimento alimento)
        {
            if (alimento_uno == null) {
                alimento_uno = alimento;
            } else {
                alimento_dos = alimento;
            }

            return alimento.peso;
        }

        public Plato Cocinar(IAlimento alimento1, IAlimento alimento2)
        {
            return new Plato(alimento1, alimento2);
        }

        public Plato PesarYCocinar(IAlimento alimento1, IAlimento alimento2)
        {
            Pesar(alimento1);
            Pesar(alimento2);
            return Cocinar(alimento1, alimento1);
        }
    }
}
