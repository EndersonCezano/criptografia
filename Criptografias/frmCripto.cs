using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografias
{
    public partial class frmCripto : Form
    {
        CryptProvider providerSelecionado = CryptProvider.Rijndael;

        public frmCripto()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            string texto = txtNormal.Text;
            string chave = txtKey.Text;

            Cripto crip = new Cripto(providerSelecionado, chave);
            txtCriptografado.Text = crip.Encrypt(texto);
        }

        private void btnDecriptar_Click(object sender, EventArgs e)
        {
            string texto = txtCriptografado.Text;
            string chave = txtKey.Text;

            Cripto crip = new Cripto(providerSelecionado, chave);
            MessageBox.Show(crip.Decrypt(texto), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            var index = int.Parse(rb.Tag.ToString());
            if (rb.Checked) providerSelecionado = (CryptProvider)index;
        }
    }
}
