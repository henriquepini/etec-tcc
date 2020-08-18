using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace frmProgramaGustavo
{
    public class Conexao
    {
        private String connectionString;

        public Conexao()
        {
            //this.connectionString = "server=127.0.0.1;database=BancoTCC;uid=alunos;pwd='etec'";
            //this.connectionString = "server=127.0.0.1;database=BancoTCC;uid=root;pwd=''";
            this.connectionString = "server=127.0.0.1;database=BancoTCC;uid=henrique_pini;pwd='hm230200'";
        }

        public String getConnectionString()
        {
            return this.connectionString;
        }

        public Boolean executaComando(String comando)
        {
            if (comando.Length > 0)
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(this.getConnectionString());
                    Conn.Open();
                    MySqlCommand Cmd = new MySqlCommand(comando.ToString(), Conn);
                    int nroLinhasAfetadas = Cmd.ExecuteNonQuery();
                    Conn.Close();
                    if (nroLinhasAfetadas > 0)
                        return true;
                    else
                        return false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                    return false;
                }
            }
            else
                return false;
        }
        public DataTable executaComandoR(String comando)
        {
            DataTable dt = new DataTable();
            if (comando.Length > 0)
            {
                try
                {
                    MySqlConnection Conn = new MySqlConnection(this.getConnectionString());
                    Conn.Open();
                    MySqlCommand Cmd = new MySqlCommand(comando.ToString(), Conn);
                    MySqlDataReader rsComando = Cmd.ExecuteReader();
                    dt.Load(rsComando);
                    rsComando.Close();
                    Conn.Close();
                    return dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                    return null;
                }
            }
            else
                return null;
        }
    }
}
