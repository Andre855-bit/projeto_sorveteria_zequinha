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


namespace SoverteriaZequinha
{
    public partial class frmPesquisarFuncionario : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmPesquisarFuncionario()
        {
            InitializeComponent();
        }

        public frmPesquisarFuncionario(string nome)
        {
            InitializeComponent();
            txtDescricao.Text = nome;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPesquisarFuncionario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void brnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Add(txtDescricao.Text);
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPesquisar.SelectedItem.ToString();
            frmFuncionarios abrir = new frmFuncionarios(nome);
            abrir.Show();
            this.Hide();
        }
    }
}
