namespace ejercicio11
{
    public interface IRepository
    {
        void Create(IReceta receta);
        void Delete(int index);
        IReceta Read(int index);
        void Update(int index, Alimento alimento_uno, Alimento alimento_dos);
    }
}