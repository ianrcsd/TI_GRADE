using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;


namespace TI_DB.Classes
{
    class Semestre
    {
        Classes.DAL objDAL = new Classes.DAL();



        private int idTurma;
     
        private int idProfessor;

        public int IdTurma { get => idTurma; set => idTurma = value; }   
        public int IdProfessor { get => idProfessor; set => idProfessor = value; }

        public DataTable CarregarSemestre()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM semestre WHERE id='{0}'", IdTurma);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }

        public void NovoSemestre()
        {

            objDAL.Conectar();
            string sql = String.Format("insert into semestre (id_turma,id_professor) VALUES('{0}','{1}')",

                IdTurma,IdProfessor);
            objDAL.ExecutarComandoSQL(sql);

        }

        public DataTable Exibir()
        {
            objDAL.Conectar();
            DataTable data = objDAL.RetDataTable(" select * FROM semestre ");
            return data;

        }


        public void Excluir()
        {
            objDAL.Conectar();

            string sql = string.Format("DELETE FROM turma WHERE id ='{0}'", IdTurma);
            objDAL.ExecutarComandoSQL(sql);

        }

        public void AlterarTurma()
        {

            objDAL.Conectar();
            string sql = String.Format("UPDATE grade SET id = '{0}' WHERE id = '{1}'", idTurma, IdTurma);
            objDAL.ExecutarComandoSQL(sql);


        }
    }
}
