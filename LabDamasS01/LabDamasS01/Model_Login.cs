using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LabDamasS01
{
    public class Model_Login
    {
        public event MetodosRetornaBool RespostaConfirmacao;

        public string username { get; private set; }
        public string password { get; private set; }
        public string texto { get; private set; }
        //public string[] text { get; private set; }
        public bool flag { get; private set; }

        public Model_Login()
        {

        }

        public Model_Login(string user, string pass)
        {
            username = user;
            password = pass;
        }

        public void ConfirmaLogin(Model_Login user)
        {
     
            flag = false;
            StreamReader sr = new StreamReader("Registo.txt");
            texto = sr.ReadLine();
            sr.Close();
            string[] text = texto.Split(';');
            //nome = text[0];
            //pw = text[1];
            //jogador.username = text[0];
           // jogador.password = text[1];

            if(user.username == text[0] && user.password == text[1])
            {
                flag = true;
            }

            if (RespostaConfirmacao != null)
            {
                RespostaConfirmacao(flag);
            }

        }
    }
}
