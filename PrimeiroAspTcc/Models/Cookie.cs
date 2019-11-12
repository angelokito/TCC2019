using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiroAspTcc.Models
{
    public class Cookie
    {
        [Required(ErrorMessage ="Nome Obrigatorio!")]
        public string Nome { get; set; }
    }
}