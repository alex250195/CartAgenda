using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CartAgenda.DataBase
{
    public class Delete
    {
        private Connect connecting;
        private SqlCommand command;
        private Query queryDelete;

        public Delete()
        {
            queryDelete = new Query(); //Construtor que instancia um objeto Query
        }

        /*
         Funções que deletam apenas um registro específico de suas tabelas,
         de acordo com o ID
             */
        public void deleteAgenda(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(1), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [agenda] deletado com sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [agenda]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteAmigo(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(2), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [amigo] deletado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir registro [amigo]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteContato_Fixo(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(3), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [contato fixo] deletado com sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [contato fixo]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteContato_MovelFisica(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(4), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [contato movel] deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [contato movel]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteContato_MovelJuridica(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(5), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [contato movel] deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [contato movel]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteEnderecoFisica(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(6), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [endereco] deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [endereco]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteEnderecoJuridica(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(7), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [endereco] deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [endereco]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteFisica(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(8), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [pessoa fisica] deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [pessoa fisica]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteJuridica(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(9), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [pessoa juridica] deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [pessoa juridica]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }

        public void deleteParente(int id)
        {
            connecting = new Connect();
            connecting.OpenConnect();
            try
            {
                this.command = new SqlCommand(this.queryDelete.delete(10), connecting.Connecting());
                this.command.Parameters.Add(new SqlParameter("@id", id));
                this.command.ExecuteNonQuery();
                MessageBox.Show("Registro [parente] deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar registro [parente]! " + ex.Message);
            }
            finally
            {
                connecting.CloseConnect();
            }
        }
    }
}
