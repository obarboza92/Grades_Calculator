
namespace PL_NOTAS.Pantallas.Calculos
{
    partial class frm_Ecuaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gb_Ecuaciones = new System.Windows.Forms.GroupBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lab_Resultado = new System.Windows.Forms.Label();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.lab_C = new System.Windows.Forms.Label();
            this.lab_B = new System.Windows.Forms.Label();
            this.lab_A = new System.Windows.Forms.Label();
            this.btn_Calcular_Ecuaciones = new System.Windows.Forms.Button();
            this.btn_CerrarEcuaciones = new System.Windows.Forms.Button();
            this.btn_MenuP = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_Ecuaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Ecuaciones
            // 
            this.gb_Ecuaciones.Controls.Add(this.txt_Resultado);
            this.gb_Ecuaciones.Controls.Add(this.lab_Resultado);
            this.gb_Ecuaciones.Controls.Add(this.txt_C);
            this.gb_Ecuaciones.Controls.Add(this.txt_B);
            this.gb_Ecuaciones.Controls.Add(this.txt_A);
            this.gb_Ecuaciones.Controls.Add(this.lab_C);
            this.gb_Ecuaciones.Controls.Add(this.lab_B);
            this.gb_Ecuaciones.Controls.Add(this.lab_A);
            this.gb_Ecuaciones.Controls.Add(this.btn_Calcular_Ecuaciones);
            this.gb_Ecuaciones.Location = new System.Drawing.Point(14, 19);
            this.gb_Ecuaciones.Name = "gb_Ecuaciones";
            this.gb_Ecuaciones.Size = new System.Drawing.Size(327, 166);
            this.gb_Ecuaciones.TabIndex = 0;
            this.gb_Ecuaciones.TabStop = false;
            this.gb_Ecuaciones.Text = "Informacion de la Ecuacion";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(94, 123);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(68, 20);
            this.txt_Resultado.TabIndex = 8;
            // 
            // lab_Resultado
            // 
            this.lab_Resultado.AutoSize = true;
            this.lab_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Resultado.Location = new System.Drawing.Point(24, 123);
            this.lab_Resultado.Name = "lab_Resultado";
            this.lab_Resultado.Size = new System.Drawing.Size(63, 15);
            this.lab_Resultado.TabIndex = 7;
            this.lab_Resultado.Text = "Resultado";
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(163, 76);
            this.txt_C.MaxLength = 10;
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(36, 20);
            this.txt_C.TabIndex = 6;
            this.txt_C.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_C_KeyDown);
            this.txt_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_C_KeyPress);
            this.txt_C.Leave += new System.EventHandler(this.txt_C_Leave);
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(94, 76);
            this.txt_B.MaxLength = 10;
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(36, 20);
            this.txt_B.TabIndex = 5;
            this.txt_B.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_B_KeyDown);
            this.txt_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_B_KeyPress);
            this.txt_B.Leave += new System.EventHandler(this.txt_B_Leave);
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(24, 76);
            this.txt_A.MaxLength = 10;
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(36, 20);
            this.txt_A.TabIndex = 4;
            this.txt_A.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_A_KeyDown);
            this.txt_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_A_KeyPress);
            this.txt_A.Leave += new System.EventHandler(this.txt_A_Leave);
            // 
            // lab_C
            // 
            this.lab_C.AutoSize = true;
            this.lab_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_C.Location = new System.Drawing.Point(165, 33);
            this.lab_C.Name = "lab_C";
            this.lab_C.Size = new System.Drawing.Size(28, 25);
            this.lab_C.TabIndex = 3;
            this.lab_C.Text = "C";
            // 
            // lab_B
            // 
            this.lab_B.AutoSize = true;
            this.lab_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_B.Location = new System.Drawing.Point(97, 33);
            this.lab_B.Name = "lab_B";
            this.lab_B.Size = new System.Drawing.Size(26, 25);
            this.lab_B.TabIndex = 2;
            this.lab_B.Text = "B";
            // 
            // lab_A
            // 
            this.lab_A.AutoSize = true;
            this.lab_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_A.Location = new System.Drawing.Point(27, 33);
            this.lab_A.Name = "lab_A";
            this.lab_A.Size = new System.Drawing.Size(27, 25);
            this.lab_A.TabIndex = 1;
            this.lab_A.Text = "A";
            // 
            // btn_Calcular_Ecuaciones
            // 
            this.btn_Calcular_Ecuaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calcular_Ecuaciones.Enabled = false;
            this.btn_Calcular_Ecuaciones.Location = new System.Drawing.Point(228, 73);
            this.btn_Calcular_Ecuaciones.Name = "btn_Calcular_Ecuaciones";
            this.btn_Calcular_Ecuaciones.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular_Ecuaciones.TabIndex = 0;
            this.btn_Calcular_Ecuaciones.Text = "Calcular";
            this.btn_Calcular_Ecuaciones.UseVisualStyleBackColor = true;
            this.btn_Calcular_Ecuaciones.Click += new System.EventHandler(this.btn_Calcular_Ecuaciones_Click);
            // 
            // btn_CerrarEcuaciones
            // 
            this.btn_CerrarEcuaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CerrarEcuaciones.Location = new System.Drawing.Point(266, 191);
            this.btn_CerrarEcuaciones.Name = "btn_CerrarEcuaciones";
            this.btn_CerrarEcuaciones.Size = new System.Drawing.Size(75, 23);
            this.btn_CerrarEcuaciones.TabIndex = 1;
            this.btn_CerrarEcuaciones.Text = "Cerrar";
            this.btn_CerrarEcuaciones.UseVisualStyleBackColor = true;
            this.btn_CerrarEcuaciones.Click += new System.EventHandler(this.btn_CerrarEcuaciones_Click);
            // 
            // btn_MenuP
            // 
            this.btn_MenuP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MenuP.Location = new System.Drawing.Point(182, 191);
            this.btn_MenuP.Name = "btn_MenuP";
            this.btn_MenuP.Size = new System.Drawing.Size(75, 23);
            this.btn_MenuP.TabIndex = 2;
            this.btn_MenuP.Text = "Menu";
            this.btn_MenuP.UseVisualStyleBackColor = true;
            this.btn_MenuP.Click += new System.EventHandler(this.btn_MenuP_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Ecuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 225);
            this.Controls.Add(this.btn_MenuP);
            this.Controls.Add(this.btn_CerrarEcuaciones);
            this.Controls.Add(this.gb_Ecuaciones);
            this.Name = "frm_Ecuaciones";
            this.Text = "Ecuaciones Primer Grado";
            this.gb_Ecuaciones.ResumeLayout(false);
            this.gb_Ecuaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Ecuaciones;
        private System.Windows.Forms.Label lab_A;
        private System.Windows.Forms.Button btn_CerrarEcuaciones;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lab_Resultado;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label lab_C;
        private System.Windows.Forms.Label lab_B;
        private System.Windows.Forms.Button btn_MenuP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_Calcular_Ecuaciones;
    }
}