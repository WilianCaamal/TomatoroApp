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
        private int minutos = 20;
        private int segundos = 0;
        private int descanso = 0;
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
                BtnIniciar.Image = Properties.Resources.play_24px;
                BtnDescanso.Enabled = true;
                BtnPonodoro.Enabled = true;
                pausa = false;
            }
            else
            {
                Timer.Start();
                BtnIniciar.Text = "Pausar";
                BtnIniciar.Image = Properties.Resources.pause_24px;
                BtnDescanso.Enabled = false;
                BtnPonodoro.Enabled = false;
                pausa = true;
            }
        }

        private void MostrarTiempo()
        {
            if (minutos.ToString().Length == 1)
            {
                if (segundos.ToString().Length == 1)
                {
                    LbTiempo.Text = $"0{minutos}:0{segundos}";
                }
                else
                {
                    LbTiempo.Text = $"0{minutos}:{segundos}";
                }
            }
            else
            {
                if (segundos.ToString().Length == 1)
                {
                    LbTiempo.Text = $"{minutos}:0{segundos}";
                }
                else
                {
                    LbTiempo.Text = $"{minutos}:{segundos}";
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
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
                    BtnIniciar.Image = Properties.Resources.play_24px;
                    MostrarNotificacion();
                }
            }

            MostrarTiempo();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tiempoRestante = String.Empty;
            pausa = false;
            CargarConfiguracion();
            MostrarTiempo();
        }

        public void CargarConfiguracion()
        {
            minutos = Properties.Settings.Default.TiempoSesion;
            descanso = Properties.Settings.Default.Descanso;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            CargarConfiguracion();
            segundos = 0;
            MostrarTiempo();
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.Image = Properties.Resources.play_24px;
            pausa = false;

        }

        private void MostrarNotificacion()
        {
            Icon icon = Properties.Resources.icono;
            Notificacion.Icon = icon;
            Notificacion.Text = "El tiempo a concluido";
            Notificacion.Visible = true;
            Notificacion.BalloonTipTitle = "Tomatoro App";
            Notificacion.BalloonTipText = "El tiempo a concluido"; 
            Notificacion.ShowBalloonTip(1000);
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion();
            if (configuracion.ShowDialog() == DialogResult.Yes)
            {
                CargarConfiguracion();
            }
        }

        private void BtnDescanso_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            minutos = Properties.Settings.Default.Descanso;
            MostrarTiempo();
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.Image = Properties.Resources.play_24px;
        }

        private void BtnPonodoro_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            minutos = Properties.Settings.Default.TiempoSesion;
            segundos = 0;
            MostrarTiempo();
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.Image = Properties.Resources.play_24px;
        }
    }
}
