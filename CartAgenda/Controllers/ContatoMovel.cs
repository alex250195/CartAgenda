using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAgenda.Controllers
{
    public class ContatoMovel
    {
        public int id { get; set; }
        public int idPessoaFisica { get; set; }
        public int idPessoaJuridica { get; set; }
        public int tipo { get; set; }
        public string telefone { get; set; }
        
    }
}
