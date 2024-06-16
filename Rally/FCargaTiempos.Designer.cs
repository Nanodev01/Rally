namespace Rally
{
    partial class FCargaTiempos
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
            lbNombreComp = new Label();
            label1 = new Label();
            label2 = new Label();
            tbHora = new TextBox();
            tbMinutos = new TextBox();
            btnAgregarT = new Button();
            lbNombreC = new Label();
            SuspendLayout();
            // 
            // lbNombreComp
            // 
            lbNombreComp.AutoSize = true;
            lbNombreComp.Location = new Point(264, 41);
            lbNombreComp.Name = "lbNombreComp";
            lbNombreComp.Size = new Size(0, 15);
            lbNombreComp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre del Competidor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 41);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Tiempo:";
            // 
            // tbHora
            // 
            tbHora.Location = new Point(80, 38);
            tbHora.Name = "tbHora";
            tbHora.Size = new Size(100, 23);
            tbHora.TabIndex = 3;
            // 
            // tbMinutos
            // 
            tbMinutos.Location = new Point(205, 38);
            tbMinutos.Name = "tbMinutos";
            tbMinutos.Size = new Size(100, 23);
            tbMinutos.TabIndex = 3;
            // 
            // btnAgregarT
            // 
            btnAgregarT.DialogResult = DialogResult.OK;
            btnAgregarT.Location = new Point(154, 79);
            btnAgregarT.Name = "btnAgregarT";
            btnAgregarT.Size = new Size(75, 23);
            btnAgregarT.TabIndex = 4;
            btnAgregarT.Text = "Agregar Tiempo";
            btnAgregarT.UseVisualStyleBackColor = true;
            // 
            // lbNombreC
            // 
            lbNombreC.AutoSize = true;
            lbNombreC.Location = new Point(170, 9);
            lbNombreC.Name = "lbNombreC";
            lbNombreC.Size = new Size(69, 15);
            lbNombreC.TabIndex = 5;
            lbNombreC.Text = "competidor";
            // 
            // FCargaTiempos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 124);
            Controls.Add(lbNombreC);
            Controls.Add(btnAgregarT);
            Controls.Add(tbMinutos);
            Controls.Add(tbHora);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbNombreComp);
            Name = "FCargaTiempos";
            Text = "FCargaTiempos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lbNombreComp;
        private Label label1;
        private Label label2;
        public TextBox tbHora;
        public TextBox tbMinutos;
        private Button btnAgregarT;
        public Label lbNombreC;
    }
}