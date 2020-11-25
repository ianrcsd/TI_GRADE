using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace TI_DB.Classes
{
    class Departamento
    {

        Classes.DAL objDAL = new Classes.DAL();



        private int idDepartamento;
        private string nome;      
        private int idDisciplina;

        
        
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
    
        public int IdDisciplina { get => idDisciplina; set => idDisciplina = value; }
        public string Nome { get => nome; set => nome = value; }

        public DataTable CarregarDepartamento()
        {


            objDAL.Conectar();
            string sql = String.Format("SELECT * FROM departamento WHERE id='{0}'", idDepartamento);
            DataTable data = objDAL.RetDataTable(sql);
            return data;


        }

        public DataTable ListarDepartamento()
        {
            objDAL.Conectar();
            return objDAL.RetDataTable("select id, nome from departamento;");
        }

        public void NovoDepartamento()
        {

            objDAL.Conectar();
            string sql = String.Format("insert into departamento (id,nome, id_disciplina) VALUES('{0}','{1}','{2}')",

                IdDepartamento, Nome, IdDisciplina);
            objDAL.ExecutarComandoSQL(sql);

        }


        public void Excluir()
        {
            objDAL.Conectar();

            string sql = string.Format("DELETE FROM departamento WHERE id ='{0}'", IdDepartamento);
            objDAL.ExecutarComandoSQL(sql);

        }

        public void AlterarDisciplina()
        {

            objDAL.Conectar();
            string sql = String.Format("UPDATE IdDepartamento SET nome = '{0}', id_disciplina = '{1}' WHERE id = '{2}'", Nome, IdDisciplina, IdDepartamento);
            objDAL.ExecutarComandoSQL(sql);


        }


    }
}
