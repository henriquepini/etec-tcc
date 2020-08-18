using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmProgramaGustavo
{
    public class Denuncia
    {
        private int idDenuncia;
        public int IdDenuncia
        {
            get
            {
                return this.idDenuncia;
            }
            set
            {
                this.idDenuncia = value;
            }
        }
        private String nome;
        public String Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        private String cpf;
        public String Cpf
        {
            get
            {
                return this.cpf;
            }
            set
            {
                this.cpf = value;
            }
        }
        private DateTime data;
        public DateTime Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        private String tipo;
        public String Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        
        private String local;
        public String Local
        {
            get
            {
                return this.local;
            }
            set
            {
                this.local = value;
            }
        }
        private String pontoRefe;
        public String PontoRefe
        {
            get
            {
                return this.pontoRefe;
            }
            set
            {
                this.pontoRefe = value;
            }
        }
        private String descricao;
        public String Descricao
        {
            get
            {
                return this.descricao;
            }
            set
            {
                this.descricao = value;
            }
        }

        private String status;
        public String Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        private String parametro;
        public String Parametro
        {
            get
            {
                return this.parametro;
            }
            set
            {
                this.parametro = value;
            }
        }
        public Denuncia()
        {
            nome = "";
            cpf = "";
            data = new DateTime();
            tipo = "";
            local = "";
            pontoRefe = "";
            descricao = "";
            status = null;
        }
        public Denuncia(String nome, String cpf,DateTime data, String tipo, String local, String pontoRefe, String descricao, String status)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.data = data;
            this.tipo = tipo;
            this.local = local;
            this.pontoRefe = pontoRefe;
            this.descricao = descricao;
            this.status = status;
        }
        public override String ToString()
        {
            return "ID Denúncia: " + idDenuncia.ToString() + "\nNome: " + nome.ToString() + "\nCPF: " + cpf.ToString() + "\nData: " + data.ToString() +
                "\nTipo: " + tipo.ToString() + "\nLocal: " + local.ToString() + "\nReferência: " + pontoRefe.ToString() +
                "\nDescrição: " + descricao.ToString() + "\nStatus: " + status.ToString();
        }
        public Boolean Equals(Denuncia denu)
        {
            Boolean retorno = false;
            if (this.idDenuncia.Equals(denu.IdDenuncia) &&
                this.nome.Equals(denu.nome) &&
                this.cpf.Equals(denu.Cpf) &&
                this.data.Equals(denu.Data) &&
                this.tipo.Equals(denu.Tipo) &&
                this.local.Equals(denu.Local) &&
                this.pontoRefe.Equals(denu.pontoRefe) &&
                this.descricao.Equals(denu.Descricao) &&
                this.status.Equals(denu.Status))
                retorno = true;

            return retorno;
        }
    }
}
