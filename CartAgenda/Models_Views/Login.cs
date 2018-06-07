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
    public partial class formAcesso : Form
    {
        private Agenda agenda = new Agenda();
        private Select select;
        private string nome = "";
        private string senha = "";

        public formAcesso()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Nome e/ou Senha não preenchidos");
            else
            {
                this.nome = txtNome.Text;
                this.senha = txtSenha.Text;

                agenda.nome = this.nome;
                agenda.senha = this.senha;

                Dispose();
                if (agenda.nome == "Admin" && agenda.senha == "2501")
                {
                    formAdministrador admin = new formAdministrador();
                    admin.ShowDialog();

                    Close();
                }
                else
                {
                    try
                    {
                        this.select = new Select();

                        agenda.id = this.select.selectAgenda(agenda.nome, agenda.senha);
                        if (agenda.id > 0)
                        {
                            formHome home = new formHome(agenda.id, agenda.nome, agenda.senha);
                            home.ShowDialog();

                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Nome/Senha inválidos!");
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    
                }
            }
        }

    }
}
