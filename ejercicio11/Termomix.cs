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

        public Alimento alimento_uno { get; set; }
        public Alimento alimento_dos { get; set; }

        public ICocina cocina { private get; set; }
        public IPeso peso { private get; set; }
        public IReceta receta { private get; set; }

        private Termomix() {
            this.cocina = new CocinaService();
            this.peso = new PesoService();
            this.receta = new RecetaService();
        }

        private Termomix(ICocina cocina, IPeso peso, IReceta receta)
        {
            this.cocina = cocina;
            this.peso = peso;
            this.receta = receta;
        }

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

        public float Pesar(Alimento alimento)
        {
            if (alimento_uno == null) {
                alimento_uno = alimento;
            } else {
                alimento_dos = alimento;
            }

            return peso.Pesar(alimento);
        }

        public Plato Cocinar(Alimento alimento1, Alimento alimento2)
        {
            cocina.Cocinar(alimento1, alimento2);
            return new Plato(alimento1, alimento2);
        }

        public bool Validar(Alimento alimento1, Alimento alimento2)
        {
            return receta.ValidarAlimentos(alimento1, alimento2);
        }

        public Plato ValidarYCocinar(Alimento alimento1, Alimento alimento2)
        {
            if (Validar(alimento1, alimento2))
            {
                return Cocinar(alimento1, alimento2);
            }
            else
            {
                return null;
            }
        }

        public Plato PesarYCocinar(Alimento alimento1, Alimento alimento2)
        {
            Pesar(alimento1);
            Pesar(alimento2);
            return Cocinar(alimento1, alimento2);
        }
    }
}
