namespace ejercicio11
{
    public interface IReceta
    {
        float peso_dos { get; set; }
        float peso_uno { get; set; }

        bool ValidarAlimentos(Alimento alimento_uno, Alimento alimento_dos);
    }
}