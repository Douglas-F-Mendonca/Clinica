
namespace prjOdontologia
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.orçamentoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeFuncionárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastroDeFuncionárioToolStripMenuItem
            // 
            this.cadastroDeFuncionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionárioToolStripMenuItem,
            this.consultarFuncionárioToolStripMenuItem});
            this.cadastroDeFuncionárioToolStripMenuItem.Enabled = false;
            this.cadastroDeFuncionárioToolStripMenuItem.Name = "cadastroDeFuncionárioToolStripMenuItem";
            this.cadastroDeFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cadastroDeFuncionárioToolStripMenuItem.Text = "Cadastro de Funcionários";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.consultaClienteToolStripMenuItem});
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            this.novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            this.novoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.novoFuncionárioToolStripMenuItem.Text = "Novo funcionário";
            // 
            // consultarFuncionárioToolStripMenuItem
            // 
            this.consultarFuncionárioToolStripMenuItem.Name = "consultarFuncionárioToolStripMenuItem";
            this.consultarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultarFuncionárioToolStripMenuItem.Text = "Consultar funcionário";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            // 
            // consultaClienteToolStripMenuItem
            // 
            this.consultaClienteToolStripMenuItem.Name = "consultaClienteToolStripMenuItem";
            this.consultaClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultaClienteToolStripMenuItem.Text = "Consulta Cliente";
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarConsultaToolStripMenuItem,
            this.agendaDoDiaToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // agendarConsultaToolStripMenuItem
            // 
            this.agendarConsultaToolStripMenuItem.Name = "agendarConsultaToolStripMenuItem";
            this.agendarConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendarConsultaToolStripMenuItem.Text = "Agendar Consulta";
            // 
            // agendaDoDiaToolStripMenuItem
            // 
            this.agendaDoDiaToolStripMenuItem.Name = "agendaDoDiaToolStripMenuItem";
            this.agendaDoDiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendaDoDiaToolStripMenuItem.Text = "Agenda do Dia";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Odonto Sorriso - Especialistas em Odontologia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
    }
}