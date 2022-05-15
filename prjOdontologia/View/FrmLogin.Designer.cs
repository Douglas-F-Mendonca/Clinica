
namespace prjOdontologia
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.pbImgLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(36, 46);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(36, 93);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(109, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(109, 92);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(237, 20);
            this.txtsenha.TabIndex = 3;
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(109, 154);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(102, 34);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(244, 154);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(102, 34);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // pbImgLogin
            // 
            this.pbImgLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbImgLogin.Image")));
            this.pbImgLogin.Location = new System.Drawing.Point(381, 25);
            this.pbImgLogin.Name = "pbImgLogin";
            this.pbImgLogin.Size = new System.Drawing.Size(151, 142);
            this.pbImgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgLogin.TabIndex = 6;
            this.pbImgLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 222);
            this.Controls.Add(this.pbImgLogin);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pbImgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.PictureBox pbImgLogin;
    }
}