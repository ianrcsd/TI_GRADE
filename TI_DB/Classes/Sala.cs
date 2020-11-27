using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;


namespace TI_DB.Classes
{
    class Sala
    {
        Classes.DAL objDAL = new Classes.DAL();



        private int idSala;
        private int idTurma;
        public int IdSala { get => idSala; set => idSala = value; }
        public int IdTurma { get => idTurma; set => idTurma = value; }

        public DataTable CarregarSala()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM sala WHERE id='{0}'", IdSala);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }

        public DataTable Exibir()
        {
            objDAL.Conectar();
            DataTable data = objDAL.RetDataTable(" select * FROM sala ");
            return data;

        }

        public void NovaSala()
        {

            objDAL.Conectar();
            string sql = String.Format("insert into sala (id,id_turma) VALUES('{0}','{1}')",

                IdSala,IdTurma);
            objDAL.ExecutarComandoSQL(sql);

        }


        public void Excluir()
        {
            objDAL.Conectar();

            string sql = string.Format("DELETE FROM sala WHERE id ='{0}'", IdSala);
            objDAL.ExecutarComandoSQL(sql);

        }

        public void AlterarSala()
        {

            objDAL.Conectar();
            string sql = String.Format("UPDATE grade SET id_turma = '{0}' WHERE id = '{1}'", IdTurma, IdSala);
            objDAL.ExecutarComandoSQL(sql);


        }
     

    }
}
