using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace TI_DB.Classes
{
    class Turma
    {
        Classes.DAL objDAL = new Classes.DAL();



        private int idTurma;

        public int IdTurma { get => idTurma; set => idTurma = value; }

        public DataTable CarregarTurma()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM turma WHERE id='{0}'", IdTurma);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }

        public void NovaTurma()
        {

            objDAL.Conectar();
            string sql = String.Format("insert into turma (id) VALUES('{0}')",

                IdTurma);
            objDAL.ExecutarComandoSQL(sql);

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
