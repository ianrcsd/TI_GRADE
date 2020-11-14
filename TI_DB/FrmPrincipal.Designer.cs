namespace TI_DB
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receptorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.instituiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.doarToolStripMenuItem,
            this.instituiçõesToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.rankingToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(915, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.receptorToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.produtoToolStripMenuItem.Text = "Alimentos";
            // 
            // receptorToolStripMenuItem
            // 
            this.receptorToolStripMenuItem.Name = "receptorToolStripMenuItem";
            this.receptorToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.receptorToolStripMenuItem.Text = "Receptor";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // doarToolStripMenuItem
            // 
            this.doarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doarToolStripMenuItem1});
            this.doarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.doarToolStripMenuItem.Name = "doarToolStripMenuItem";
            this.doarToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.doarToolStripMenuItem.Text = "Doações";
            // 
            // doarToolStripMenuItem1
            // 
            this.doarToolStripMenuItem1.Name = "doarToolStripMenuItem1";
            this.doarToolStripMenuItem1.Size = new System.Drawing.Size(115, 24);
            this.doarToolStripMenuItem1.Text = "Doar";
            // 
            // instituiçõesToolStripMenuItem
            // 
            this.instituiçõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.instituiçõesToolStripMenuItem.Name = "instituiçõesToolStripMenuItem";
            this.instituiçõesToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.instituiçõesToolStripMenuItem.Text = "Receptores";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.estoqueToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffToolStripMenuItem,
            this.logoffToolStripMenuItem1});
            this.configuraçõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.configuraçõesToolStripMenuItem.Text = "Conta";
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.logoffToolStripMenuItem.Text = "Minha Conta";
            // 
            // logoffToolStripMenuItem1
            // 
            this.logoffToolStripMenuItem1.Name = "logoffToolStripMenuItem1";
            this.logoffToolStripMenuItem1.Size = new System.Drawing.Size(174, 24);
            this.logoffToolStripMenuItem1.Text = "Logoff";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 377);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instituiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem1;
    }
}

