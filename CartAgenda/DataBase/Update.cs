using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartAgenda.DataBase
{
    public class Update
    {
        private Connect connecting;
        private SqlCommand command;
        private Query queryUpdate;

        public Update()
        {
            queryUpdate = new Query();
        }

        /*
         Funções que atualizam os registros das tabelas do banco de acordo com o ID do registro
             */
        public void update(int flag, string campo, string novoCampo, int id)
        {
            this.connecting = new Connect();
            this.connecting.OpenConnect();
            try
            {
                //MessageBox.Show(flag + " " + campo + " " + novoCampo + " " + id);
                this.command = new SqlCommand(this.queryUpdate.update(flag) + campo + this.queryUpdate.update(flag + 2), this.connecting.Connecting());
                this.command.Parameters.Clear();
                this.command.Parameters.Add(new SqlParameter("@newCampo", novoCampo));
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [pessoa] editado com sucesso!");
                connecting.CloseConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar registro [pessoa]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }
    }
}
