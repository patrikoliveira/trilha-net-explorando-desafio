namespace DesafioProjetoHospedagem.Models;

public class TipoSuite : Enumeration
{
    public static TipoSuite Premium = new(1, nameof(Premium));

    public TipoSuite(int id, string name) : base(id, name)
    {
    }
}

