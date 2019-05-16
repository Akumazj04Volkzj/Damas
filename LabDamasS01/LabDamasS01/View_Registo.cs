using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDamasS01
{
    public partial class View_Registo : Form
    {
        public event MetodosComUmJogador PedidoGuardarJogador;

        public View_Registo()
        {
            InitializeComponent();
        }

        private void ButRegistar_Click(object sender, EventArgs e)
        {
            string pais;
            pais = Convert.ToString(cmbox_pais.SelectedItem);

            Model_Jogador jogador = new Model_Jogador(txb_nome.Text,txb_email.Text, pais, txb_User.Text, txb_pw.Text);

            if(PedidoGuardarJogador != null)
            {
                PedidoGuardarJogador(jogador);
            }

            MessageBox.Show("Registo guardado", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButCanc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O registo não irá ser guardado","CANCELAR",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked == true)
            {
                txb_pw.PasswordChar = char.MinValue;
            }
            else
            {
                txb_pw.PasswordChar = '*';
            }
        }
    }
}
