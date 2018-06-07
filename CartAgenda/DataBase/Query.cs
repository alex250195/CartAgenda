using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAgenda.DataBase
{
    public class Query
    {
        //Strings de inserção de dados
        private string sqlInsertAgenda = @"INSERT INTO Agenda(Nome, Senha) 
                                           VALUES (@nome, @senha)";
        private string sqlInsertAmizade = @"INSERT INTO Amizade(DataAmizade, idPessoaFisica)
                                            VALUES (@dataAmizade, @pessoaFisica)";
        private string sqlInsertContatoFixo = @"INSERT INTO Contato_Fixo(Tipo, Telefone, idEndereco)
                                                VALUES(@tipo, @telefone, @endereco)";
        private string sqlInsertContatoMovel = @"INSERT INTO Contato_Movel(Tipo, Telefone, idPessoaFisica, idPessoaJuridica)
                                                 VALUES (@tipo, @telefone, @pessoaFisica, @pessoaJuridica)";
        private string sqlInsertContatoMovel1 = @"INSERT INTO Contato_Movel(Tipo, Telefone, idPessoaFisica)
                                                 VALUES (@tipo, @telefone, @pessoaFisica)";
        private string sqlInsertContatoMovel2 = @"INSERT INTO Contato_Movel(Tipo, Telefone, idPessoaJuridica)
                                                 VALUES (@tipo, @telefone, @pessoaJuridica)";
        private string sqlInsertEmpresa = @"INSERT INTO Pessoa_Juridica(idAgenda, RazaoSocial, InscEstadual, CNPJ, Proprietario, Ramo)
                                            VALUES (@idAgenda, @razaoSocial, @inscEstadual, @cnpj, @proprietario, @ramo)";
        private string sqlInsertEndereco = @"INSERT INTO Endereco(TipoEndereco, Logradouro, Numero, Bairro, Cidade, Estado, Pais, Cep, idPessoaFisica, idPessoaJuridica, Endereco)
                                             VALUES (@tipo, @logradouro, @numero, @bairro, @cidade, @estado, @pais, @cep, @pessoaFisica, @pessoaJuridica, @endereco)";
        private string sqlInsertEndereco1 = @"INSERT INTO Endereco(TipoEndereco, Logradouro, Numero, Bairro, Cidade, Estado, Pais, Cep, idPessoaJuridica, Endereco)
                                             VALUES (@tipo, @logradouro, @numero, @bairro, @cidade, @estado, @pais, @cep, @pessoaJuridica, @endereco)";
        private string sqlInsertEndereco2 = @"INSERT INTO Endereco(TipoEndereco, Logradouro, Numero, Bairro, Cidade, Estado, Pais, Cep, idPessoaFisica, Endereco)
                                             VALUES (@tipo, @logradouro, @numero, @bairro, @cidade, @estado, @pais, @cep, @pessoaFisica, @endereco)";
        private string sqlInsertParente = @"INSERT INTO Parente(TipoParentesco, idPessoaFisica)
                                            VALUES (@tipo, @pessoaFisica)";
        private string sqlInsertPessoaFisica = @"INSERT INTO Pessoa_Fisica(idPessoaJuridica, idAgenda, Sexo, DataNascimento, RG, OrgaoEmissor, CPF, Profissao, Nome)
                                                 VALUES (@idPessoaJuridica, @idAgenda, @sexo, @nascimento, @rg, @emissor, @cpf, @profissao, @nome)";
        private string sqlInsertPessoaFisica1 = @"INSERT INTO Pessoa_Fisica(idAgenda, Sexo, DataNascimento, RG, OrgaoEmissor, CPF, Profissao, Nome)
                                                 VALUES (@idAgenda, @sexo, @nascimento, @rg, @emissor, @cpf, @profissao, @nome)";

        //Strings de recuperação de dados
        private string sqlSelectIdAgenda = @"SELECT TOP 1 idAgenda FROM Agenda ORDER BY idAgenda DESC";
        private string sqlSelectIdAmizade = @"SELECT TOP 1 idAmizade FROM Amizade ORDER BY idAmizade DESC";
        private string sqlSelectIdContatoFixo = @"SELECT TOP 1 idContato FROM Contato_Fixo ORDER BY idContato DESC";
        private string sqlSelectIdContatoMovel = @"SELECT TOP 1 idContato FROM Contato_Movel ORDER BY idContato DESC";
        private string sqlSelectIdEndereco = @"SELECT TOP 1 idEndereco FROM Endereco ORDER BY idEndereco DESC";
        private string sqlSelectIdEnderecoFisica = @"SELECT idEndereco FROM Endereco WHERE idPessoaFisica = @id";
        private string sqlSelectIdParente = @"SELECT TOP 1 idParente FROM Parente ORDER BY idParente DESC";
        private string sqlSelectIdPessoaFisica = @"SELECT TOP 1 idPessoaFisica FROM Pessoa_Fisica ORDER BY idPessoaFisica DESC";
        private string sqlSelectIdPessoaFisica1 = @"SELECT idPessoaFisica FROM Pessoa_Fisica WHERE idPessoaFisica = @id";
        private string sqlSelectIdPessoaJuridica = @"SELECT TOP 1 idPessoaJuridica FROM Pessoa_Juridica ORDER BY idPessoaJuridica";
        private string sqlSelectAgenda = @"SELECT idAgenda FROM Agenda WHERE Nome = @nome AND Senha = @senha";

        //String de deleção de dados
        private string sqlDeleteAgenda = @"DELETE FROM Agenda WHERE idAgenda = @id";
        private string sqlDeleteAmizade = @"DELETE FROM Amizade WHERE idPessoaFisica = @id";
        private string sqlDeleteContatoFixo = @"DELETE FROM Contato_Fixo WHERE idEndereco = @id";
        private string sqlDeleteContatoMovelFisica = @"DELETE FROM Contato_Movel WHERE idPessoaFisica = @id";
        private string sqlDeleteContatoMovelJuridica = @"DELETE FROM Contato_Movel WHERE idPessoaJuridica = @id";
        private string sqlDeleteEnderecoFisica = @"DELETE FROM Endereco WHERE idPessoaFisica = @id";
        private string sqlDeleteEnderecoJuridica = @"DELETE FROM Endereco WHERE idPessoaJuridica = @id";
        private string sqlDeleteParente = @"DELETE FROM Parente WHERE idPessoaFisica = @id";
        private string sqlDeleteFisica = @"DELETE FROM Pessoa_Fisica WHERE idPessoaFisica = @id";
        private string sqlDeleteJuridica = @"DELETE FROM Pessoa_Juridica WHERE idPessoaJuridica = @id";

        //String de edição de dados
        private string sqlEditFisica = @"UPDATE Pessoa_Fisica SET ";
        private string sqlClausulaFisica = @" = @newCampo WHERE idPessoaFisica = @id";
        private string sqlEditJuridica = @"UPDATE Pessoa_Juridica SET ";
        private string sqlClausulaJuridica = @" = @newCampo WHERE idPessoaJuridica = @id";


        //Funções que retornam as strings para formção de querys
        public string insert(int flag)
        {
            switch (flag)
            {
                case 1:
                    return this.sqlInsertAgenda;
                    break;
                case 2:
                    return this.sqlInsertAmizade;
                    break;
                case 3:
                    return this.sqlInsertContatoFixo;
                    break;
                case 4:
                    return this.sqlInsertContatoMovel;
                    break;
                case 5:
                    return this.sqlInsertEmpresa;
                    break;
                case 6:
                    return this.sqlInsertEndereco;
                    break;
                case 7:
                    return this.sqlInsertParente;
                    break;
                case 8:
                    return this.sqlInsertPessoaFisica;
                    break;
                case 9:
                    return this.sqlInsertPessoaFisica1;
                    break;
                case 10:
                    return this.sqlInsertEndereco1;
                    break;
                case 11:
                    return this.sqlInsertEndereco2;
                    break;
                case 12:
                    return this.sqlInsertContatoMovel1;
                    break;
                case 13:
                    return this.sqlInsertContatoMovel2;
                    break;
                default:
                    return "";
                    break;
            }
        }

        public string selectId(int flag)
        {
            switch (flag)
            {
                case 1:
                    return this.sqlSelectIdAgenda;
                    break;
                case 2:
                    return this.sqlSelectIdAmizade;
                    break;
                case 3:
                    return this.sqlSelectIdContatoFixo;
                    break;
                case 4:
                    return this.sqlSelectIdContatoMovel;
                    break;
                case 5:
                    return this.sqlSelectIdEndereco;
                    break;
                case 6:
                    return this.sqlSelectIdParente;
                    break;
                case 7:
                    return this.sqlSelectIdPessoaFisica;
                    break;
                case 8:
                    return this.sqlSelectIdPessoaJuridica;
                    break;
                case 9:
                    return this.sqlSelectAgenda;
                    break;
                case 10:
                    return this.sqlSelectIdPessoaFisica1;
                    break;
                case 11:
                    return this.sqlSelectIdEnderecoFisica;
                    break;
                default:
                    return "";
                    break;
            }
        }

        public string delete(int flag)
        {
            switch (flag)
            {
                case 1:
                    return this.sqlDeleteAgenda;
                    break;
                case 2:
                    return this.sqlDeleteAmizade;
                    break;
                case 3:
                    return this.sqlDeleteContatoFixo;
                    break;
                case 4:
                    return this.sqlDeleteContatoMovelFisica;
                    break;
                case 5:
                    return this.sqlDeleteContatoMovelJuridica;
                    break;
                case 6:
                    return this.sqlDeleteEnderecoFisica;
                    break;
                case 7:
                    return this.sqlDeleteEnderecoJuridica;
                    break;
                case 8:
                    return this.sqlDeleteFisica;
                    break;
                case 9:
                    return this.sqlDeleteJuridica;
                    break;
                case 10:
                    return this.sqlDeleteParente;
                    break;
                default:
                    return "";
                    break;
            }
        }
        public string update(int flag)
        {
            switch (flag)
            {
                case 1:
                    return this.sqlEditFisica;
                    break;
                case 2:
                    return this.sqlEditJuridica;
                    break;
                case 3:
                    return this.sqlClausulaFisica;
                    break;
                case 4:
                    return this.sqlClausulaJuridica;
                    break;
                default:
                    return "";
                    break;
            }
        }
    }
}


/*
Obs.: Poderia ter sido feita uma única string para cada funcionalidade, onde o que poderia ser alterado
      seria os parâmetros passados 
*/