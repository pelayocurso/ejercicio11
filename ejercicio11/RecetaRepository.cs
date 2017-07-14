using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class RecetaRepository : IRepository
    {
        private List<IReceta> recetario;
        
        public RecetaRepository() {
            this.recetario = new List<IReceta>();
        }

        public void Create (IReceta receta)
        {
            recetario.Add(receta);
        }

        public IReceta Read (int index)
        {
            return recetario.ElementAt(index);
        }

        public void Update (int index, Alimento alimento_uno, Alimento alimento_dos)
        {
            recetario.ElementAt(index).alimento_uno = alimento_uno;
            recetario.ElementAt(index).alimento_dos = alimento_dos;
        }

        public void Delete (int index)
        {
            recetario.RemoveAt(index);
        }
    }
}
