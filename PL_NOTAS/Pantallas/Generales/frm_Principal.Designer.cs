
namespace PL_NOTAS.Pantallas.Generales
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.btn_Notas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Ecuaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Notas
            // 
            this.btn_Notas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Notas.Location = new System.Drawing.Point(153, 85);
            this.btn_Notas.Name = "btn_Notas";
            this.btn_Notas.Size = new System.Drawing.Size(98, 45);
            this.btn_Notas.TabIndex = 0;
            this.btn_Notas.Text = "Notas";
            this.btn_Notas.UseVisualStyleBackColor = true;
            this.btn_Notas.Click += new System.EventHandler(this.btn_Notas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 112);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Location = new System.Drawing.Point(153, 136);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(98, 45);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Ecuaciones
            // 
            this.btn_Ecuaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ecuaciones.Location = new System.Drawing.Point(153, 34);
            this.btn_Ecuaciones.Name = "btn_Ecuaciones";
            this.btn_Ecuaciones.Size = new System.Drawing.Size(98, 45);
            this.btn_Ecuaciones.TabIndex = 4;
            this.btn_Ecuaciones.Text = "Ecuaciones";
            this.btn_Ecuaciones.UseVisualStyleBackColor = true;
            this.btn_Ecuaciones.Click += new System.EventHandler(this.btn_Ecuaciones_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Controls.Add(this.btn_Ecuaciones);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Notas);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Notas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Ecuaciones;
    }
}