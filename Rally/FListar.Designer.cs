namespace Rally
{
    partial class FListar
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
            lbResultados = new ListBox();
            btnResultados = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbResultados
            // 
            lbResultados.FormattingEnabled = true;
            lbResultados.ItemHeight = 15;
            lbResultados.Location = new Point(12, 28);
            lbResultados.Name = "lbResultados";
            lbResultados.Size = new Size(325, 334);
            lbResultados.TabIndex = 0;
            // 
            // btnResultados
            // 
            btnResultados.DialogResult = DialogResult.OK;
            btnResultados.Location = new Point(135, 384);
            btnResultados.Name = "btnResultados";
            btnResultados.Size = new Size(75, 23);
            btnResultados.TabIndex = 1;
            btnResultados.Text = "Cerrar";
            btnResultados.UseVisualStyleBackColor = true;
            btnResultados.Click += btnResultados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "RESULTADOS";
            // 
            // FListar
            // 
            AcceptButton = btnResultados;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 419);
            Controls.Add(label1);
            Controls.Add(btnResultados);
            Controls.Add(lbResultados);
            Name = "FListar";
            Text = "Listar Resultados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnResultados;
        private Label label1;
        public ListBox lbResultados;
    }
}