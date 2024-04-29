using System.Text;
using DesafioProjetoHospedagem.Models;
using static DesafioProjetoHospedagem.Models.Reserva;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new();

Pessoa p1 = new(nome: "Joao", sobrenome: "Silva");
Pessoa p2 = new(nome: "Maria", sobrenome: "Silva");
// Pessoa p3 = new(nome: "Pedro", sobrenome: "Silva");

hospedes.Add(p1);
hospedes.Add(p2);
// hospedes.Add(p3);

// Cria a suíte
Suite suite = new(TipoSuite.Premium, capacidade: 2, valorDiaria: 30);

BuilderReserva buider = new();

var reserva = buider
    .RegistrarDiasDeReserva(diasReservados: 5)
    .RegistrarSuite(suite)
    .RegistrarHospedes(hospedes)
    .EfetuaReserva();

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularTotalDasDiarias()}");