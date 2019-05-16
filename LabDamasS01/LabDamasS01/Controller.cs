using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDamasS01
{
    public class Controller
    {
        public Controller()
        {
            Program.V_Login.PedidoConfirmaLogin += V_Login_PedidoConfirmaLogin;
            Program.V_Registo.PedidoGuardarJogador += V_Registo_PedidoGuardarJogador;
            Program.V_Registo.PedidoGuardarJogador += V_Registo_PedidoGuardarJogador1;
        }

        private void V_Registo_PedidoGuardarJogador1(Model_Jogador jogador)
        {
            Program.M_Registo.GuardaJogador(jogador);
        }

        private void V_Registo_PedidoGuardarJogador(Model_Jogador jogador)
        {
            Program.M_Registo.GuardaJogador(jogador);
        }

        private void V_Login_PedidoConfirmaLogin(Model_Login user)
        {
            Program.M_Login.ConfirmaLogin(user);
        }
    }
}
