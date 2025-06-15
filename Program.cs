using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Paulina");
Pessoa p2 = new Pessoa(nome: "Paulo");
Pessoa p3 = new Pessoa(nome: "Predo");
Pessoa p4 = new Pessoa(nome: "Petra");
hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Standard", capacidade: 5, valorDiaria: 299.99M);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
// Exibe os detalhes da reserva
Console.WriteLine($"Detalhes da reserva: {reserva.Suite.TipoSuite}, Capacidade: {reserva.Suite.Capacidade}, Valor Diária: {reserva.Suite.ValorDiaria:C}");