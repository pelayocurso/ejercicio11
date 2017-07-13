using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class Alimento
    {
        public string nombre { get; set; }
        public float peso { get; set; }
        public bool cocinado { get; set; }

        public Alimento()
        {
            nombre = "chope";
            peso = 0;
            cocinado = false;
        }

        public Alimento(string nombre, float peso, bool cocinado)
        {
            this.nombre = nombre;
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
                    this.cocinado == ((Alimento)obj).cocinado) &&
                    this.nombre == ((Alimento)obj).nombre;
        }
    }
}
