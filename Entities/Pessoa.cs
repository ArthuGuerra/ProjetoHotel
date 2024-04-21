using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotelDIO.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; protected set; }
        public string CidadeOrigem { get; set; }

        public Pessoa(){}
        public Pessoa(string nome, string sobreNome,string email,string cidadeOrigem)
        {
            Nome = nome;
            SobreNome = sobreNome;
            Email = email;
            CidadeOrigem = cidadeOrigem;
        }
    }
}