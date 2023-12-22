using PruebaTecnica.Models.Escalera;

namespace PruebaTecnica.Services
{
    public class EscaleraService : IEscaleraService
    {
        private readonly Dictionary<char, IEscalera> _Escaleras;

        public EscaleraService(Dictionary<char, IEscalera> Escaleras)
        {
            _Escaleras = Escaleras;
        }

        public string ObtenerEscalera(char EscaleraType, int n)
        {
            if (_Escaleras.TryGetValue(char.ToUpper(EscaleraType), out var Escalera))
            {
                return Escalera.ConstruirEscalera(n);
            }

            throw new ArgumentException("Tipo de escalera no válido");
        }
    }
}
