using System.Text;

namespace PruebaTecnica.Models.Escalera
{
    public class EscaleraB : IEscalera
    {
        public string ConstruirEscalera(int n)
        {
            if (n <= 0 || n >= 100)
                throw new ArgumentException("El tamaño de la escalera debe estar entre 0 y 100.");

            StringBuilder escalera = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                string simbolos = new string('#', i);
                string espacios = new string(' ', n - i);
                escalera.AppendLine(espacios + simbolos);
            }

            return escalera.ToString();
        }
    }
}