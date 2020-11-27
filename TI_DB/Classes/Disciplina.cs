using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace TI_DB
{
    class Disciplina
    {

        Classes.DAL objDAL = new Classes.DAL();
       


        private int idDisciplina;
        private string nome;
        private string horario;
        private int idProfessor;

        public int IdDisciplina { get => idDisciplina; set => idDisciplina = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Horario { get => horario; set => horario = value; }
        public int IdProfessor { get => idProfessor; set => idProfessor = value; }

        public DataTable CarregarDisciplina()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM disciplina WHERE id='{0}'", idDisciplina);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }
        public DataTable CarregarDisciplina1(int id)
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM disciplina WHERE id='{0}'", id);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }
        public DataTable ExibirD()
        {
            objDAL.Conectar();
            DataTable data = objDAL.RetDataTable(" select * FROM disciplina ");
            return data;

        }

        public DataTable ListarDisciplina()
        {
            objDAL.Conectar();
            return objDAL.RetDataTable("select id, nome from disciplina;");
        }

        public void NovaDisciplina()
        {

            objDAL.Conectar();
            string sql = String.Format("insert into disciplina (id,nome,horario,id_professor) VALUES('{0}','{1}','{2}','{3}')",
            
                idDisciplina, Nome, Horario, IdProfessor);
            objDAL.ExecutarComandoSQL(sql);    
            
        }


        public void Excluir(int id)
        {
            objDAL.Conectar();            
           
            string sql = string.Format("DELETE FROM disciplina WHERE id ='{0}'", id);
            objDAL.ExecutarComandoSQL(sql);

        }

        public void AlterarDisciplina()
        {

            objDAL.Conectar();
            string sql = String.Format("UPDATE disciplina SET nome = '{0}', horario = '{1}', id_professor = '{2}'  WHERE id = '{3}'", Nome, Horario, idProfessor, idDisciplina);
            objDAL.ExecutarComandoSQL(sql);


        }



    }
}
