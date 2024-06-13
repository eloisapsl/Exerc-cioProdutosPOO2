using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudosProvaB2
{
    public partial class formLogin : Form
    {
        public formHome origem;
        public formLogin(formHome origem)
        {
            InitializeComponent();
            this.origem = origem;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbxTermos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbUser.Text.ToString() == "admin" &&
               txbSenha.Text.ToString() == "1234" &&
               cbxTermos.Checked == true)
            {
                MessageBox.Show("Login realizado com sucesso!", "Login Realizado",MessageBoxButtons.OK);
                origem.btnAdicionar.Enabled = true;
                origem.btnRemover.Enabled = true;
                origem.label1.Text = "Olá, administrador...";
                origem.btnLogin.Text = "Sair";
                this.Close();
            }
            else
            {
                MessageBox.Show("Insira um usuário válido.", "Usuário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
