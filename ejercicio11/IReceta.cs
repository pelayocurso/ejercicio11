namespace ejercicio11
{
    public interface IReceta
    {
        Alimento alimento_uno { get; set; }
        Alimento alimento_dos { get; set; }

        bool ValidarAlimentos(Alimento alimento_uno, Alimento alimento_dos);
    }
}