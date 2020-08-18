using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmProgramaGustavo
{
    public class Usuario
    {
        private String login;
        public String Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        private String senha;
        public String Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

        public Usuario()
        {
            login = "";
            senha = "";
        }

        public Usuario(String login, String senha)
        {
            this.login = login;
            this.senha = senha;
        }

        public override String ToString()
        {
            return "Login: " + login.ToString() + " - Senha: " + senha.ToString();
        }

        public Boolean Equals(Usuario usu)
        {
            Boolean retorno = false;
            if (this.login.Equals(usu.login) &&
                this.senha.Equals(usu.senha))
                retorno = true;

            return retorno;
        }
    }
}
