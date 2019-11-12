using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimeiroAspTcc.Models
{
    public class TipoServico
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Tamanho maximo de caracteres 50 ")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public ICollection<ClienteServico> Fornecedores { get; set; }
    }
}
