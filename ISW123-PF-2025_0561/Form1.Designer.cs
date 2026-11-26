namespace ISW123_PF_2025_0561
{
    partial class frmPrincipal
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
            label1 = new Label();
            label2 = new Label();
            btnCliente = new Button();
            btnEstilistas = new Button();
            btnServicios = new Button();
            btnCitas = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            lstAvisos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 82);
            label1.Name = "label1";
            label1.Size = new Size(456, 46);
            label1.TabIndex = 0;
            label1.Text = "¿Qué Necesitas hoy?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Snap ITC", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(492, 63);
            label2.TabIndex = 1;
            label2.Text = "El Salon de Rosa";
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(12, 172);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(222, 41);
            btnCliente.TabIndex = 2;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnEstilistas
            // 
            btnEstilistas.Location = new Point(12, 234);
            btnEstilistas.Name = "btnEstilistas";
            btnEstilistas.Size = new Size(222, 45);
            btnEstilistas.TabIndex = 3;
            btnEstilistas.Text = "Estilistas";
            btnEstilistas.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            btnServicios.Location = new Point(12, 298);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(222, 39);
            btnServicios.TabIndex = 4;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnCitas
            // 
            btnCitas.Location = new Point(268, 172);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(219, 41);
            btnCitas.TabIndex = 5;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(268, 234);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(219, 45);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(268, 298);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(219, 39);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lstAvisos
            // 
            lstAvisos.FormattingEnabled = true;
            lstAvisos.Location = new Point(12, 349);
            lstAvisos.Name = "lstAvisos";
            lstAvisos.Size = new Size(475, 84);
            lstAvisos.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(527, 445);
            Controls.Add(lstAvisos);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnCitas);
            Controls.Add(btnServicios);
            Controls.Add(btnEstilistas);
            Controls.Add(btnCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "El Salon De Rosa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCliente;
        private Button btnEstilistas;
        private Button btnServicios;
        private Button btnCitas;
        private Button btnReportes;
        private Button btnSalir;
        private ListBox lstAvisos;
    }
}
