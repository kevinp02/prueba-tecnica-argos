namespace PruebaTecnica.Models.Agentes
{
    public class AgenteA : IAgente
    {
        public double Operacion(List<double> numeros)
        {
            if (numeros.Count == 0)
                throw new ArgumentException("La lista de números no puede estar vacía");

            return numeros.Sum() / numeros.Count;
        }
    }
}
