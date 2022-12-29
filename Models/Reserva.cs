using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
        {
            Hospedes = hospedes;
            Suite = suite;
            DiasReservados = diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade < Hospedes.Count)
            {
                Console.WriteLine("A quantidade de hospedes " + Hospedes.Count + ", estrapola o limite do quarto que é " + Suite.Capacidade);
            }
            else
            {
                hospedes = Hospedes;
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                var desconto = 0.10M;
                var valorDesconto = Suite.ValorDiaria * desconto;
                var valorFinalComDesconto = Suite.ValorDiaria - valorDesconto;

                return valorFinalComDesconto * DiasReservados;

            }
            else
            {
                return Suite.ValorDiaria * DiasReservados;
            }
        }
    }
}