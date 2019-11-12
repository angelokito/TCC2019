using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimeiroAspTcc.Models
{
    public class Endereco
    {
        [MaxLength(50, ErrorMessage = "Tamanho maximo de caracteres 50 ")]
        public string Rua { get; set; }

        [MaxLength(50, ErrorMessage = "Tamanho maximo de caracteres 50 ")]
        public string Bairro { get; set; }

        [MaxLength(50, ErrorMessage = "Tamanho maximo de caracteres 50 ")]
        public string Cidade { get; set; }

        [MaxLength(9, ErrorMessage = "Tamanho maximo de caracteres 09 ")]
        public string Numero { get; set; }

        [MaxLength(20, ErrorMessage = "Tamanho maximo de caracteres 20 ")]
        public string Cep { get; set; }


        public float Latitude { get; set; }

        public float Longitude { get; set; }
    }
}
