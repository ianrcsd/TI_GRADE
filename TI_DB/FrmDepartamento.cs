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
    public partial class FrmDepartamento : Form
    {
        Classes.Departamento objDepartamento = new Classes.Departamento();
        Disciplina objDisciplina = new Disciplina();
        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CarregarDisciplina()
        {
            DataTable data = new DataTable();

            data = objDisciplina.ListarDisciplina();


            cmbDisciplina.DataSource = data;
            cmbDisciplina.ValueMember = "id";
            cmbDisciplina.DisplayMember = "nome";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objDepartamento.IdDepartamento = Convert.ToInt32(txtId.Text);
                objDepartamento.Nome = txtNome.Text;
                objDepartamento.IdDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);
                objDepartamento.NovoDepartamento();
                MessageBox.Show("Departaemnto Cadastrado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            CarregarDisciplina();
        }
    }
}
