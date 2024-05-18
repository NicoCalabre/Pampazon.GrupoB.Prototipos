namespace Pampazon.GrupoB.Prototipos
{
    partial class OrdenesDeRecepcionForm
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
            BotonConfirmarOrdenRecepcion = new Button();
            BotonCrearOrdenRecepcion = new Button();
            BotonListarOrdenesRecepcion = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // BotonConfirmarOrdenRecepcion
            // 
            BotonConfirmarOrdenRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonConfirmarOrdenRecepcion.Location = new Point(532, 146);
            BotonConfirmarOrdenRecepcion.Name = "BotonConfirmarOrdenRecepcion";
            BotonConfirmarOrdenRecepcion.Size = new Size(197, 158);
            BotonConfirmarOrdenRecepcion.TabIndex = 8;
            BotonConfirmarOrdenRecepcion.Text = "Confirmar Orden de Recepción";
            BotonConfirmarOrdenRecepcion.UseVisualStyleBackColor = true;
            // 
            // BotonCrearOrdenRecepcion
            // 
            BotonCrearOrdenRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonCrearOrdenRecepcion.Location = new Point(299, 146);
            BotonCrearOrdenRecepcion.Name = "BotonCrearOrdenRecepcion";
            BotonCrearOrdenRecepcion.Size = new Size(197, 158);
            BotonCrearOrdenRecepcion.TabIndex = 7;
            BotonCrearOrdenRecepcion.Text = "Crear orden de Recepción";
            BotonCrearOrdenRecepcion.UseVisualStyleBackColor = true;
            // 
            // BotonListarOrdenesRecepcion
            // 
            BotonListarOrdenesRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonListarOrdenesRecepcion.Location = new Point(72, 146);
            BotonListarOrdenesRecepcion.Name = "BotonListarOrdenesRecepcion";
            BotonListarOrdenesRecepcion.Size = new Size(197, 158);
            BotonListarOrdenesRecepcion.TabIndex = 6;
            BotonListarOrdenesRecepcion.Text = "Listar órdenes de recepción";
            BotonListarOrdenesRecepcion.UseVisualStyleBackColor = true;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(600, 415);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 9;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDeRecepcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonConfirmarOrdenRecepcion);
            Controls.Add(BotonCrearOrdenRecepcion);
            Controls.Add(BotonListarOrdenesRecepcion);
            Name = "OrdenesDeRecepcion";
            Text = "OrdenesDeRecepcion";
            ResumeLayout(false);
        }

        #endregion

        private Button BotonConfirmarOrdenRecepcion;
        private Button BotonCrearOrdenRecepcion;
        private Button BotonListarOrdenesRecepcion;
        private Button BotonVolver;
    }
}