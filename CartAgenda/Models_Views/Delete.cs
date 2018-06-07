using CartAgenda.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartAgenda
{
    public partial class formDelete : Form
    {
        private Delete delete;
        private Select select;

        public formDelete()
        {
            InitializeComponent();

            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.delete = new Delete();
            this.select = new Select();

            if (rbPessoaFisica.Checked)
            {
                this.delete.deleteAmigo(Convert.ToInt32(txtId.Text));
                this.delete.deleteParente(Convert.ToInt32(txtId.Text));
                this.delete.deleteContato_Fixo(this.select.selectIdEnderecoFisica(Convert.ToInt32(txtId.Text)));
                this.delete.deleteEnderecoFisica(Convert.ToInt32(txtId.Text));
                this.delete.deleteContato_MovelFisica(Convert.ToInt32(txtId.Text));
                this.delete.deleteFisica(Convert.ToInt32(txtId.Text));
            }
        }
    }
}
