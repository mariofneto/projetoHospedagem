using projetoHospedagem.Models;

var hospedes = new List<Pessoa>();

var pessoaExemplo1 = new Pessoa(nome: "Mário", sobrenome: "Ferreira");
var pessoaExemplo2 = new Pessoa(nome: "Odila", sobrenome: "Zanela");

hospedes.Add(pessoaExemplo1);
hospedes.Add(pessoaExemplo2);

var suiteExemplo = new Suite(tipoSuite: "Premium",capacidade: 2, valorDiaria: 30);

var reserva = new Reserva(hospedes: hospedes, suite: suiteExemplo, diasReservados: 5);

reserva.CadastrarSuite(suiteExemplo);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");


