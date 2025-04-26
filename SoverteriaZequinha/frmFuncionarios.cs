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
using MosaicoSolutions.ViaCep;


namespace SoverteriaZequinha
{
    public partial class frmFuncionarios : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
            //executando método desabilitar campos
            desabilitandoCampos();
        }

        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            //executando método desabilitar campos
            desabilitandoCampos();
            txtNome.Text = nome;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionario abrir = new frmPesquisarFuncionario();
            abrir.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("")
                || txtEmail.Text.Equals("")
                 || mskCPF.Text.Equals("   .   .   -")
                 || cbbFuncao.Text.Equals("")
                 || mskTelefona.Text.Equals("     -")
                 || mskCEP.Text.Equals("     -")
                 || txtComplemento.Text.Equals("")
                 || txtLogradouro.Text.Equals("")
                 || txtCidade.Text.Equals("")
                 || txtNumero.Text.Equals("")
                 || txtBairro.Text.Equals(""))

            {
                MessageBox.Show("Favor inserir valores!!!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitandoCampos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        //Criando um método de busca cep

        public void buscaCEP(string cep) {

            var viaCEPService = ViaCepService.Default();

            var endereco = viaCEPService.ObterEndereco(cep);
            txtLogradouro.Text = endereco.Logradouro;
            txtCidade.Text = endereco.Localidade;
            txtComplemento.Text = endereco.Complemento;
            cbbUF.Text = endereco.UF;
            cbbEstado.Text = endereco.UF;
            txtBairro.Text = endereco.Bairro;
        }


        //desabilitando os compomentes

        public void desabilitandoCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtLogradouro.Enabled = false;
            txtCidade.Enabled = false;
            txtCodigo.Enabled = false;
            txtComplemento.Enabled = false;
            txtNumero.Enabled = false;
            mskCEP.Enabled = false;
            mskCPF.Enabled = false;
            mskTelefona.Enabled = false;
            cbbEstado.Enabled = false;
            cbbFuncao.Enabled = false;
            cbbUF.Enabled = false;
            txtBairro.Enabled = false;

            dtpDataNasc.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }

        public void habilitandoCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtLogradouro.Enabled = true;
            txtCidade.Enabled = true;
            txtCodigo.Enabled = false;
            txtComplemento.Enabled = true;
            txtNumero.Enabled = true;
            mskCEP.Enabled = true;
            mskCPF.Enabled = true;
            mskTelefona.Enabled = true;
            cbbEstado.Enabled = true;
            cbbFuncao.Enabled = true;
            cbbUF.Enabled = true;
            txtBairro.Enabled = true;

            dtpDataNasc.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;

        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //buscando o endereço pelo CEP
                buscaCEP(mskCEP.Text);
                txtNumero.Focus();
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                txtComplemento.Focus();
            }
        }
    }
}
