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
    public partial class formAmigo : Form
    {
        private Amizade amigo;
        private Insert insert;

        public formAmigo()
        {
            InitializeComponent();
        }

        private void btnAmigo_Click(object sender, EventArgs e)
        {
            if (txtAmigo.Text == "" || dtDataAmizade.Text == "")
                MessageBox.Show("Alguns campos não estão preenchidos!");
            else
            {
                this.amigo = new Amizade();
                this.insert = new Insert();

                this.amigo.idPessoaFisica = Convert.ToInt32(txtAmigo.Text);
                this.amigo.dataAmizade = Convert.ToDateTime(dtDataAmizade.Text);

                this.insert.insertAmizade(this.amigo.dataAmizade, 
                                          this.amigo.idPessoaFisica);
            }
        }
    }
}
