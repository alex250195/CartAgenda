using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAgenda.DataBase
{
    public class Connect
    {
        //String de conexão com banco de dados
        private string strcon = @"Data Source=ALEXALVES;Initial Catalog=bdCartAgenda;Integrated Security=True";
        private SqlConnection connect;

        public Connect()
        {
            this.connect = new SqlConnection(this.strcon);//Instanciando objeto para conexão
        }

        public SqlConnection Connecting()
        {
            return this.connect;
        }

        public void OpenConnect()
        {
            this.connect.Open(); //Abrindo conexão
        }

        public void CloseConnect()
        {
            this.connect.Close();//Fechando conexão
        }
    }
}
