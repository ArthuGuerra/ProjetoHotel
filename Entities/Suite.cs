using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelDIO.Entities
{
    public class Suite
    {
        public string TipoSuite { get; set; } 
        public int CapacidadeSuite { get; set; } 
        public decimal ValorDiaria { get; set; }

        public Suite(){} 
        public Suite(string tipoSuite, int capacidade,decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            CapacidadeSuite = capacidade;
            ValorDiaria = valorDiaria;
        } 
    }
}