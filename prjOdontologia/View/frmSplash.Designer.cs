
namespace prjOdontologia
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pbxImgsplash = new System.Windows.Forms.PictureBox();
            this.pbCarrega = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgsplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImgsplash
            // 
            this.pbxImgsplash.Image = ((System.Drawing.Image)(resources.GetObject("pbxImgsplash.Image")));
            this.pbxImgsplash.Location = new System.Drawing.Point(-6, 0);
            this.pbxImgsplash.Name = "pbxImgsplash";
            this.pbxImgsplash.Size = new System.Drawing.Size(736, 617);
            this.pbxImgsplash.TabIndex = 0;
            this.pbxImgsplash.TabStop = false;
            // 
            // pbCarrega
            // 
            this.pbCarrega.Location = new System.Drawing.Point(-6, 612);
            this.pbCarrega.Name = "pbCarrega";
            this.pbCarrega.Size = new System.Drawing.Size(736, 45);
            this.pbCarrega.TabIndex = 1;
            this.pbCarrega.Click += new System.EventHandler(this.pbCarrega_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 655);
            this.Controls.Add(this.pbCarrega);
            this.Controls.Add(this.pbxImgsplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbxImgsplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImgsplash;
        private System.Windows.Forms.ProgressBar pbCarrega;
        private System.Windows.Forms.Timer timer1;
    }
}

