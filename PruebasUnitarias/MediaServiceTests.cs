using PruebaTecnica.Models.Agentes;
using PruebaTecnica.Services;

public class MediaServiceTests
{
    [Fact]
    public void ObtenerMediaAgenteARetornaResultadosCorrectos()
    {
        var agenteA = new AgenteA();
        var mediaService = new MediaService(new Dictionary<char, IAgente> { { 'A', agenteA } });

        var numeros = new List<double> { 1, 2, 3, 4, 5 };
        var resultado = mediaService.OtenerMedia('A', numeros);

        Assert.Equal(3, resultado);
    }

    [Fact]
    public void ObtenerMediaAgenteBRetornaResultadosCorrectos()
    {
        var agenteB = new AgenteB();
        var mediaService = new MediaService(new Dictionary<char, IAgente> { { 'B', agenteB } });

        var numeros = new List<double> { 1, 2, 3, 4, 5 };
        var resultado = mediaService.OtenerMedia('B', numeros);

        Assert.Equal(2.18978, resultado, 5);
    }

    [Fact]
    public void ObtenerMediaAgenteCRetornaResultadosCorrectos()
    {
        var agenteC = new AgenteC();
        var mediaService = new MediaService(new Dictionary<char, IAgente> { { 'C', agenteC } });

        var numeros = new List<double> { 1, 2, 3, 4, 5 };
        var resultado = mediaService.OtenerMedia('C', numeros);

        Assert.Equal(3, resultado);
    }

    [Fact]
    public void ObtenerMediaParametrosInvalidos()
    {
        var mediaService = new MediaService(new Dictionary<char, IAgente>());

        var numeros = new List<double> { 1, 2, 3, 4, 5 };

        Assert.Throws<ArgumentException>(() => mediaService.OtenerMedia('D', numeros));
    }
}
