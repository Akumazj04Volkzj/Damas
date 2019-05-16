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
    public partial class View_Tabuleiro : Form
    {
        public View_Tabuleiro()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.V_Perfil.ShowDialog();
            Program.V_Perfil.Hide();

            this.Show();

        }

        private void pictureBox(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Program.V_Perfil.ShowDialog();
            Program.V_Perfil.Hide();

            this.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {


           // button29.BackgroundImage.Tag 
        }
    }
}
