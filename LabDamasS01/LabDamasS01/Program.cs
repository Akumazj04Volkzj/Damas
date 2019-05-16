using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDamasS01
{
    static class Program
    {

        public static View_Login V_Login { get; private set; }
        public static View_MenuInicial V_MenuInicial { get; private set; }
        public static View_Perfil V_Perfil { get; private set; }
        public static View_Registo V_Registo { get; private set; }
        public static View_Regras V_Regras { get; private set; }
        public static View_Tabuleiro V_Tabuleiro { get; private set; }
        public static Model_Ponto M_Ponto { get; private set; }
        public static Model_Tabuleiro M_Tabuleiro { get; private set; }
        public static Model_Pedras M_Pedras { get; private set; }
        public static Model_Jogador M_Jogador { get; private set; }
        public static Model_Jogo M_Jogo { get; private set; }
        public static Model_Login M_Login { get; private set; }
        public static Model_Registo M_Registo { get; private set; }
        public static Controller C_Login { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Models
            M_Ponto = new Model_Ponto();
            M_Pedras = new Model_Pedras();
            M_Tabuleiro = new Model_Tabuleiro();
            M_Jogador = new Model_Jogador();
            M_Jogo = new Model_Jogo();
            M_Login = new Model_Login();
            M_Registo = new Model_Registo();
           

            //Views
            V_Login = new View_Login();
            V_MenuInicial = new View_MenuInicial();
            V_Perfil = new View_Perfil();
            V_Registo = new View_Registo();
            V_Regras = new View_Regras();
            V_Tabuleiro = new View_Tabuleiro();

            //Controllers
            C_Login = new Controller();

            Application.Run(V_Login);
        }
    }
}
