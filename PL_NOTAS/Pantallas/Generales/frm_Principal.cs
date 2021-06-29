using System;
using System.Windows.Forms;

namespace PL_NOTAS.Pantallas.Generales
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
        }

        private void btn_Notas_Click(object sender, EventArgs e)
        {
            Calculos.frm_Notas objPantallaNotas = new Calculos.frm_Notas();
            this.Hide();
            objPantallaNotas.ShowDialog();
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ecuaciones_Click(object sender, EventArgs e)
        {
            Calculos.frm_Ecuaciones objPantallaEcuaciones = new Calculos.frm_Ecuaciones();
            this.Hide();            
            objPantallaEcuaciones.ShowDialog();
        }
    }
}
