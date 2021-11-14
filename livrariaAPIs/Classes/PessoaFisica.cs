using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaAPIs.Classes
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public string RG { get; set; }
    }
}
