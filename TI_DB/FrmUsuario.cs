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
    public partial class FrmUsuario : Form
    {

        Classes.Usuario objCadUsuario = new Classes.Usuario();

       
        public FrmUsuario()
        {
            InitializeComponent();
        }
         
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Exibir();
        }
        public void Exibir()
        {
            DataTable data = objCadUsuario.Exibir();
            dataGridView1.DataSource = data;
        }
            private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objCadUsuario.IdUsuario = Convert.ToInt32(txtId.Text);
                objCadUsuario.Nome = txtNome.Text;
                String[] data = mktDtNasc.Text.Split('/');
                objCadUsuario.DtNasciemnto =  data[2] + '-' + data[1] + '-' + data[0];
                objCadUsuario.Tipo = rdb_A.Checked ? '1' : '2';
             
                objCadUsuario.NovoUsuario();
                MessageBox.Show("Usuário Cadastrado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            Exibir();

            txtId.Clear();
            txtNome.Clear();
            mktDtNasc.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregarCombo();
        }
        private void CarregarCombo()
        {
            objCadUsuario.IdUsuario = Convert.ToInt32(txtId.Text);
            DataTable data = objCadUsuario.CarregarUsuario();

            if (data.Rows.Count != 0)
            {
                txtNome.Text = data.Rows[0]["nome"].ToString();
                mktDtNasc.Text = data.Rows[0]["data_nascimento"].ToString();
                rdb_A.Checked = false;
                rdb_P.Checked = false;


            }
            else
            {
                MessageBox.Show("O usuário ainda não possui dados");

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            objCadUsuario.IdUsuario = Convert.ToInt32(txtId.Text);
            objCadUsuario.Excluir();
            MessageBox.Show("Usuario Apagada com Sucesso!!!");
            Exibir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objCadUsuario.IdUsuario = Convert.ToInt32(txtId.Text);
                objCadUsuario.Nome = txtNome.Text;
                String[] data = mktDtNasc.Text.Split('/');
                objCadUsuario.DtNasciemnto = data[2] + '-' + data[1] + '-' + data[0];
                objCadUsuario.Tipo = rdb_A.Checked ? '1' : '2';

                objCadUsuario.AlterarUsuario();
                MessageBox.Show("Usuário Alterado com Sucesso!!!");
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
