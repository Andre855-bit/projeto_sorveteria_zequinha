using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;


namespace SoverteriaZequinha
{
    public partial class frmLogin : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario, senha;

            usuario = "calabreso";
            senha = "1234";

            if (txtUsuario.Text.Trim().Equals(usuario) && txtSenha.Text.Trim().Equals(senha)) {

                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();

            } else {

                MessageBox.Show("Usuario ou senha errados!", "Mensagem do sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                limparCampos();

            }

        }

        public void limparCampos() {

            txtSenha.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
            
                txtSenha.Focus();
            
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                btnEntrar.Focus();
            
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexao.obterConexao();

            MessageBox.Show("Banco de dados conectado");

            Conexao.fecharConexao();
            
        }
    }
}
