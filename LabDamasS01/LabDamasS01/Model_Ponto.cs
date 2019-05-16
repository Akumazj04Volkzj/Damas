using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDamasS01
{
    public class Model_Ponto
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Model_Pedras Model_Pedras
        {
            get => default(Model_Pedras);
            set
            {
            }
        }
    }
}
