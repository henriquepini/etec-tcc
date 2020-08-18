using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace frmProgramaGustavo
{
    public class DenunciaBD
    {
        Conexao con;

        public DenunciaBD()
        {
            con = new Conexao();
        }

        //CONSULTAR sem filtro
        public DataTable consulta()
        {
            return con.executaComandoR("SELECT * FROM DENUNCIA;");
        }

        //INCLUIR
        public Boolean inclui(Denuncia denu)
         {
            DateTime date = (DateTime)denu.Data;
              return con.executaComando(String.Concat("INSERT INTO DENUNCIA VALUES(null,'", denu.Nome.ToString(), "','", denu.Cpf.ToString(), "','"
                   , denu.Data.Year.ToString(), "-", denu.Data.Month.ToString(), "-", denu.Data.Day.ToString(), "','"
                   , denu.Tipo.ToString(), "','", denu.Local.ToString(), "','", denu.Descricao.ToString(), "','"
                   , denu.PontoRefe.ToString(), "','",denu.Status.ToString(),"');"));
         }

        //ALTERAR
        public Boolean altera(Denuncia denu)
        {
            DateTime Data = (DateTime)denu.Data;
            return con.executaComando(String.Concat("UPDATE DENUNCIA SET Nome='", denu.Nome.ToString() , "',CPF='", denu.Cpf.ToString(),
                "',Data='", Data.Year.ToString(), "-", Data.Month.ToString(), "-", Data.Day.ToString(), "',Tipo='", denu.Tipo.ToString(),
                 "',Local='", denu.Local.ToString(), "',Descricao='", denu.Descricao.ToString(), "',Ponto_Refe='", denu.PontoRefe.ToString(),
                "',Status='", denu.Status.ToString() , "' WHERE ID_Denun=", denu.IdDenuncia.ToString(), ";"));
        }

        //EXCLUIR
        public Boolean exclui(Denuncia denu)
        {
            return con.executaComando(String.Concat("DELETE FROM DENUNCIA WHERE ID_Denun= ", denu.IdDenuncia.ToString(), ";"));
        }

        //CONSULTAR FILTRADO
        public DataTable consulta(Denuncia denu,String operacao)
        {
            DateTime Data = (DateTime)denu.Data;
            DataTable retorno;
            if (denu.IdDenuncia > 0)
            {
                retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE id_denun= ", denu.IdDenuncia.ToString(), ";"));
            }
            else
            {
                if (denu.Nome.Length > 0)
                {
                    retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE NOME='", denu.Nome.ToString(),"';"));
                }
                else
                {
                    if (denu.Cpf.Length > 0)
                    {
                        retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE CPF='", denu.Cpf.ToString(), "';"));
                    }
                    else
                    {
                        if (denu.Tipo.Length > 0)
                        {
                            retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE TIPO='", denu.Tipo.ToString(), "';"));
                        }
                        else
                        {
                            if(denu.Local.Length > 0)
                            {
                                retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE LOCAL='", denu.Local.ToString(), "';"));
                            }
                            else
                            {
                                if(denu.Descricao.Length > 0)
                                {
                                    retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE DESCRICAO='", denu.Descricao.ToString(), "';"));
                                }
                                else
                                {
                                    if (denu.PontoRefe.Length > 0)
                                    {
                                        retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE PONTO_REFE='", denu.PontoRefe.ToString(), "';"));
                                    }
                                    else
                                    {
                                        if (denu.Status != null)
                                        {
                                            retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE STATUS='", denu.Status.ToString(), "';"));
                                        }
                                        else
                                        {
                                            if(Data.ToString() == "{01/01/0001 00:00:00}")
                                            {
                                                retorno = con.executaComandoR(String.Concat("SELECT * FROM DENUNCIA WHERE DATA='", Data.Year.ToString(), "-", Data.Month.ToString(), "-", Data.Day.ToString(), "';"));
                                            }
                                            else
                                            {
                                                retorno = con.executaComandoR(String.Concat("SELECT * FROM denuncia WHERE '", denu.Parametro.ToString(), "' in (Nome, Tipo, Local, Descricao, Ponto_Refe, Status);"));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if(operacao == "Filtro")
            {
            }
            else
            {
                if(operacao == "Consulta")
                {
                    if (retorno.Rows.Count > 0)
                    {
                        denu.IdDenuncia = Int32.Parse(retorno.Rows[0][0].ToString());
                        denu.Nome = retorno.Rows[0][1].ToString();
                        denu.Cpf = retorno.Rows[0][2].ToString();
                        denu.Data = DateTime.Parse(retorno.Rows[0][3].ToString());
                        denu.Tipo = retorno.Rows[0][4].ToString();
                        denu.Local = retorno.Rows[0][5].ToString();
                        denu.Descricao = retorno.Rows[0][6].ToString();
                        denu.PontoRefe = retorno.Rows[0][7].ToString();
                        denu.Status = retorno.Rows[0][8].ToString();
                    }
                }
            }
            return retorno;
        }
    }
}
