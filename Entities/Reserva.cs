using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoHotelDIO.Entities
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite  { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}
        public Reserva( int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospede) 
        {
            try
            {
                if(hospede.Count() > Suite.CapacidadeSuite)
                {
                    throw new Exception();
                }
                else
                {
                    Hospedes = hospede;
                    Console.WriteLine($"Hospedes registrados na Suite {Suite.TipoSuite} com sucesso! ");
                }
            }catch(Exception e)
            {
                Console.WriteLine("A quantidade de hóspedes não pode exceder a capacidade da suite - " + e.Message);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = 0;
            quantidade += Hospedes.Count();
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            if(DiasReservados >= 10)
            {
                decimal total = Suite.ValorDiaria * DiasReservados;
                total -= total * 0.1M;
                return total;
            }
            else
            {
                 decimal total = Suite.ValorDiaria * DiasReservados;
                 return total;
            }          
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
             sb.AppendLine($"Quantidade de hospedes: {ObterQuantidadeHospedes()} hospedes");

            foreach (Pessoa hospede in Hospedes)
            {
                sb.AppendLine($"Nome do Hospede: {hospede.Nome} - SobreNome: {hospede.SobreNome}");
                sb.AppendLine($"Email: {hospede.Email}");
                sb.AppendLine($"Cidade Origem: {hospede.CidadeOrigem}"); 
                Console.WriteLine("\n");          
            }
            return sb.ToString();
        }
    }
}