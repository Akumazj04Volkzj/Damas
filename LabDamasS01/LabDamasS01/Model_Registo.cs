using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LabDamasS01
{
    public class Model_Registo
    {
        public Model_Registo()
        {

        }

        public void GuardaJogador(Model_Jogador jogador)
        {
            string file;
            file = jogador.Username + ".txt";

            StreamWriter sw = new StreamWriter(file);

            sw.WriteLine(jogador.Username);
            sw.WriteLine(jogador.Password);
            sw.WriteLine(jogador.Nome);
            sw.WriteLine(jogador.Email);
            sw.WriteLine(jogador.Nacionalidade);

            sw.Close();
        }
    }
}
