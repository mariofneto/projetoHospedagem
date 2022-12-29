# Projeto Hospedagem
  Utilizei os conhecimentos adquiridos no Módulo intermediário de C# para fazer um sistema de hospedagem de um hotel.  

  Tem 3 classes: Pessoa, Suite e Reserva.

  - *Pessoa* tem dois atributos, Nome(string) e Sobrenome(string).
  - *Suite* tem três atributos, TipoSuite(string), Capacidade(int) e ValorDiaria(decimal)
  - *Reserva* tem três atributos, Hospedes(List<Pessoa>), Suite(Suite) e DiasReservados(int) 

  Dentro da classe Reserva tem 4 métodos:
  - void CadastrarHospedes(List<Pessoa> hospedes)
  - void CadastrarSuite(Suite suite)
  - int ObterQuantidadeHospedes()
  - decimal CalcularValorDiaria()

  