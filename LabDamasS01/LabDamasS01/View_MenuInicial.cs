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
    public partial class View_MenuInicial : Form
    {
        public View_MenuInicial()
        {
            InitializeComponent();
        }

        private void ButPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            Program.V_Tabuleiro.ShowDialog();
            Program.V_Tabuleiro.Hide();

            this.Show();

        }

        private void ButStat_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.V_Perfil.ShowDialog();
            Program.V_Perfil.Hide();

            this.Show();
        }

        private void ButRules_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Regras_Damas_Clássicas_.pdf");
        }

        private void View_MenuInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
