// Program.cs
using PruebaTecnica.Models.Agentes;
using PruebaTecnica.Models.Escalera;
using PruebaTecnica.Services;

class Program
{
    static void Main()
    {
        // Inicializar diccionarios de Agentees y escaleras
        var Agentes = new Dictionary<char, IAgente>
        {
            {'A', new AgenteA()},
            {'B', new AgenteB()},
            {'C', new AgenteC()}
        };

        var Escaleras = new Dictionary<char, IEscalera>
        {
            {'A', new EscaleraA()},
            {'B', new EscaleraB()},
            {'C', new EscaleraC()}
        };

        // Inyectar dependencias
        var mediaService = new MediaService(Agentes);
        var escaleraService = new EscaleraService(Escaleras);

        // Utilizar servicios
        Console.WriteLine("Seleccione una funcionalidad:");
        Console.WriteLine("1. Obtener Media");
        Console.WriteLine("2. Escalera");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.WriteLine("Seleccione un agente para obtener la media (A, B, C):");
                char tipoAgente = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine("\nIngrese la lista de números separados por espacios:");
                List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                double resultadoMedia = mediaService.OtenerMedia(tipoAgente, numbers);
                Console.WriteLine($"Resultado: {resultadoMedia}");
                break;
            case 2:
                Console.WriteLine("Seleccione un tipo de escalera (A, B, C):");
                char tipoEscalera = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine("\nIngrese el tamaño de la escalera:");
                int n = int.Parse(Console.ReadLine());
                string resultadoEscalera = escaleraService.ObtenerEscalera(tipoEscalera, n);
                Console.WriteLine(resultadoEscalera);
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}
