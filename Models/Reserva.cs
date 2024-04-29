using DesafioProjetoHospedagem.Models.Shareds;
using DesafioProjetoHospedagem.Models.Validation;

namespace DesafioProjetoHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; private set; }
    public Suite Suite { get; private set; }
    public int DiasReservados { get; private set; }

    private Reserva() { }

    internal class BuilderReserva
    {
        private readonly Reserva reserva;
        public BuilderReserva()
        {
            reserva = new Reserva();
        }

        public BuilderReserva RegistrarDiasDeReserva(int diasReservados)
        {
            reserva.DiasReservados = diasReservados;
            return this;
        }

        public BuilderReserva RegistrarHospedes(List<Pessoa> hospedes)
        {
            reserva.Hospedes = hospedes;
            return this;
        }

        public BuilderReserva RegistrarSuite(Suite suite)
        {
            reserva.Suite = suite;
            return this;
        }

        public Reserva EfetuaReserva()
        {
            reserva.Validate();
            return reserva;
        }
    }

    private void Validate()
    {
        DomainValidation.NotLessThanAnotherField(Suite.Capacidade, nameof(Suite.Capacidade), Hospedes.Count, "a quantidade de Hospedes");
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularTotalDasDiarias()
    {
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= Constants.QTDE_DIAS_PARA_DESCONTO)
        {
            valor -= (valor * Constants.DESCONTO);
        }

        return valor;
    }
}

