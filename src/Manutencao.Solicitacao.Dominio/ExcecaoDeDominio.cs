namespace Manutencao.Solicitacao.Dominio;

public class ExcecaoDeDominio : Exception
{
    public ExcecaoDeDominio(string msg) : base(msg) { }

    public static void LancarQuando(bool regraInvalida, string msg)
    {
        if (regraInvalida)
            throw new ExcecaoDeDominio(msg);
    }
}
