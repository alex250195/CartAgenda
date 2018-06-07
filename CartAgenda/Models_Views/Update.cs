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
    public partial class formUpdate : Form
    {
        private Update update;
        public formUpdate()
        {
            InitializeComponent();

            rbPessoaFisica.Checked = true;
            rbPessoaJuridica.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.update = new Update();

            if (rbPessoaFisica.Checked)
            {
                this.update.update(1, cbCampo.SelectedItem.ToString(), txtDesc.Text, Convert.ToInt32(txtId.Text));
            }
            else
            {
                this.update.update(2, cbCampo.SelectedItem.ToString(), txtDesc.Text, Convert.ToInt32(txtId.Text));
            }
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            cbCampo.Items.Clear();
            cbCampo.Items.Add("Nome");
            cbCampo.Items.Add("Profissao");
            cbCampo.Items.Add("CPF");
            cbCampo.Items.Add("RG");
            cbCampo.Items.Add("OrgaoEmissor");
            cbCampo.Items.Add("DataNascimento");
            cbCampo.Items.Add("Sexo");
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            cbCampo.Items.Clear();
            cbCampo.Items.Add("RazaoSocial");
            cbCampo.Items.Add("InscEstadual");
            cbCampo.Items.Add("CNPJ");
            cbCampo.Items.Add("Proprietario");
            cbCampo.Items.Add("Ramo");
        }
    }
}
