using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrimeiroAspTcc.Models
{
    public enum GenderEnum
    {
        [Description("Não informado")]
        Informe = 0,
        [Description("Masculino")]
        Masculino = 1,
        [Description("Feminino")]
        Feminino = 2
    }
}
