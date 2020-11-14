namespace TI_DB
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_P = new System.Windows.Forms.RadioButton();
            this.rdb_A = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.mktDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_P);
            this.groupBox1.Controls.Add(this.rdb_A);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(48, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de pessoa:";
            // 
            // rdb_P
            // 
            this.rdb_P.AutoSize = true;
            this.rdb_P.Location = new System.Drawing.Point(99, 25);
            this.rdb_P.Name = "rdb_P";
            this.rdb_P.Size = new System.Drawing.Size(85, 20);
            this.rdb_P.TabIndex = 3;
            this.rdb_P.Text = "Professor";
            this.rdb_P.UseVisualStyleBackColor = true;
            // 
            // rdb_A
            // 
            this.rdb_A.AutoSize = true;
            this.rdb_A.Checked = true;
            this.rdb_A.Location = new System.Drawing.Point(15, 25);
            this.rdb_A.Name = "rdb_A";
            this.rdb_A.Size = new System.Drawing.Size(63, 20);
            this.rdb_A.TabIndex = 2;
            this.rdb_A.TabStop = true;
            this.rdb_A.Text = "Aluno";
            this.rdb_A.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(48, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(173, 207);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(48, 99);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // mktDtNasc
            // 
            this.mktDtNasc.Location = new System.Drawing.Point(48, 151);
            this.mktDtNasc.Mask = "00/00/0000";
            this.mktDtNasc.Name = "mktDtNasc";
            this.mktDtNasc.Size = new System.Drawing.Size(100, 20);
            this.mktDtNasc.TabIndex = 6;
            this.mktDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 245);
            this.Controls.Add(this.mktDtNasc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_P;
        private System.Windows.Forms.RadioButton rdb_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox mktDtNasc;
    }
}