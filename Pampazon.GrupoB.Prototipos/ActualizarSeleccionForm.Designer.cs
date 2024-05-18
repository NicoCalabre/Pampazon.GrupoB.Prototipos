namespace Pampazon.GrupoB.Prototipos
{
    partial class ActualizarSeleccionForm
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
            LabelConfirmarSeleccion = new Label();
            BotonConfirmar = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // LabelConfirmarSeleccion
            // 
            LabelConfirmarSeleccion.AutoSize = true;
            LabelConfirmarSeleccion.Location = new Point(122, 125);
            LabelConfirmarSeleccion.Name = "LabelConfirmarSeleccion";
            LabelConfirmarSeleccion.Size = new Size(250, 15);
            LabelConfirmarSeleccion.TabIndex = 0;
            LabelConfirmarSeleccion.Text = "¿Está seguro que desea actualizar la selección?";
            // 
            // BotonConfirmar
            // 
            BotonConfirmar.Location = new Point(68, 237);
            BotonConfirmar.Name = "BotonConfirmar";
            BotonConfirmar.Size = new Size(188, 23);
            BotonConfirmar.TabIndex = 14;
            BotonConfirmar.Text = "Confirmar";
            BotonConfirmar.UseVisualStyleBackColor = true;
            BotonConfirmar.Click += BotonConfirmar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(262, 237);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 13;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ActualizarSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 272);
            Controls.Add(BotonConfirmar);
            Controls.Add(BotonVolver);
            Controls.Add(LabelConfirmarSeleccion);
            Name = "ActualizarSeleccionForm";
            Text = "ActualizarSeleccionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelConfirmarSeleccion;
        private Button BotonConfirmar;
        private Button BotonVolver;
    }
}