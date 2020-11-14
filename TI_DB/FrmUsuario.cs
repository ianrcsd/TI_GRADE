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

        Classes.CadUsuario objCadUsuario = new Classes.CadUsuario();

       
        public FrmUsuario()
        {
            InitializeComponent();
        }
         
        private void FrmUsuario_Load(object sender, EventArgs e)
        {

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
        }
    }
}
