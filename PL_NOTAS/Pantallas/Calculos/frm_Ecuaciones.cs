using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PL_NOTAS.Pantallas.Calculos
{
    public partial class frm_Ecuaciones : Form
    {
        public frm_Ecuaciones()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
        }

        private void btn_CerrarEcuaciones_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_MenuP_Click(object sender, EventArgs e)
        {
            Generales.frm_Principal objPantallaPrincipal = new Generales.frm_Principal();
            this.Hide();
            objPantallaPrincipal.ShowDialog();
        }

        private void btn_Calcular_Ecuaciones_Click(object sender, EventArgs e)
        {
            #region Instancia de clases

            DAL_NOTAS.Ecuaciones.Cls_Ecuaciones_DAL objValoresEcuaciones = new DAL_NOTAS.Ecuaciones.Cls_Ecuaciones_DAL();
            BLL_NOTAS.Ecuaciones.Cls_Ecuaciones_BLL objCalculoEcuaciones = new BLL_NOTAS.Ecuaciones.Cls_Ecuaciones_BLL();

            #endregion

            #region Asignacion de Valores

            objValoresEcuaciones.FPrimNum = float.Parse(txt_A.Text);
            objValoresEcuaciones.FSegNum = float.Parse(txt_B.Text);
            objValoresEcuaciones.FTercNum = float.Parse(txt_C.Text);

            #endregion

            #region Metodo

            objCalculoEcuaciones.Calculo_Ecuacion(ref objValoresEcuaciones);
            txt_Resultado.Text = objValoresEcuaciones.FResultado.ToString("F4");
            #endregion
        }

        private void ValidacionDatos(ref TextBox textbox, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == 48 && textbox.SelectionStart == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    if (Regex.IsMatch(textbox.Text, @"\.\d\d"))
                    {
                        if (e.KeyChar == '\b')
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }
                    }

                }
            }
            else
            {
                e.Handled = true;
            }


            if (e.KeyChar == '-')
            {
                if (textbox.Text.Length == 0 || textbox.SelectionStart == 0 && !textbox.Text.Contains("-"))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 46 || e.KeyChar == 44)
            {
                if (textbox.Text.Length == 0 || textbox.Text.LastIndexOf((char)46) >= 0 || textbox.Text.LastIndexOf((char)44) >= 0 || textbox.Text.EndsWith("-"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = Convert.ToChar(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
                    e.Handled = false;
                }
            }

            if (e.KeyChar == 48 && textbox.Text.EndsWith("-"))
            {
                e.Handled = true;
            }
        }

        private void ValidacionTxtVacio(ref TextBox textbox, EventArgs e)
        {

            if (textbox.Text.Length == 0)
            {
                errorProvider1.SetError(textbox, "caja de texto no puede ser quedar en blanco");
                textbox.Focus();
                btn_Calcular_Ecuaciones.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btn_Calcular_Ecuaciones.Enabled = true;
            }
        }

        private void DeteccionFlechas(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        private void ValidacionDatosConCero(ref TextBox textbox, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (Regex.IsMatch(textbox.Text, @"\.\d\d"))
                {
                    if (e.KeyChar == '\b')
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }


            if (e.KeyChar == '-')
            {
                if (textbox.Text.Length == 0 || textbox.SelectionStart == 0 && !textbox.Text.Contains("-"))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 46 || e.KeyChar == 44)
            {
                if (textbox.Text.Length == 0 || textbox.Text.LastIndexOf((char)46) >= 0 || textbox.Text.LastIndexOf((char)44) >= 0 || textbox.Text.EndsWith("-"))
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = Convert.ToChar(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
                    e.Handled = false;
                }
            }

            if (e.KeyChar == 48 && textbox.Text.EndsWith("-"))
            {
                e.Handled = true;
            }

        }

        private void txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDatos(ref textbox, e);
        }

        private void txt_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;

            ValidacionDatosConCero(ref textbox, e);

        }

        private void txt_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDatosConCero(ref textbox, e);
        }

        private void txt_A_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_B_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_C_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_A_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_B_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_C_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
    }


}
