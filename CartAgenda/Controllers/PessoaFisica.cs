using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAgenda
{
    public class PessoaFisica
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idPessoaJuridica { get; set; }
        public int idAgenda { get; set; }
        public string sexo { get; set; }
        public DateTime dataNascimento { get; set; }
        public string rg { get; set; }
        public string orgaoEmissor { get; set; }
        public string cpf { get; set; }
        public string profissao { get; set; }
    }
}
