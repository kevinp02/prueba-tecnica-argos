using PruebaTecnica.Models.Agentes;

namespace PruebaTecnica.Services
{
    public class MediaService : IMediaService
    {
        private readonly Dictionary<char, IAgente> _agents;

        public MediaService(Dictionary<char, IAgente> agents)
        {
            _agents = agents;
        }

        public double OtenerMedia(char agentType, List<double> numbers)
        {
            if (_agents.TryGetValue(char.ToUpper(agentType), out var agent))
            {
                return agent.Operacion(numbers);
            }

            throw new ArgumentException("Agente no válido");
        }
    }
}
