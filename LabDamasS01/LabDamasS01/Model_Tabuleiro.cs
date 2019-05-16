using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDamasS01
{
    public class Model_Tabuleiro
    {

        public int Linhas { get; private set; }
        public int Colunas { get; private set; }
        public Model_Pedras Mat { get; private set; }
        public int NumPedrasBrancas { get; private set; }
        public int NumPedrasPretas { get; private set; }

        public Model_Jogo Model_Jogo
        {
            get => default(Model_Jogo);
            set
            {
            }
        }
    }
}
