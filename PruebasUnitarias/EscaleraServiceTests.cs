using PruebaTecnica.Models.Escalera;
using PruebaTecnica.Services;

public class EscaleraServiceTests
{
    [Fact]
    public void ObtenerEscaleraAgentARetornaResultadoCorrecto()
    {
        var escaleraA = new EscaleraA();
        var escaleraService = new EscaleraService(new Dictionary<char, IEscalera> { { 'A', escaleraA } });

        var resultado = escaleraService.ObtenerEscalera('A', 3);

        Assert.Equal("  #\r\n ##\r\n###\r\n", resultado);
    }

    [Fact]
    public void ObtenerEscaleraAgentBRetornaResultadoCorrecto()
    {
        var escaleraB = new EscaleraB();
        var escaleraService = new EscaleraService(new Dictionary<char, IEscalera> { { 'B', escaleraB } });

        var resultado = escaleraService.ObtenerEscalera('B', 3);

        Assert.Equal("  #\r\n ##\r\n###\r\n", resultado);
    }

    [Fact]
    public void ObtenerEscaleraAgentCRetornaResultadoCorrecto()
    {
        var escaleraC = new EscaleraC();
        var escaleraService = new EscaleraService(new Dictionary<char, IEscalera> { { 'C', escaleraC } });

        var resultado = escaleraService.ObtenerEscalera('C', 3);

        Assert.Equal(" #\r\n  ##\r\n ###\r\n", resultado);
    }

    [Fact]
    public void ObtenerEscaleraParametrosInvalidos()
    {
        var escaleraService = new EscaleraService(new Dictionary<char, IEscalera>());

        Assert.Throws<ArgumentException>(() => escaleraService.ObtenerEscalera('D', 3));
    }
}
