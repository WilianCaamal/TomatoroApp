using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoroApp
{
    public partial class frmMain : Form
    {
        private int minutos = 59;
        private int segundos = 59;
        string tiempoRestante = String.Empty;
        bool pausa = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Timer.Start();
            if (pausa == true )
            {
                Timer.Stop();
                BtnIniciar.Text = "Iniciar";
                pausa = false;
            }
            else
            {
                Timer.Start();
                BtnIniciar.Text = "Pausar";
                pausa = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (minutos.ToString().Length == 1)
            {
                if (segundos.ToString().Length == 1)
                {
                    LbTiempo.Text = $" 0{minutos}:0{segundos}";
                }
                else
                {
                    LbTiempo.Text = $" 0{minutos}:{segundos}";
                }
            }
            else
            {
                LbTiempo.Text = $" {minutos}:{segundos}";
            }

            if (minutos != 0)
            {
                if (segundos != 0)
                {
                    segundos -= 1;
                }
                else
                {
                    minutos -= 1;
                    segundos = 59;
                }
            }
            else
            {
                if (segundos != 0)
                {
                    segundos -= 1;
                }
                else
                {
                    Timer.Stop();
                    BtnIniciar.Text = "Iniciar";
                    MessageBox.Show("Tiempo Terminado");
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            minutos = 1;
            segundos = 10;
            tiempoRestante = String.Empty;
            pausa = false;
            LbTiempo.Text = $" {minutos}:{segundos}";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            segundos = 10;
            LbTiempo.Text = $" {minutos}:{segundos}";
        }
    }
}
