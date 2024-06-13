namespace Rally
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregarComp = new Button();
            btnCargarTiempos = new Button();
            btnResultados = new Button();
            SuspendLayout();
            // 
            // btnAgregarComp
            // 
            btnAgregarComp.Location = new Point(51, 31);
            btnAgregarComp.Name = "btnAgregarComp";
            btnAgregarComp.Size = new Size(196, 23);
            btnAgregarComp.TabIndex = 0;
            btnAgregarComp.Text = "Agregar Competidor";
            btnAgregarComp.UseVisualStyleBackColor = true;
            btnAgregarComp.Click += btnAgregarComp_Click;
            // 
            // btnCargarTiempos
            // 
            btnCargarTiempos.Location = new Point(51, 78);
            btnCargarTiempos.Name = "btnCargarTiempos";
            btnCargarTiempos.Size = new Size(196, 23);
            btnCargarTiempos.TabIndex = 0;
            btnCargarTiempos.Text = "Cargar Tiempos";
            btnCargarTiempos.UseVisualStyleBackColor = true;
            btnCargarTiempos.Click += btnCargarTiempos_Click;
            // 
            // btnResultados
            // 
            btnResultados.Location = new Point(51, 128);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(196, 23);
            btnResultados.TabIndex = 0;
            btnResultados.Text = "Ver Resultados";
            btnResultados.UseVisualStyleBackColor = true;
            btnResultados.Click += btnResultados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 208);
            Controls.Add(btnResultados);
            Controls.Add(btnCargarTiempos);
            Controls.Add(btnAgregarComp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarComp;
        private Button btnCargarTiempos;
        private Button btnResultados;
    }
}
