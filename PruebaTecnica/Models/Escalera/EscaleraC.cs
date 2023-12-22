using System.Text;

namespace PruebaTecnica.Models.Escalera
{
    public class EscaleraC : IEscalera
    {
        public string ConstruirEscalera(int n)
        {
            if (n <= 0 || n >= 100)
                throw new ArgumentException("El tamaño de la escalera debe estar entre 0 y 100.");

            StringBuilder escalera = new StringBuilder();
            int mitad = n / 2;

            for (int i = 1; i <= n; i++)
            {
                string simbolos = new string('#', i);

                if (i == n)
                {
                    // Última línea, centrada
                    escalera.AppendLine(simbolos.PadLeft(mitad + i));
                }
                else if (i <= mitad)
                {
                    // Parte superior
                    string espacios = new string(' ', mitad + i - 1);
                    escalera.AppendLine(espacios + simbolos);
                }
                else
                {
                    // Parte inferior
                    string espacios = new string(' ', mitad * 2);
                    escalera.AppendLine(espacios + simbolos);
                }
            }

            return escalera.ToString();
        }
    }
}