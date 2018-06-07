using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartAgenda.DataBase
{
    public class Select
    {
        private Connect connecting;
        private SqlCommand command;
        private Query querySelect;

        public Select()
        {
            querySelect = new Query();
        }

        /*
         Funções que retornam registros das tabelas do banco de acordo com algum campo específico
             */

        public int selectIdPessoaFisica()
        {
            int id = 0;

            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.querySelect.selectId(7), connecting.Connecting());
                SqlDataReader leitor = this.command.ExecuteReader();
                while (leitor.Read())
                {
                    id = Convert.ToInt32(leitor["idPessoaFisica"]);
                    break;
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar registro [pessoa física]! " + ex.Message);
                return 0;
            }
        }

        public int selectIdPessoa(int idPessoa)
        {
            int id = 0;

            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.querySelect.selectId(10), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", idPessoa));
                SqlDataReader leitor = this.command.ExecuteReader();
                while (leitor.Read())
                {
                    id = Convert.ToInt32(leitor["idPessoaFisica"]);
                    break;
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar registro [pessoa física]! " + ex.Message);
                return 0;
            }
        }


        public int selectIdPessoaJuridica()
        {
            int id = 0;

            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.querySelect.selectId(8), connecting.Connecting());
                SqlDataReader leitor = this.command.ExecuteReader();
                while (leitor.Read())
                {
                    id = Convert.ToInt32(leitor["idPessoaJuridica"]);
                    break;
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar registro [pessoa jurídica]! " + ex.Message);
                return 0;
            }
        }

        public int selectIdAgenda()
        {
            int id = 0;
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.querySelect.selectId(1), connecting.Connecting());
                SqlDataReader leitor = this.command.ExecuteReader();
                while (leitor.Read())
                {
                    id = Convert.ToInt32(leitor["idAgenda"]);
                    break;
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar registro [agenda]! " + ex.Message);
                return 0;
            }
        }

        public int selectIdEndereco()
        {
            int id = 0;
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.querySelect.selectId(5), connecting.Connecting());
                SqlDataReader leitor = this.command.ExecuteReader();
                while (leitor.Read())
                {
                    id = Convert.ToInt32(leitor["idEndereco"]);
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar registro [endereço]! " + ex.Message);
                return 0;
            }
        }

        public int selectIdEnderecoFisica(int idFisica)
        {
            int id = 0;
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.querySelect.selectId(5), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", idFisica));
                SqlDataReader leitor = this.command.ExecuteReader();
                while (leitor.Read())
                {
                    id = Convert.ToInt32(leitor["idEndereco"]);
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar registro [endereço]! " + ex.Message);
                return 0;
            }
        }

        public int selectAgenda(string nome, string senha)
        {
            int id = 0;

            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.querySelect.selectId(9), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@nome", nome));
                this.command.Parameters.Add(new SqlParameter("@senha", senha));
                SqlDataReader leitor = this.command.ExecuteReader();
                while (leitor.Read())
                {
                    id = Convert.ToInt32(leitor["idAgenda"]);
                    break;
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao recuperar registro [agenda]! " + ex.Message);
                return 0;
            }
            finally
            {
                connecting.CloseConnect();
            }
        }
    }
}
