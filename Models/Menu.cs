using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoHospedagem.Models
{
    public class Menu
    {
        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine(" Seja Bem-Vindo ao Hotel mariofneto");
            Console.WriteLine("====================================");
            Console.WriteLine("<<<< CheckIn >>>>");
            Console.WriteLine();
            Console.WriteLine("Vocês estão em quantas pessoas? ");
            var quantidadeHospedes = Convert.ToInt32(Console.ReadLine());
            var hospedes = new List<Pessoa>();

            Console.Clear();
            for (var contador = 0; contador < quantidadeHospedes; contador++)
            {
                Console.WriteLine("<<<< Insira os Dados >>>>");
                Console.Write("Nome: ");
                var nome = Console.ReadLine();
                Console.Write("Sobrenome: ");
                var sobrenome = Console.ReadLine();
                Console.WriteLine("=================");

                var pessoa = new Pessoa(nome, sobrenome);
                hospedes.Add(pessoa);
            }
            Console.Clear();
            Console.WriteLine("<<<< Dados da Suite >>>>");
            Console.Write("Tipo da Suite: (Premium = R$100 / Comum = R$50): ");
            var tipoSuite = Console.ReadLine().ToLower();
            Console.Write("Quantos dias você quer passar? ");
            var diasReservados = Convert.ToInt32(Console.ReadLine());
            var capacidadeSuite = quantidadeHospedes;
            var valor = 0M;

            if (tipoSuite == "premium")
            {
                valor = 100M;
            }
            else if (tipoSuite == "comum")
            {
                valor = 50M;
            }
            else
            {
                Console.WriteLine("Tipo da Suite inválida! Tente novamente");
                Console.ReadLine();
            }
            var suite = new Suite(tipoSuite, capacidadeSuite, valor);

            var reserva = new Reserva(hospedes, suite, diasReservados);

            reserva.CadastrarHospedes(hospedes);
            reserva.CadastrarSuite(suite);
            MostrarDadosHospedes(reserva, suite);
        }

        public static void MostrarDadosHospedes(Reserva reserva, Suite suite)
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine($"Tipo da Suite: {suite.TipoSuite.ToUpper()}");
            Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Dias Hospedados: {reserva.DiasReservados}");
            Console.WriteLine($"Valor a Pagar: R${reserva.CalcularValorDiaria()}");
            Console.WriteLine("===========================================");
        }
    }
}