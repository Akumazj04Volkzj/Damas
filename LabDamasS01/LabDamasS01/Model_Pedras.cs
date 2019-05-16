using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDamasS01
{

    public class Model_Pedras
    {
        public Model_Ponto Localizacao { get; private set; }
        public int Cor { get; private set; }
        public int NumJog { get; private set; }

        public Model_Tabuleiro Model_Tabuleiro
        {
            get => default(Model_Tabuleiro);
            set
            {
            }
        }
    }
}
