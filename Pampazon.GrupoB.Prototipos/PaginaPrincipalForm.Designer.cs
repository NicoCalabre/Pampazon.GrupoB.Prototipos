namespace Pampazon.GrupoB.Prototipos
{
    partial class PaginaPrincipalForm
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
            BotonOrdenesPreparacion = new Button();
            BotonOrdenesSeleccion = new Button();
            BotonOrdenesEntrega = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // BotonOrdenesPreparacion
            // 
            BotonOrdenesPreparacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesPreparacion.Location = new Point(83, 155);
            BotonOrdenesPreparacion.Name = "BotonOrdenesPreparacion";
            BotonOrdenesPreparacion.Size = new Size(197, 151);
            BotonOrdenesPreparacion.TabIndex = 2;
            BotonOrdenesPreparacion.Text = "Órdenes de Preparación";
            BotonOrdenesPreparacion.UseVisualStyleBackColor = true;
            BotonOrdenesPreparacion.Click += BotonOrdenesPreparacion_Click;
            // 
            // BotonOrdenesSeleccion
            // 
            BotonOrdenesSeleccion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesSeleccion.Location = new Point(301, 155);
            BotonOrdenesSeleccion.Name = "BotonOrdenesSeleccion";
            BotonOrdenesSeleccion.Size = new Size(197, 151);
            BotonOrdenesSeleccion.TabIndex = 3;
            BotonOrdenesSeleccion.Text = "Órdenes de Selección";
            BotonOrdenesSeleccion.UseVisualStyleBackColor = true;
            BotonOrdenesSeleccion.Click += BotonOrdenesSeleccion_Click;
            // 
            // BotonOrdenesEntrega
            // 
            BotonOrdenesEntrega.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesEntrega.Location = new Point(521, 155);
            BotonOrdenesEntrega.Name = "BotonOrdenesEntrega";
            BotonOrdenesEntrega.Size = new Size(197, 151);
            BotonOrdenesEntrega.TabIndex = 4;
            BotonOrdenesEntrega.Text = "Órdenes de Entrega";
            BotonOrdenesEntrega.UseVisualStyleBackColor = true;
            BotonOrdenesEntrega.Click += BotonOrdenesEntrega_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(600, 415);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 5;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // PaginaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonOrdenesEntrega);
            Controls.Add(BotonOrdenesSeleccion);
            Controls.Add(BotonOrdenesPreparacion);
            Name = "PaginaPrincipalForm";
            Text = "Página Principal";
            Load += PaginaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button BotonOrdenesPreparacion;
        private Button BotonOrdenesSeleccion;
        private Button BotonOrdenesEntrega;
        private Button BotonVolver;
    }
}
