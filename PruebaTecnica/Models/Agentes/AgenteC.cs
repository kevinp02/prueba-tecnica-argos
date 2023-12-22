namespace PruebaTecnica.Models.Agentes
{
    public class AgenteC : IAgente
    {
        public double Operacion(List<double> numeros)
        {
            if (numeros.Count == 0)
                throw new ArgumentException("La lista de números no puede estar vacía");

            List<double> sortednumeros = numeros.OrderBy(x => x).ToList();
            int middleIndex = numeros.Count / 2;

            if (numeros.Count % 2 == 0)
            {
                // Cantidad de datos par
                double middle1 = sortednumeros[middleIndex - 1];
                double middle2 = sortednumeros[middleIndex];
                return (middle1 + middle2) / 2;
            }
            else
            {
                // Cantidad de datos impar
                return sortednumeros[middleIndex];
            }
        }
    }
}