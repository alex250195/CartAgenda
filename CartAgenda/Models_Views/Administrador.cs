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

namespace CartAgenda.Models_Views
{
    public partial class formAdministrador : Form
    {
        private Agenda agenda;
        private Insert insert;
        public formAdministrador()
        {
            InitializeComponent();

            this.agenda = new Agenda(); //Instanciando ojeto agenda
            this.insert = new Insert(); //Instanciando ojeto insert
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            //Verificando se os campos foram preenchidos
            if (txtNome.Text == "" || txtSenha.Text == "") MessageBox.Show("Nome/Senha não preenchidos!");
            else
            {
                //Setando valores aos atributos do objeto agenda
                this.agenda.nome = txtNome.Text;
                this.agenda.senha = txtSenha.Text;
                //Inserindo dados ao DB
                this.insert.insertAgenda(this.agenda.nome, this.agenda.senha);
            }
            //Atualizando gridView
            this.agendaTableAdapter.Fill(this.bdCartAgendaDataSet.Agenda);
        }

        private void formAdministrador_Load(object sender, EventArgs e)
        {
            //Carrega a janela com o grid atualizado
            this.agendaTableAdapter.Fill(this.bdCartAgendaDataSet.Agenda);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Chama a tela de login e fecha a mesma
            this.Dispose();

            formAcesso acesso = new formAcesso();
            acesso.ShowDialog();

            this.Close();
        }
    }
}
