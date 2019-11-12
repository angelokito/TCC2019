using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrimeiroAspTcc.Models
{
    public class Cliente 
    {
        public int Id { get; set; }
        
        [MaxLength(50, ErrorMessage ="Tamanho maximo de caracteres 50 ")]
        public string Nome { get; set; }
        
        public DateTime Data_nasc { get; set; }

        [MaxLength(40, ErrorMessage ="Tamanho maximo de caracteres 40")]
        public string Email { get; set; }

        [MaxLength(18,ErrorMessage ="Tamanho maximo de caracteres 18")]
        public string Cpf { get; set; }

        [MaxLength(13, ErrorMessage ="Tamanho Máximo de caracteres 13")]
        public string Rg { get; set; }

        public GenderEnum Sexo { get; set; }

        public Endereco Ender_resi { get; set; }
        public Endereco End_comercial { get; set; }

        [MaxLength(11, ErrorMessage ="Tamanho Máximo de caracteres 11")]
        public string Cel { get; set; }

        [MaxLength(40, ErrorMessage ="Tamanho Máximo de Caracteres 40")]
        public string Login { get; set; }

        [MaxLength(10, ErrorMessage ="Tamanho Máximo de Caracteres 10")]
        public string Senha { get; set; }

        public ICollection<ClienteServico> Servicos { get; set; }
        
    }
}
