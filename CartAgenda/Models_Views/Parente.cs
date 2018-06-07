using CartAgenda.Controllers;
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
    public partial class formParente : Form
    {
        private Parente parente;
        private Insert insert;
        public formParente()
        {
            InitializeComponent();
        }

        private void btnParente_Click(object sender, EventArgs e)
        {
            if (txtParente.Text == "" || txtParentesco.Text == "")
                MessageBox.Show("Alguns campos estão vazios!");
            else
            {
                this.parente = new Parente();
                this.insert = new Insert();

                this.parente.idPessoaFisica = Convert.ToInt32(txtParente.Text);
                this.parente.tipoParentesco = txtParentesco.Text;

                this.insert.insertParente(this.parente.tipoParentesco,
                                          this.parente.idPessoaFisica);
            }
        }
    }
}
