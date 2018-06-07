using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartAgenda.DataBase
{
    public class Insert
    {
        private Connect connecting;
        private SqlCommand command;
        private Query queryInsert;

        public Insert()
        {
            queryInsert = new Query(); //Constutor que instancia um objeto da classe Query
        }

        /*
         Funções que inserem registros nas tabelas do banco, onde os parâmetros são valores de cada campo
             */

        public void insertAgenda(string nome, string senha)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryInsert.insert(1), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@nome", nome));
                this.command.Parameters.Add(new SqlParameter("@senha", senha));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [agenda] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [agenda]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void insertAmizade(DateTime data, int pessoaFisica)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryInsert.insert(2), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@dataAmizade", data));
                this.command.Parameters.Add(new SqlParameter("@pessoaFisica", pessoaFisica));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [amizade] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [amizade]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void insertContato_Fixo(int tipo, string telefone, int endereco)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryInsert.insert(3), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@tipo", tipo));
                this.command.Parameters.Add(new SqlParameter("@telefone", telefone));
                this.command.Parameters.Add(new SqlParameter("@endereco", endereco));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [contato fixo] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [contato fixo]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void insertContato_Movel(int tipo, string telefone, int pessoaFisica, int pessoaJuridica)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                if(pessoaJuridica < 0) this.command = new SqlCommand(this.queryInsert.insert(12), connecting.Connecting());
                else if(pessoaFisica < 0) this.command = new SqlCommand(this.queryInsert.insert(13), connecting.Connecting());
                else this.command = new SqlCommand(this.queryInsert.insert(4), connecting.Connecting());

                this.command.Parameters.Add(new SqlParameter("@tipo", tipo));
                this.command.Parameters.Add(new SqlParameter("@telefone", telefone));
                if(pessoaJuridica < 0) this.command.Parameters.Add(new SqlParameter("@pessoaFisica", pessoaFisica));
                if(pessoaFisica < 0) this.command.Parameters.Add(new SqlParameter("@pessoaJuridica", pessoaJuridica));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [contato movel] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [contato movel]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void insertEmpresa(int idAgenda, string RazaoSocial, string InscEstadual, string cnpj, string proprietario, string ramo)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryInsert.insert(5), connecting.Connecting());
                if(idAgenda < 0) this.command.Parameters.Add(new SqlParameter("@idAgenda", null));
                else this.command.Parameters.Add(new SqlParameter("@idAgenda", idAgenda));
                this.command.Parameters.Add(new SqlParameter("@razaoSocial", RazaoSocial));
                this.command.Parameters.Add(new SqlParameter("@inscEstadual", InscEstadual));
                this.command.Parameters.Add(new SqlParameter("@cnpj", cnpj));
                this.command.Parameters.Add(new SqlParameter("@proprietario", proprietario));
                this.command.Parameters.Add(new SqlParameter("@ramo", ramo));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [empresa] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [empresa]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void insertEndereco(string tipo, string logradouro, int numero, string bairro, string cidade, string estado, string pais, string cep, int pessoaFisica, int pessoaJuridica, string endereco)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                if (pessoaFisica < 0)
                {
                    this.command = new SqlCommand(this.queryInsert.insert(10), connecting.Connecting());
                    this.command.Parameters.Add(new SqlParameter("@pessoaJuridica", pessoaJuridica));

                }
                else if (pessoaJuridica < 0)
                {
                    this.command = new SqlCommand(this.queryInsert.insert(11), connecting.Connecting());
                    this.command.Parameters.Add(new SqlParameter("@pessoaFisica", pessoaFisica));

                }
                else
                {
                    this.command = new SqlCommand(this.queryInsert.insert(6), connecting.Connecting());
                    this.command.Parameters.Add(new SqlParameter("@pessoaFisica", pessoaFisica));
                    this.command.Parameters.Add(new SqlParameter("@pessoaJuridica", pessoaJuridica));
                }

                this.command.Parameters.Add(new SqlParameter("@tipo", tipo));
                this.command.Parameters.Add(new SqlParameter("@logradouro", logradouro));
                this.command.Parameters.Add(new SqlParameter("@numero", numero));
                this.command.Parameters.Add(new SqlParameter("@bairro", bairro));
                this.command.Parameters.Add(new SqlParameter("@cidade", cidade));
                this.command.Parameters.Add(new SqlParameter("@estado", estado));
                this.command.Parameters.Add(new SqlParameter("@pais", pais));
                this.command.Parameters.Add(new SqlParameter("@cep", cep));
                this.command.Parameters.Add(new SqlParameter("@endereco", endereco));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [endereço] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [endereço]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void insertParente(string tipo, int pessoaFisica)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryInsert.insert(7), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@tipo", tipo));
                this.command.Parameters.Add(new SqlParameter("@pessoaFisica", pessoaFisica));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [parente] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [parente]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void insertPessoaFisica(int idPessoaJuridica, int idAgenda, string sexo, DateTime nascimento, string rg, string emissor, string cpf, string profissao, string nome)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {

                if(idPessoaJuridica < 0)
                    this.command = new SqlCommand(this.queryInsert.insert(9), connecting.Connecting());
                else
                    this.command = new SqlCommand(this.queryInsert.insert(8), connecting.Connecting());

                if (idPessoaJuridica >= 0) this.command.Parameters.Add(new SqlParameter("@idPessoaJuridica", idPessoaJuridica));
                this.command.Parameters.Add(new SqlParameter("@idAgenda", idAgenda));
                this.command.Parameters.Add(new SqlParameter("@sexo", sexo));
                this.command.Parameters.Add(new SqlParameter("@nascimento", nascimento));
                this.command.Parameters.Add(new SqlParameter("@rg", rg));
                this.command.Parameters.Add(new SqlParameter("@emissor", emissor));
                this.command.Parameters.Add(new SqlParameter("@cpf", cpf));
                this.command.Parameters.Add(new SqlParameter("@profissao", profissao));
                this.command.Parameters.Add(new SqlParameter("@nome", nome));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [pessoa física] inserido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [pessoa física]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }
    }
}
