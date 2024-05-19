namespace Pampazon.GrupoB.Prototipos
{
    partial class ActualizarSeleccionEntregaForm
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
            BotonConfirmar = new Button();
            BotonVolver = new Button();
            LabelConfirmarSeleccion = new Label();
            SuspendLayout();
            // 
            // BotonConfirmar
            // 
            BotonConfirmar.Location = new Point(106, 306);
            BotonConfirmar.Margin = new Padding(3, 4, 3, 4);
            BotonConfirmar.Name = "BotonConfirmar";
            BotonConfirmar.Size = new Size(215, 31);
            BotonConfirmar.TabIndex = 17;
            BotonConfirmar.Text = "Confirmar";
            BotonConfirmar.UseVisualStyleBackColor = true;
            BotonConfirmar.Click += BotonConfirmar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(327, 306);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 16;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // LabelConfirmarSeleccion
            // 
            LabelConfirmarSeleccion.AutoSize = true;
            LabelConfirmarSeleccion.Location = new Point(167, 157);
            LabelConfirmarSeleccion.Name = "LabelConfirmarSeleccion";
            LabelConfirmarSeleccion.Size = new Size(320, 20);
            LabelConfirmarSeleccion.TabIndex = 15;
            LabelConfirmarSeleccion.Text = "¿Está seguro que desea actualizar la selección?";
            // 
            // ActualizarSeleccionEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 405);
            Controls.Add(BotonConfirmar);
            Controls.Add(BotonVolver);
            Controls.Add(LabelConfirmarSeleccion);
            Name = "ActualizarSeleccionEntregaForm";
            Text = "ActualizarSeleccionEntregaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonConfirmar;
        private Button BotonVolver;
        private Label LabelConfirmarSeleccion;
    }
}