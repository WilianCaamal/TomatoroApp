using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TomatoroApp
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();
        }

        public void CargarConfiguracion()
        {
            TxtTiempoSesion.Text = Properties.Settings.Default.TiempoSesion.ToString();
            TxtDescanso.Text = Properties.Settings.Default.Descanso.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtTiempoSesion.Text != String.Empty && TxtDescanso.Text != String.Empty)
                {
                    Properties.Settings.Default.TiempoSesion = Convert.ToInt32(TxtTiempoSesion.Text);
                    Properties.Settings.Default.Descanso = Convert.ToInt32(TxtDescanso.Text);
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hay campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El sistema solo acepta numeros enteros","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
         
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
