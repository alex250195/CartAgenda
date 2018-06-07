using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAgenda
{
    public class PessoaJuridica
    {
        public int id { get; set; }
        public int idAgenda { get; set; }
        public string razaoSocial { get; set; }
        public string inscricaoEstadual { get; set; }
        public string cnpj { get; set; }
        public string proprietario { get; set; }
        public string ramo { get; set; }
    }
}
