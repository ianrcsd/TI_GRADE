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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario cadUsuario = new FrmUsuario();
            cadUsuario.MdiParent = this;
            cadUsuario.Show();
        }

        private void doarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisciplina frmDisciplina = new FrmDisciplina();
            frmDisciplina.MdiParent = this;
            frmDisciplina.Show();
        }

        private void departamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmDepartamaneto = new FrmDepartamento();
            frmDepartamaneto.MdiParent = this;
            frmDepartamaneto.Show();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTurmas frm = new FrmTurmas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
