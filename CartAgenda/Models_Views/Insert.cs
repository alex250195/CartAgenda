using CartAgenda.Controllers;
using CartAgenda.DataBase;
using CartAgenda.Models_Views;
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
    public partial class formInsert : Form
    {
        private Insert insert;
        private Select select;

        private Agenda agenda;
        private Amizade amizade;
        private ContatoFixo contatoFixo;
        private ContatoFixo contatoFixo1;
        private ContatoFixo contatoFixo2;
        private ContatoFixo contatoFixo3;
        private ContatoFixo contatoFixo4;
        private ContatoMovel contatoMovel;
        private Parente parente;
        private PessoaFisica pessoaFisica;
        private PessoaJuridica pessoaJuridica;
        private Endereco endereco;

        private int id;
        private string nome;
        private string senha;

        public formInsert(int id, string nome, string senha)
        {
            InitializeComponent();

            gbSenha.Enabled = false;

            rbPessoaFisica.Checked   = true;
            rbPessoaJuridica.Checked = false;

            rbMasc.Checked = true;
            rbFem.Checked  = false;

            lbData.Text = Convert.ToString(DateTime.Now);

            this.id = id;
            this.nome = nome;
            this.senha = senha;
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            gbCadastroFisico.Enabled   = true;
            gbCadastroJuridico.Enabled = false;
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            gbCadastroJuridico.Enabled = true;
            gbCadastroFisico.Enabled   = false;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.insert = new Insert();
            this.select = new Select();

            this.agenda = new Agenda();
            this.amizade = new Amizade();
            this.contatoFixo = new ContatoFixo();
            this.contatoFixo1 = new ContatoFixo();
            this.contatoFixo2 = new ContatoFixo();
            this.contatoFixo3 = new ContatoFixo();
            this.contatoFixo4 = new ContatoFixo();
            this.contatoMovel = new ContatoMovel();
            this.endereco = new Endereco();
            this.parente = new Parente();
            this.pessoaFisica = new PessoaFisica();
            this.pessoaJuridica = new PessoaJuridica();

            try
            {
                if (rbPessoaFisica.Checked)
                {
                    this.pessoaFisica.nome = txtNome.Text;
                    this.pessoaFisica.cpf = txtCpf.Text;
                    this.pessoaFisica.dataNascimento = Convert.ToDateTime(txtNascimento.Text);
                    if(txtEmpresa.Text != "") this.pessoaFisica.idPessoaJuridica = Convert.ToInt32(txtEmpresa.Text);
                    else this.pessoaFisica.idPessoaJuridica = -1;
                    this.pessoaFisica.idAgenda = this.id;
                    this.pessoaFisica.orgaoEmissor = txtEmissor.Text;
                    this.pessoaFisica.profissao = txtProfissao.Text;
                    this.pessoaFisica.rg = txtRg.Text;
                    if (rbFem.Checked) this.pessoaFisica.sexo = "Feminino";
                    else this.pessoaFisica.sexo = "Masculino";

                    this.insert.insertPessoaFisica(this.pessoaFisica.idPessoaJuridica,
                                                   this.pessoaFisica.idAgenda,
                                                   this.pessoaFisica.sexo,
                                                   this.pessoaFisica.dataNascimento,
                                                   this.pessoaFisica.rg,
                                                   this.pessoaFisica.orgaoEmissor,
                                                   this.pessoaFisica.cpf,
                                                   this.pessoaFisica.profissao,
                                                   this.pessoaFisica.nome);

                    this.endereco.idPessoaFisica = this.select.selectIdPessoaFisica();
                    this.endereco.idPessoaJuridica = -1;

                    this.contatoMovel.idPessoaJuridica = -1;
                    this.contatoMovel.idPessoaFisica = this.select.selectIdPessoaFisica();
                }
                else
                {
                    this.pessoaJuridica.cnpj = txtCnpj.Text;
                    this.pessoaJuridica.inscricaoEstadual = txtInscEstadual.Text;
                    this.pessoaJuridica.proprietario = txtProprietario.Text;
                    this.pessoaJuridica.ramo = txtRamo.Text;
                    this.pessoaJuridica.razaoSocial = txtRazaoSocial.Text;
                    this.pessoaJuridica.idAgenda = this.id;

                    this.insert.insertEmpresa(this.pessoaJuridica.idAgenda,
                                              this.pessoaJuridica.razaoSocial,
                                              this.pessoaJuridica.inscricaoEstadual,
                                              this.pessoaJuridica.cnpj,
                                              this.pessoaJuridica.proprietario,
                                              this.pessoaJuridica.ramo);

                    this.endereco.idPessoaFisica = -1;
                    this.endereco.idPessoaJuridica = this.select.selectIdPessoaJuridica();

                    this.contatoMovel.idPessoaJuridica = this.select.selectIdPessoaJuridica();
                    this.contatoMovel.idPessoaFisica = -1;
                }

                this.endereco.bairro = txtBairro.Text;
                this.endereco.cep = txtCep.Text;
                this.endereco.cidade = txtCidade.Text;
                this.endereco.estado = txtUf.Text;
                
                this.endereco.logradouro = txtLogradouro.Text;
                this.endereco.numero = Convert.ToInt32(txtNum.Text);
                this.endereco.pais = txtPais.Text;
                this.endereco.tipoEndereco = txtTipoEndereco.Text;
                this.endereco.endereco = txtEndereco.Text;

                this.insert.insertEndereco(this.endereco.tipoEndereco,
                                           this.endereco.logradouro,
                                           this.endereco.numero,
                                           this.endereco.bairro,
                                           this.endereco.cidade,
                                           this.endereco.estado,
                                           this.endereco.pais,
                                           this.endereco.cep,
                                           this.endereco.idPessoaFisica,
                                           this.endereco.idPessoaJuridica,
                                           this.endereco.endereco);

                if (txtResidencial.Text != "")
                {
                    this.contatoFixo.idEndereco = this.select.selectIdEndereco();
                    this.contatoFixo.telefone = txtResidencial.Text;
                    this.contatoFixo.tipo = 1;

                    this.insert.insertContato_Fixo(this.contatoFixo.tipo, 
                                                   this.contatoFixo.telefone, 
                                                   this.contatoFixo.idEndereco);
                }

                if (txtComercial.Text != "")
                {
                    this.contatoFixo1.idEndereco = this.select.selectIdEndereco();
                    this.contatoFixo1.telefone = txtComercial.Text;
                    this.contatoFixo1.tipo = 2;

                    this.insert.insertContato_Fixo(this.contatoFixo.tipo,
                                                   this.contatoFixo.telefone,
                                                   this.contatoFixo.idEndereco);
                }

                if (txtRecado.Text != "")
                {
                    this.contatoFixo2.idEndereco = this.select.selectIdEndereco();
                    this.contatoFixo2.telefone = txtRecado.Text;
                    this.contatoFixo2.tipo = 3;

                    this.insert.insertContato_Fixo(this.contatoFixo.tipo,
                                                   this.contatoFixo.telefone,
                                                   this.contatoFixo.idEndereco);
                }

                if (txtFax.Text != "")
                {
                    this.contatoFixo3.idEndereco = this.select.selectIdEndereco();
                    this.contatoFixo3.telefone = txtFax.Text;
                    this.contatoFixo3.tipo = 4;

                    this.insert.insertContato_Fixo(this.contatoFixo.tipo,
                                                   this.contatoFixo.telefone,
                                                   this.contatoFixo.idEndereco);
                }

                if (txtOutro.Text != "")
                {
                    this.contatoFixo4.idEndereco = this.select.selectIdEndereco();
                    this.contatoFixo4.telefone = txtOutro.Text;
                    this.contatoFixo4.tipo = 5;

                    this.insert.insertContato_Fixo(this.contatoFixo.tipo,
                                                   this.contatoFixo.telefone,
                                                   this.contatoFixo.idEndereco);
                }

                
                this.contatoMovel.telefone = txtCelular.Text;
                this.contatoMovel.tipo = 1;

                this.insert.insertContato_Movel(this.contatoMovel.tipo, 
                                                this.contatoMovel.telefone, 
                                                this.contatoMovel.idPessoaFisica, 
                                                this.contatoMovel.idPessoaJuridica);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParente_Click(object sender, EventArgs e)
        {
            formParente parente = new formParente();
            parente.Show();
        }

        private void btnAmizade_Click(object sender, EventArgs e)
        {
            formAmigo amigo = new formAmigo();
            amigo.Show();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
