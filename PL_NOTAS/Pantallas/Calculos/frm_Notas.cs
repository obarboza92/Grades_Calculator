using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PL_NOTAS.Pantallas.Calculos
{
    public partial class frm_Notas : Form
    {
        public frm_Notas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
        }

        private void bt_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Ver_Nota_Click(object sender, EventArgs e)
        {
            #region Instancia de Clases

            DAL_NOTAS.Notas.Cls_Notas_DAL objvaloresNotas = new DAL_NOTAS.Notas.Cls_Notas_DAL();
            BLL_NOTAS.Notas.Cls_Notas_BLL objCalculoNotas = new BLL_NOTAS.Notas.Cls_Notas_BLL();

            #endregion

            #region Llenado de objeto de Valores


            if (ValidacionBotonCalculo())
            {

                MessageBox.Show("Todos los campos deben ser ingresados");
            }
            else
            {
                //Porcentaje de Evaluacion
                objvaloresNotas.BPorcTareas = Convert.ToByte(txt_Porc_Tareas.Text);
                objvaloresNotas.BPorcQuices = Convert.ToByte(txt_Porc_Quices.Text);
                objvaloresNotas.BPorcParI = Convert.ToByte(txt_Porc_Par_I.Text);
                objvaloresNotas.BPorcParII = Convert.ToByte(txt_Porc_Par_II.Text);
                objvaloresNotas.BPorcParIII = Convert.ToByte(txt_Porc_Par_III.Text);

                //Notas de Quices
                objvaloresNotas.FQuizI = float.Parse(txt_Quiz_I.Text);
                objvaloresNotas.FQuizII = float.Parse(txt_Quiz_II.Text);
                objvaloresNotas.FQuizIII = float.Parse(txt_Quiz_III.Text);

                //Notas de Tareas
                objvaloresNotas.FTareaI = float.Parse(txt_Tar_I.Text);
                objvaloresNotas.FTareaII = float.Parse(txt_Tar_II.Text);
                objvaloresNotas.FTareaIII = float.Parse(txt_Tar_III.Text);
                objvaloresNotas.FTareaIV = float.Parse(txt_Tar_IV.Text);

                //Notas Examenes Parciales
                objvaloresNotas.FParcialI = float.Parse(txt_Par_I.Text);
                objvaloresNotas.FParcialII = float.Parse(txt_Par_II.Text);
                objvaloresNotas.FParcialIII = float.Parse(txt_Par_III.Text);


                #region Llenado de resultados y desabilitacion de text box

                //Asignacion Nota Quices
                objCalculoNotas.Calculo_Nota_Quices(ref objvaloresNotas);
                txt_Nota_Quices.Text = objvaloresNotas.FNotaQuices.ToString("F2");

                //Asignacion Nota Tareas
                objCalculoNotas.Calculo_Nota_Tareas(ref objvaloresNotas);
                txt_Nota_Tareas.Text = objvaloresNotas.FNotaTareas.ToString("F2");

                //Asignacion Nota Final
                objCalculoNotas.Calculo_Nota_Final(ref objvaloresNotas);
                txt_Nota_Final.Text = objvaloresNotas.FNotaFinal.ToString("F2");

                txt_Porc_Tareas.ReadOnly = true;
                txt_Porc_Quices.ReadOnly = true;
                txt_Porc_Par_I.ReadOnly = true;
                txt_Porc_Par_II.ReadOnly = true;
                txt_Porc_Par_III.ReadOnly = true;
                txt_Quiz_I.ReadOnly = true;
                txt_Quiz_II.ReadOnly = true;
                txt_Quiz_III.ReadOnly = true;
                txt_Tar_I.ReadOnly = true;
                txt_Tar_II.ReadOnly = true;
                txt_Tar_III.ReadOnly = true;
                txt_Tar_IV.ReadOnly = true;
                txt_Par_I.ReadOnly = true;
                txt_Par_II.ReadOnly = true;
                txt_Par_III.ReadOnly = true;
            }

            #endregion

            #endregion

        }

        private void btn_Nuevo_Calculo_Click(object sender, EventArgs e)
        {
            txt_Porc_Tareas.ReadOnly = false;
            txt_Porc_Tareas.Clear();
            txt_Porc_Quices.ReadOnly = false;
            txt_Porc_Quices.Clear();
            txt_Porc_Par_I.ReadOnly = false;
            txt_Porc_Par_I.Clear();
            txt_Porc_Par_II.ReadOnly = false;
            txt_Porc_Par_II.Clear();
            txt_Porc_Par_III.ReadOnly = false;
            txt_Porc_Par_III.Clear();
            txt_Quiz_I.ReadOnly = false;
            txt_Quiz_I.Clear();
            txt_Quiz_II.ReadOnly = false;
            txt_Quiz_II.Clear();
            txt_Quiz_III.ReadOnly = false;
            txt_Quiz_III.Clear();
            txt_Tar_I.ReadOnly = false;
            txt_Tar_I.Clear();
            txt_Tar_II.ReadOnly = false;
            txt_Tar_II.Clear();
            txt_Tar_III.ReadOnly = false;
            txt_Tar_III.Clear();
            txt_Tar_IV.ReadOnly = false;
            txt_Tar_IV.Clear();
            txt_Par_I.ReadOnly = false;
            txt_Par_I.Clear();
            txt_Par_II.ReadOnly = false;
            txt_Par_II.Clear();
            txt_Par_III.ReadOnly = false;
            txt_Par_III.Clear();
            txt_Nota_Quices.Clear();
            txt_Nota_Tareas.Clear();
            txt_Nota_Final.Clear();
            //bt_Ver_Nota.Enabled = false;
        }

        private void btn_Menu_Principal_Click(object sender, EventArgs e)
        {
            Generales.frm_Principal objPantallaPrincipal = new Generales.frm_Principal();
            this.Hide();
            objPantallaPrincipal.ShowDialog();
        }

        private void txt_Porc_Tareas_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionPorcentajes(ref textbox, e);
        }

        private void txt_Porc_Par_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionPorcentajes(ref textbox, e);
        }

        private void txt_Porc_Par_III_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionPorcentajes(ref textbox, e);
        }

        private void txt_Porc_Quices_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionPorcentajes(ref textbox, e);
        }

        private void txt_Porc_Par_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionPorcentajes(ref textbox, e);
        }

        private void txt_Quiz_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);

        }

        private void txt_Quiz_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);
        }

        private void txt_Quiz_III_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);

        }

        private void txt_Tar_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);
        }

        private void txt_Tar_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);

        }

        private void txt_Tar_III_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);

        }

        private void txt_Tar_IV_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);

        }

        private void txt_Par_I_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);
        }

        private void txt_Par_II_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);
        }

        private void txt_Par_III_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionDecimales(ref textbox, e);
        }

        private void txt_Porc_Tareas_Leave(object sender, EventArgs e)
        {
            ValidacionBotonCalculo();
            if (txt_Porc_Tareas.Text.Length == 0)
            {
                errorProvider1.SetError(txt_Porc_Tareas, "caja de texto no puede ser quedar en blanco");
                txt_Porc_Tareas.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void ValidacionPorcentajes(ref TextBox textbox, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(textbox, "caja de texto no puede ser quedar en blanco.");
            }

            char c = e.KeyChar;
            if ((!char.IsDigit(c) || float.Parse(textbox.Text + e.KeyChar) > 100) && c != '\b')
                e.Handled = true;
        }

        private void ValidacionTxtVacio(ref TextBox textbox, EventArgs e)
        {

            if (textbox.Text.Length == 0)
            {
                errorProvider1.SetError(textbox, "caja de texto no puede ser quedar en blanco");
                textbox.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void ValidacionDecimales(ref TextBox textbox, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 46 || e.KeyChar == 44)
            {
                if (textbox.Text.Length == 0 || textbox.Text.LastIndexOf((char)46) >= 0 || textbox.Text.LastIndexOf((char)44) >= 0)
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = Convert.ToChar(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);
                    e.Handled = false;
                }
            }

            try
            {
                char c = e.KeyChar;
                if ((char.IsControl(c) || float.Parse(textbox.Text + e.KeyChar) > 100) && c != '\b')
                {
                    e.Handled = true;
                }
                   
            }
            catch (Exception)
            {
                e.Handled = true;
            }



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

        private bool ValidacionBotonCalculo()
        {
            if (txt_Porc_Tareas.Text.Length != 0 && txt_Porc_Quices.Text.Length != 0 && txt_Porc_Par_I.Text.Length != 0 && txt_Porc_Par_II.Text.Length != 0 && txt_Porc_Par_III.Text.Length != 0)
            {
                if (Convert.ToByte(txt_Porc_Tareas.Text) + Convert.ToByte(txt_Porc_Quices.Text) + Convert.ToByte(txt_Porc_Par_I.Text) + Convert.ToByte(txt_Porc_Par_II.Text) + Convert.ToByte(txt_Porc_Par_III.Text) == 100)
                {
                    gr_Tareas.Enabled = true;
                    gr_Quices.Enabled = true;
                    gr_Parciales.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Porcentajes deben sumar 100");
                }

            }
            if (txt_Quiz_I.Text.Length == 0 || txt_Quiz_II.Text.Length == 0 || txt_Quiz_III.Text.Length == 0 || txt_Tar_I.Text.Length == 0 || txt_Tar_II.Text.Length == 0 || txt_Tar_III.Text.Length == 0 || txt_Tar_IV.Text.Length == 0
                || txt_Porc_Par_I.Text.Length == 0 || txt_Porc_Par_II.Text.Length == 0 || txt_Porc_Par_III.Text.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
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

        private void txt_Porc_Quices_Leave(object sender, EventArgs e)
        {
            ValidacionBotonCalculo();
            if (txt_Porc_Quices.Text.Length == 0)
            {
                errorProvider1.SetError(txt_Porc_Quices, "caja de texto no puede ser quedar en blanco");
                txt_Porc_Quices.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void txt_Porc_Par_I_Leave(object sender, EventArgs e)
        {
            ValidacionBotonCalculo();
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Porc_Par_II_Leave(object sender, EventArgs e)
        {
            ValidacionBotonCalculo();
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Porc_Par_III_Leave(object sender, EventArgs e)
        {
            ValidacionBotonCalculo();
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);

        }

        private void txt_Quiz_I_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Quiz_II_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Quiz_III_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Tar_I_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Tar_II_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Tar_III_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Tar_IV_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Par_I_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Par_II_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
        }

        private void txt_Par_III_Leave(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            ValidacionTxtVacio(ref textbox, e);
            bt_Ver_Nota.Enabled = true;
        }

        private void txt_Porc_Tareas_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Porc_Par_I_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Porc_Quices_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Porc_Par_II_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Porc_Par_III_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Quiz_I_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Quiz_II_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Quiz_III_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Tar_I_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Tar_II_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Tar_III_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Tar_IV_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Par_I_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Par_II_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }

        private void txt_Par_III_KeyDown(object sender, KeyEventArgs e)
        {
            DeteccionFlechas(e);
        }
    }
}

