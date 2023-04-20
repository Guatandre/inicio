using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicio
{
    public partial class frmCadastro : Form
    {
        string cadastro;
        string senha;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string login, senha;

            login = txtEmail.Text;
            try
            {
                MailAddress loginValid = new MailAddress(login);
                this.cadastro = login;
            }
            catch
            {
                MessageBox.Show("O login não está no formáto valido para email");
            }
            senha = txtSenha.Text;
            if (senha.Length >= 8)
            {
                MessageBox.Show("Senha valida");
                this.senha = senha;
            }
            else
            {
                MessageBox.Show("Senha invalida");
            }

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            String login = txtEmail.Text;
            String senha = txtSenha.Text;

            if ((this.cadastro.Equals(login)) && (this.senha.Equals(senha)))
            {



                frmInicio inicio = new frmInicio();
                inicio.Show();
            }
        }
    }
}
    

