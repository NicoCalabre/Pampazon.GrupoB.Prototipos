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
            BotonConfirmarOrdenRecepcion.Location = new Point(608, 195);
            BotonConfirmarOrdenRecepcion.Margin = new Padding(3, 4, 3, 4);
            BotonConfirmarOrdenRecepcion.Name = "BotonConfirmarOrdenRecepcion";
            BotonConfirmarOrdenRecepcion.Size = new Size(225, 211);
            BotonConfirmarOrdenRecepcion.TabIndex = 8;
            BotonConfirmarOrdenRecepcion.Text = "Confirmar Orden de Recepción";
            BotonConfirmarOrdenRecepcion.UseVisualStyleBackColor = true;
            BotonConfirmarOrdenRecepcion.Click += BotonConfirmarOrdenRecepcion_Click;
            // 
            // BotonCrearOrdenRecepcion
            // 
            BotonCrearOrdenRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonCrearOrdenRecepcion.Location = new Point(342, 195);
            BotonCrearOrdenRecepcion.Margin = new Padding(3, 4, 3, 4);
            BotonCrearOrdenRecepcion.Name = "BotonCrearOrdenRecepcion";
            BotonCrearOrdenRecepcion.Size = new Size(225, 211);
            BotonCrearOrdenRecepcion.TabIndex = 7;
            BotonCrearOrdenRecepcion.Text = "Crear orden de Recepción";
            BotonCrearOrdenRecepcion.UseVisualStyleBackColor = true;
            BotonCrearOrdenRecepcion.Click += BotonCrearOrdenRecepcion_Click;
            // 
            // BotonListarOrdenesRecepcion
            // 
            BotonListarOrdenesRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonListarOrdenesRecepcion.Location = new Point(82, 195);
            BotonListarOrdenesRecepcion.Margin = new Padding(3, 4, 3, 4);
            BotonListarOrdenesRecepcion.Name = "BotonListarOrdenesRecepcion";
            BotonListarOrdenesRecepcion.Size = new Size(225, 211);
            BotonListarOrdenesRecepcion.TabIndex = 6;
            BotonListarOrdenesRecepcion.Text = "Listar órdenes de recepción";
            BotonListarOrdenesRecepcion.UseVisualStyleBackColor = true;
            BotonListarOrdenesRecepcion.Click += BotonListarOrdenesRecepcion_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(686, 553);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 9;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDeRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonVolver);
            Controls.Add(BotonConfirmarOrdenRecepcion);
            Controls.Add(BotonCrearOrdenRecepcion);
            Controls.Add(BotonListarOrdenesRecepcion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenesDeRecepcionForm";
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