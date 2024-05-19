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
            LabelConfirmarSeleccion.ForeColor = SystemColors.ButtonHighlight;
            LabelConfirmarSeleccion.Location = new Point(139, 167);
            LabelConfirmarSeleccion.Name = "LabelConfirmarSeleccion";
            LabelConfirmarSeleccion.Size = new Size(320, 20);
            LabelConfirmarSeleccion.TabIndex = 0;
            LabelConfirmarSeleccion.Text = "¿Está seguro que desea actualizar la selección?";
            // 
            // BotonConfirmar
            // 
            BotonConfirmar.Location = new Point(78, 316);
            BotonConfirmar.Margin = new Padding(3, 4, 3, 4);
            BotonConfirmar.Name = "BotonConfirmar";
            BotonConfirmar.Size = new Size(215, 31);
            BotonConfirmar.TabIndex = 14;
            BotonConfirmar.Text = "Confirmar";
            BotonConfirmar.UseVisualStyleBackColor = true;
            BotonConfirmar.Click += BotonConfirmar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(299, 316);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 13;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ActualizarSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(597, 363);
            Controls.Add(BotonConfirmar);
            Controls.Add(BotonVolver);
            Controls.Add(LabelConfirmarSeleccion);
            Margin = new Padding(3, 4, 3, 4);
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