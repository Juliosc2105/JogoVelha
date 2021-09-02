using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Form1 : Form
    {
        string jogador = "X";

        int jogX = 0, jogO = 0, empate = 0;
        int totalClicks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoClicado (object sender, EventArgs e)
        {
            Button b = (Button) sender;

            totalClicks++;
            lblteste.Text = totalClicks.ToString();

            if((jogador == "X") && b.Text == "")
            {
                b.Text = jogador;
                vencedor();
                jogador = "O";
            }
            else
            {
                if(b.Text == "")
                {
                    b.Text = jogador;
                    vencedor();
                    jogador = "X";
                }
            } 
        }

        private void vencedor()
        {
                //1, 2, 3
            if (((btn1.Text == jogador) && (btn2.Text == jogador) && (btn3.Text == jogador)) ||
                //4, 5, 6
                ((btn4.Text == jogador) && (btn5.Text == jogador) && (btn6.Text == jogador)) ||
                //7, 8, 9
                ((btn7.Text == jogador) && (btn8.Text == jogador) && (btn9.Text == jogador)) ||
                //1, 4, 7
                ((btn1.Text == jogador) && (btn4.Text == jogador) && (btn7.Text == jogador)) ||
                //2, 5, 8
                ((btn2.Text == jogador) && (btn5.Text == jogador) && (btn8.Text == jogador)) ||
                //3, 6, 9
                ((btn3.Text == jogador) && (btn6.Text == jogador) && (btn9.Text == jogador)) ||
                //1, 5, 9
                ((btn1.Text == jogador) && (btn5.Text == jogador) && (btn9.Text == jogador)) ||
                //3, 5, 7
                ((btn3.Text == jogador) && (btn5.Text == jogador) && (btn7.Text == jogador)))
            {
                if (jogador == "X")
                {
                    jogX++;
                }else
                {
                    jogO++;
                }
                lblO.Text = jogO.ToString();
                lblX.Text = jogX.ToString();
                limpatela();

            }else if(totalClicks == 9)
            {
                empate++;
                lblEmpate.Text = empate.ToString();
                limpatela();
            }
        }
        private void limpatela()
        {

        }
    }
}
