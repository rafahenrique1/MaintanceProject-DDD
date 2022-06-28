using Manutencao.Solicitacao.Dominio;
using Xunit;

namespace Manutencao.SolicitacaoTestes._Util;

public static class AssertExtensions
{
    public static void ThrowsWithMessage(Action codigoTeste, string mensagemEsperada)
    {
        var mensagem = Assert.Throws<ExcecaoDeDominio>(codigoTeste).Message;
        Assert.Equal(mensagemEsperada, mensagem);
    }

    public static void ThrowsWithMessageAsync(Func<Task> codigoTeste, string mensagemEsperada)
    {
        var resultado = Assert.ThrowsAsync<ExcecaoDeDominio>(codigoTeste).Result;
        Assert.Equal(mensagemEsperada, resultado.Message);
    }
}
