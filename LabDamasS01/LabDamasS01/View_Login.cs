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
    public partial class View_Login : Form
    {
        public event MetodosComUmObjeto PedidoConfirmaLogin;

        public bool confirma { get; private set; }

        public View_Login()
        {
            Program.M_Login.RespostaConfirmacao += M_Login_RespostaConfirmacao;
            InitializeComponent();
        }

        private void M_Login_RespostaConfirmacao(bool flag)
        {
            confirma = flag;

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Model_Login novo = new Model_Login(txb_Username.Text,txb_Password.Text);

            if(PedidoConfirmaLogin != null)
            {
                PedidoConfirmaLogin(novo);
            }

            if (confirma == true)
            {
                this.Hide();
                txb_Username.Text = "";
                txb_Password.Text = "";
                Program.V_MenuInicial.ShowDialog();
                Program.V_MenuInicial.Hide();

                this.Show();
            }
            else
            {
                MessageBox.Show("Username ou password inválidas, tente registar ou recuperar password.", "ERRO", MessageBoxButtons.OK);
            }

        }

        private void buttonRegisto_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.V_Registo.ShowDialog();
            Program.V_Registo.Hide();

            this.Show();
        }

        private void buttonSairApli_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

