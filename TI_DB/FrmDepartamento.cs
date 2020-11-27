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
            Exibir();
        }
        public void Exibir()
        {
            DataTable data = objDepartamento.Exibir();
            dataGridView1.DataSource = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarCombo();
        }
        private void CarregarCombo()
        {
            objDepartamento.IdDepartamento = Convert.ToInt32(txtId.Text);
            DataTable data = objDepartamento.CarregarDepartamento();

            if (data.Rows.Count != 0)
            {
                txtNome.Text = data.Rows[0]["nome"].ToString();              
               


            }
            else
            {
                MessageBox.Show("O Departamento ainda não possui dados");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            objDepartamento.IdDepartamento = Convert.ToInt32(txtId.Text);
            objDepartamento.Excluir();
            MessageBox.Show("Departamento Apagado com Sucesso!!!");
            Exibir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objDepartamento.IdDepartamento = Convert.ToInt32(txtId.Text);
                objDepartamento.Nome = txtNome.Text;
                objDepartamento.IdDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);
                objDepartamento.AlterarDep();
                MessageBox.Show("Departaemnto Alterado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();
        }
    }
}
