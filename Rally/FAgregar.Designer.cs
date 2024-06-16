namespace Rally
{
    partial class FAgregar
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
            label1 = new Label();
            tbAgregarC = new TextBox();
            btnAgregarC = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Competidor:";
            // 
            // tbAgregarC
            // 
            tbAgregarC.Location = new Point(158, 19);
            tbAgregarC.Name = "tbAgregarC";
            tbAgregarC.Size = new Size(232, 23);
            tbAgregarC.TabIndex = 1;
            // 
            // btnAgregarC
            // 
            btnAgregarC.DialogResult = DialogResult.OK;
            btnAgregarC.Location = new Point(192, 48);
            btnAgregarC.Name = "btnAgregarC";
            btnAgregarC.Size = new Size(167, 36);
            btnAgregarC.TabIndex = 2;
            btnAgregarC.Text = "Agregar Competidor";
            btnAgregarC.UseVisualStyleBackColor = true;
            // 
            // FAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 104);
            Controls.Add(btnAgregarC);
            Controls.Add(tbAgregarC);
            Controls.Add(label1);
            Name = "FAgregar";
            Text = "Agregar Competidores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox tbAgregarC;
        private Button btnAgregarC;
    }
}