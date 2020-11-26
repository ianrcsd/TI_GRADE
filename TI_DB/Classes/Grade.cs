using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;


namespace TI_DB.Classes
{
    class Grade
    {

        Classes.DAL objDAL = new Classes.DAL();



        private int idGrade;
        private int idDisciplina;
        private int dia_semana;

        public int IdGrade { get => idGrade; set => idGrade = value; }
        public int IdDisciplina { get => idDisciplina; set => idDisciplina = value; }
        public int Dia_semana { get => dia_semana; set => dia_semana = value; }

        public DataTable CarregarGrade()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM disciplina WHERE id='{0}'", idDisciplina);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }

        public void NovaGrade()
        {

            objDAL.Conectar();
            string sql = String.Format("insert into grade (id,id_disciplina,dia_semana) VALUES('{0}','{1}','{2}')",

                idGrade, idDisciplina, dia_semana);
            objDAL.ExecutarComandoSQL(sql);

        }


        public void Excluir()
        {
            objDAL.Conectar();

            string sql = string.Format("DELETE FROM grade WHERE id ='{0}'", idGrade);
            objDAL.ExecutarComandoSQL(sql);

        }

        public void AlterarGrade()
        {

            objDAL.Conectar();
            string sql = String.Format("UPDATE grade SET id_disciplina = '{0}', dia_semana = '{1}'  WHERE id = '{2}'", idDisciplina, Dia_semana, IdGrade);
            objDAL.ExecutarComandoSQL(sql);


        }

    }
}
