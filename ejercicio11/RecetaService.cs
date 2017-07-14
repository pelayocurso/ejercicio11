using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    public class RecetaService : IRecetaService
    {
        private IRepository repositorio;

        public RecetaService()
        {
            this.repositorio = new RecetaRepository();
        }

        public RecetaService(IRepository repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Guardar(IReceta receta)
        {
            repositorio.Create(receta);
        }

        public IReceta Obtener(int index)
        {
            return repositorio.Read(index);
        }

        public void Remover(int index)
        {
            repositorio.Delete(index);
        }

        public void Actualizar(int index, Alimento uno, Alimento dos)
        {
            repositorio.Update(index, uno, dos);
        }
    }
}
