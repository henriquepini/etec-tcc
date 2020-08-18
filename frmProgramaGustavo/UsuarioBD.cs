using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmProgramaGustavo
{
    public class UsuarioBD
    {
        Conexao con;

        public UsuarioBD()
        {
            con = new Conexao();
        }

        //TESTAR LOGIN
        public Boolean conecta(Usuario usu)
        {
            Boolean retorno = false;
            DataTable usuarioDt;
            usuarioDt = con.executaComandoR(String.Concat("SELECT * from USUARIO where LOGIN='", usu.Login, "' AND SENHA='", usu.Senha, "';"));
            if (usuarioDt.Rows.Count > 0)
                retorno = true;
            return retorno;
        }
    }
    
}
