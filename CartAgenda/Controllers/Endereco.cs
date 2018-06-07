using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAgenda.Controllers
{
    public class Endereco
    {
        public int id { get; set; }

        public int idPessoaFisica { get; set; }

        public int idPessoaJuridica { get; set; }

        public string tipoEndereco { get; set; }

        public string endereco { get; set; }

        public string logradouro { get; set; }

        public int numero { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string pais { get; set; }

        public string cep { get; set; }
    }
}
