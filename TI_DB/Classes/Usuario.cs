using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace TI_DB.Classes
{
    class Usuario
    {
        DAL objDAL = new DAL();
       

        private int idUsuario;
        private string nome;
        private String dtNasciemnto;
        private char tipo;
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public String DtNasciemnto { get => dtNasciemnto; set => dtNasciemnto = value; }
        public char Tipo { get => tipo; set => tipo = value; }




        public DataTable CarregarUsuario()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM usuario WHERE id='{0}'", idUsuario);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }

        public DataTable ListarProfessor()
        {
            objDAL.Conectar();
            return objDAL.RetDataTable("select id, nome from USUARIO inner join professor on (id = id_usuario);");
        }

        public void NovoUsuario()
        {

            objDAL.Conectar();
            string sql = String.Format("insert into usuario (id,nome,data_nascimento) VALUES('{0}','{1}','{2}')",
            idUsuario,nome, dtNasciemnto);
            objDAL.ExecutarComandoSQL(sql);
            if (tipo == '1') //1 = aluno
            {
                string sql2 = String.Format("insert into aluno (id_usuario) VALUES('{0}')",
                idUsuario);
                objDAL.ExecutarComandoSQL(sql2);
            }
            else
            {
                string sql3 = String.Format("insert into professor (id_usuario) VALUES('{0}')",
                idUsuario);
                objDAL.ExecutarComandoSQL(sql3);
            }




        }
       

        public void Excluir()
        {
            objDAL.Conectar();
            if (tipo == 1) // 1 = aluno
            {
                string sql1 = string.Format("DELETE FROM aluno WHERE id_usuario ='{0}'", idUsuario);
                objDAL.ExecutarComandoSQL(sql1);
            }
            else
            {
                string sql1 = string.Format("DELETE FROM professor WHERE id_usuario ='{0}'", idUsuario);
                objDAL.ExecutarComandoSQL(sql1);
            }
            string sql = string.Format("DELETE FROM usuario WHERE id ='{0}'", idUsuario);
            objDAL.ExecutarComandoSQL(sql);

        }

        public void AlterarUsuario()
        {

            objDAL.Conectar();
            string sql = String.Format("UPDATE usuario SET nome = '{0}', data_nascimento = '{1}'  WHERE id = '{2}'", nome, dtNasciemnto, idUsuario);
            objDAL.ExecutarComandoSQL(sql);


        }


    }
}
