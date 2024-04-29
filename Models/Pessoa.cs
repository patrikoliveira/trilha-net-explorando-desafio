using DesafioProjetoHospedagem.Models.Validation;
using DesafioProjetoHospedagem.Models.Shareds;

namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;

        Validate();
    }

    private void Validate()
    {
        DomainValidation.NotNullOrEmpty(Nome, nameof(Nome));
        DomainValidation.MinLength(Nome, Constants.MIN_LENGTH, nameof(Nome));
        DomainValidation.MaxLength(Nome, Constants.MAX_LENGTH, nameof(Nome));

        DomainValidation.NotNullOrEmpty(Sobrenome, nameof(Nome));
        DomainValidation.MinLength(Sobrenome, Constants.MIN_LENGTH, nameof(Sobrenome));
        DomainValidation.MaxLength(Sobrenome, Constants.MAX_LENGTH, nameof(Sobrenome));
    }

    public string Nome { get; private set; }
    public string Sobrenome { get; private set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}