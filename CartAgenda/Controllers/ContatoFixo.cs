using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAgenda.Controllers
{
    public class ContatoFixo
    {
        public int id { get; set; }

        public int idEndereco { get; set; }

        public int tipo { get; set; }
        public string telefone { get; set; }
    }
}
