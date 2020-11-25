using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_DB
{
    public partial class FrmDisciplina : Form
    {
        Disciplina objDisciplina = new Disciplina();
        Classes.Usuario objUsuario = new Classes.Usuario();
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            CarregarProfessor();
        }

        public void CarregarProfessor()
        {
            DataTable data = new DataTable();

            data = objUsuario.ListarProfessor();


            cmbProfessor.DataSource = data;
            cmbProfessor.ValueMember = "id";
            cmbProfessor.DisplayMember = "nome";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            

            try
            {
                objDisciplina.IdDisciplina = Convert.ToInt32(txtId.Text);
                objDisciplina.Nome = txtNome.Text;
                objDisciplina.Horario = mktHorario.Text;
                objDisciplina.IdProfessor = Convert.ToInt32(cmbProfessor.SelectedValue);
                objDisciplina.NovaDisciplina();
                MessageBox.Show("Disciplina Cadastrado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
