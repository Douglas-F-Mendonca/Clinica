using prjOdontologia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjOdontologia
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Controle control = new Controle();
            control.acessar(txtUsuario.Text, txtsenha.Text);
            if (control.mensagem.Equals(""))
            {

                // vai verificar se foi encontrado essa informação
                if (control.verificar)
                {
                    MessageBox.Show("Logado com sucesso!", "Logando...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //caso login seja encontrado, sera aberto form Menu
                    frmMenu frmMain = new frmMenu();
                    frmMain.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Login não encontrado!, verifique login e senha", "Falha ao logar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(control.mensagem);
            }
        }
    }
}
