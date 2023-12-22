namespace PruebaTecnica.Models.Agentes
{
    public class AgenteB : IAgente
    {
        public double Operacion(List<double> numeros)
        {
            if (numeros.Count == 0)
                throw new ArgumentException("La lista de números no puede estar vacía");

            return numeros.Count / numeros.Sum(x => 1 / x);
        }
    }
}
