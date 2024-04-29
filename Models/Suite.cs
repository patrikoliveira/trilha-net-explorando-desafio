using DesafioProjetoHospedagem.Models.Validation;

namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(TipoSuite tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;

            Validate();
        }

        private void Validate()
        {
            DomainValidation.NotLessThanOrEqualZero(Capacidade, nameof(Capacidade));
            DomainValidation.NotLessThanOrEqualZero(ValorDiaria, nameof(ValorDiaria));
        }

        public TipoSuite TipoSuite { get; private set; }
        public int Capacidade { get; private set; }
        public decimal ValorDiaria { get; private set; }
    }
}