﻿using System;
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
    public partial class FrmTurmas : Form
    {
        Classes.Turma objTurma = new Classes.Turma();
        public FrmTurmas()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                objTurma.IdTurma = Convert.ToInt32(txtId.Text);
                objTurma.NovaTurma();
                MessageBox.Show("Turma Cadastrado com Sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro ao finalizar o sistema: " + ex.Message.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            ExibirT();
        }

        private void FrmTurmas_Load(object sender, EventArgs e)
        {
            ExibirT();
        }
        public void ExibirT()
        {
            DataTable data = objTurma.ExibirT();
            dtg_instituicao.DataSource = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objTurma.IdTurma = Convert.ToInt32(txtId.Text);
            objTurma.Excluir();
            MessageBox.Show("Turma Apagada com Sucesso!!!");
            ExibirT();
        }
    }
}

