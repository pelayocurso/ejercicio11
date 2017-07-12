using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Alimento
    {
        public float peso { get; set; }
        public bool cocinado { get; set; }

        public Alimento()
        {
            peso = 0;
            cocinado = false;
        }

        public Alimento(float peso, bool cocinado)
        {
            this.peso = peso;
            this.cocinado = cocinado;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            return (this.peso == ((Alimento)obj).peso &&
                    this.cocinado == ((Alimento)obj).cocinado);
        }
    }
}
