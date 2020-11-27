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
        Classes.Grade objGrade = new Classes.Grade();
        Classes.Turma objTurma = new Classes.Turma();
        Classes.Semestre objSemestre = new Classes.Semestre();
        Classes.Sala objSala = new Classes.Sala();
        public FrmDisciplina()
        {
            InitializeComponent();
        }

        private void FrmDisciplina_Load(object sender, EventArgs e)
        {
            CarregarProfessor();
            CarregarDisciplina();
            CarregarTurma();
            Exibir();
        }

        public void Exibir()
        {
            DataTable data = objDisciplina.ExibirD();
            dtg_disciplina.DataSource = data;

            DataTable data1 = objGrade.Exibir();
            dataGridView1.DataSource = data1;

            DataTable data2 = objSemestre.Exibir();
            dataGridView2.DataSource = data2;

            DataTable data3 = objSala.Exibir();
            dataGridView3.DataSource = data3;
        }

        public void CarregarProfessor()
        {
            DataTable data = new DataTable();

            data = objUsuario.ListarProfessor();


            cmbProfessor.DataSource = data;
            cmbProfessor.ValueMember = "id";
            cmbProfessor.DisplayMember = "nome";
        }
        public void CarregarDisciplina()
        {
            DataTable data = new DataTable();

            data = objDisciplina.ListarDisciplina();


            cmbDisciplina.DataSource = data;
            cmbDisciplina.ValueMember = "id";
            cmbDisciplina.DisplayMember = "nome";
        }
        public void CarregarTurma()
        {
            DataTable data = new DataTable();
            DataTable data1 = new DataTable();
           // DataTable data3 = new DataTable();

            data = objUsuario.ListarProfessor();
            data1 = objTurma.ListarTurma();
            


            cmbProfesorSemestre.DataSource = data;
            cmbProfesorSemestre.ValueMember = "id";
            cmbProfesorSemestre.DisplayMember = "nome";

            cmbTurmaSemestre.DataSource = data1;
            cmbTurmaSemestre.ValueMember = "id";
            cmbTurmaSemestre.DisplayMember = "id";

            cmbTurmaSala.DataSource = data1;
            cmbTurmaSala.ValueMember = "id";
            cmbTurmaSala.DisplayMember = "id";


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
            Exibir();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarGrafo_Click(object sender, EventArgs e)
        {
            try
            {
                objGrade.IdGrade = Convert.ToInt32(txtIdGrade.Text);
                objGrade.Dia_semana = Convert.ToInt32(mkt_DiaSemana.Text);                
                objGrade.IdDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);
                objGrade.NovaGrade();
                MessageBox.Show("Grafo Cadastrado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            try
            {
                objSemestre.IdTurma = Convert.ToInt32(cmbTurmaSemestre.SelectedValue);
                objSemestre.IdProfessor = Convert.ToInt32(cmbProfesorSemestre.SelectedValue);

                objSemestre.NovoSemestre();
                MessageBox.Show("Semestre Cadastrado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objSala.IdSala = Convert.ToInt32(txtIdSala.Text);
                objSala.IdTurma = Convert.ToInt32(cmbTurmaSala.SelectedValue);

                objSala.NovaSala();
                MessageBox.Show("Sala Cadastrado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarComboClientes();
        }
        private void CarregarComboClientes()
        {
            DataTable data = objDisciplina.CarregarDisciplina1(Convert.ToInt32(txtId.Text));

            if (data.Rows.Count != 0)
            {          
                txtNome.Text = data.Rows[0]["nome"].ToString();
                mktHorario.Text = data.Rows[0]["horario"].ToString();
                            

            }
            else
            {
                MessageBox.Show("O usuário ainda não possui dados");

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objDisciplina.IdDisciplina = Convert.ToInt32(txtId.Text);
                objDisciplina.Nome = txtNome.Text;
                objDisciplina.Horario = mktHorario.Text;
                objDisciplina.IdProfessor = Convert.ToInt32(cmbProfessor.SelectedValue);
                objDisciplina.AlterarDisciplina();
                MessageBox.Show("Disciplina Alterada com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objDisciplina.Excluir(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Disciplina Apagada com Sucesso!!!");
            Exibir();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CarregarGrade();
        }
        private void CarregarGrade()
        {
            objGrade.IdGrade = Convert.ToInt32(txtIdGrade.Text);
            DataTable data = objGrade.CarregarGrade();

            if (data.Rows.Count != 0)
            {
                mkt_DiaSemana.Text = data.Rows[0]["dia_semana"].ToString();                


            }
            else
            {
                MessageBox.Show("O Grade ainda não possui dados");

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                objGrade.IdGrade = Convert.ToInt32(txtIdGrade.Text);
                objGrade.Dia_semana = Convert.ToInt32(mkt_DiaSemana.Text);
                objGrade.IdDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);
                objGrade.AlterarGrade();
                MessageBox.Show("Grafo Alterado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            objGrade.IdGrade = Convert.ToInt32(txtIdGrade.Text);
            objGrade.Excluir();
            MessageBox.Show("Grafo Apagada com Sucesso!!!");
            Exibir();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CarregarSala();
        }
        private void CarregarSala()
        {
            //objGrade.IdGrade = Convert.ToInt32(txtIdGrade.Text);
            //DataTable data = objGrade.CarregarGrade();

            //if (data.Rows.Count != 0)
            //{
            //    mkt_DiaSemana.Text = data.Rows[0]["dia_semana"].ToString();


            //}
            //else
            //{
            //    MessageBox.Show("O Grade ainda não possui dados");

            //}


        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                objSala.IdSala = Convert.ToInt32(txtIdSala.Text);
                objSala.IdTurma = Convert.ToInt32(cmbTurmaSala.SelectedValue);
                objSala.AlterarSala();
                MessageBox.Show("Sala Alterada com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            objSala.IdSala = Convert.ToInt32(txtIdSala.Text);
            objSala.Excluir();
            MessageBox.Show("Sala Apagada com Sucesso!!!");
            Exibir();
        }
    }
}
