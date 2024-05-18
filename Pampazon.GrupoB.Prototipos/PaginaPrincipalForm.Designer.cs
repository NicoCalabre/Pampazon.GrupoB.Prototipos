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
            BotonGestionarStock = new Button();
            BotonOrdenesRecepcion = new Button();
            BotonOrdenesPreparacion = new Button();
            BotonOrdenesSeleccion = new Button();
            BotonOrdenesEntrega = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // BotonGestionarStock
            // 
            BotonGestionarStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonGestionarStock.Location = new Point(82, 97);
            BotonGestionarStock.Name = "BotonGestionarStock";
            BotonGestionarStock.Size = new Size(197, 103);
            BotonGestionarStock.TabIndex = 0;
            BotonGestionarStock.Text = "Gestionar Stock";
            BotonGestionarStock.UseVisualStyleBackColor = true;
            BotonGestionarStock.Click += BotonGestionarStock_Click;
            // 
            // BotonOrdenesRecepcion
            // 
            BotonOrdenesRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesRecepcion.Location = new Point(309, 97);
            BotonOrdenesRecepcion.Name = "BotonOrdenesRecepcion";
            BotonOrdenesRecepcion.Size = new Size(197, 103);
            BotonOrdenesRecepcion.TabIndex = 1;
            BotonOrdenesRecepcion.Text = "Órdenes de Recepción";
            BotonOrdenesRecepcion.UseVisualStyleBackColor = true;
            BotonOrdenesRecepcion.Click += BotonOrdenesRecepcion_Click;
            // 
            // BotonOrdenesPreparacion
            // 
            BotonOrdenesPreparacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesPreparacion.Location = new Point(542, 97);
            BotonOrdenesPreparacion.Name = "BotonOrdenesPreparacion";
            BotonOrdenesPreparacion.Size = new Size(197, 103);
            BotonOrdenesPreparacion.TabIndex = 2;
            BotonOrdenesPreparacion.Text = "Órdenes de Preparación";
            BotonOrdenesPreparacion.UseVisualStyleBackColor = true;
            BotonOrdenesPreparacion.Click += BotonOrdenesPreparacion_Click;
            // 
            // BotonOrdenesSeleccion
            // 
            BotonOrdenesSeleccion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesSeleccion.Location = new Point(204, 206);
            BotonOrdenesSeleccion.Name = "BotonOrdenesSeleccion";
            BotonOrdenesSeleccion.Size = new Size(197, 103);
            BotonOrdenesSeleccion.TabIndex = 3;
            BotonOrdenesSeleccion.Text = "Órdenes de Selección";
            BotonOrdenesSeleccion.UseVisualStyleBackColor = true;
            BotonOrdenesSeleccion.Click += BotonOrdenesSeleccion_Click;
            // 
            // BotonOrdenesEntrega
            // 
            BotonOrdenesEntrega.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesEntrega.Location = new Point(424, 206);
            BotonOrdenesEntrega.Name = "BotonOrdenesEntrega";
            BotonOrdenesEntrega.Size = new Size(197, 103);
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
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonOrdenesEntrega);
            Controls.Add(BotonOrdenesSeleccion);
            Controls.Add(BotonOrdenesPreparacion);
            Controls.Add(BotonOrdenesRecepcion);
            Controls.Add(BotonGestionarStock);
            Name = "PaginaPrincipalForm";
            Text = "Página Principal";
            Load += PaginaPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonGestionarStock;
        private Button BotonOrdenesRecepcion;
        private Button BotonOrdenesPreparacion;
        private Button BotonOrdenesSeleccion;
        private Button BotonOrdenesEntrega;
        private Button BotonVolver;
    }
}
