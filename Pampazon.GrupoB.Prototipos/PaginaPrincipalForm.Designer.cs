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
            BotonGestionarStock.Location = new Point(94, 129);
            BotonGestionarStock.Margin = new Padding(3, 4, 3, 4);
            BotonGestionarStock.Name = "BotonGestionarStock";
            BotonGestionarStock.Size = new Size(225, 137);
            BotonGestionarStock.TabIndex = 0;
            BotonGestionarStock.Text = "Gestionar Stock";
            BotonGestionarStock.UseVisualStyleBackColor = true;
            BotonGestionarStock.Click += BotonGestionarStock_Click;
            // 
            // BotonOrdenesRecepcion
            // 
            BotonOrdenesRecepcion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesRecepcion.Location = new Point(353, 129);
            BotonOrdenesRecepcion.Margin = new Padding(3, 4, 3, 4);
            BotonOrdenesRecepcion.Name = "BotonOrdenesRecepcion";
            BotonOrdenesRecepcion.Size = new Size(225, 137);
            BotonOrdenesRecepcion.TabIndex = 1;
            BotonOrdenesRecepcion.Text = "Órdenes de Recepción";
            BotonOrdenesRecepcion.UseVisualStyleBackColor = true;
            BotonOrdenesRecepcion.Click += BotonOrdenesRecepcion_Click;
            // 
            // BotonOrdenesPreparacion
            // 
            BotonOrdenesPreparacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesPreparacion.Location = new Point(619, 129);
            BotonOrdenesPreparacion.Margin = new Padding(3, 4, 3, 4);
            BotonOrdenesPreparacion.Name = "BotonOrdenesPreparacion";
            BotonOrdenesPreparacion.Size = new Size(225, 137);
            BotonOrdenesPreparacion.TabIndex = 2;
            BotonOrdenesPreparacion.Text = "Órdenes de Preparación";
            BotonOrdenesPreparacion.UseVisualStyleBackColor = true;
            BotonOrdenesPreparacion.Click += BotonOrdenesPreparacion_Click;
            // 
            // BotonOrdenesSeleccion
            // 
            BotonOrdenesSeleccion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesSeleccion.Location = new Point(233, 275);
            BotonOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            BotonOrdenesSeleccion.Name = "BotonOrdenesSeleccion";
            BotonOrdenesSeleccion.Size = new Size(225, 137);
            BotonOrdenesSeleccion.TabIndex = 3;
            BotonOrdenesSeleccion.Text = "Órdenes de Selección";
            BotonOrdenesSeleccion.UseVisualStyleBackColor = true;
            BotonOrdenesSeleccion.Click += BotonOrdenesSeleccion_Click;
            // 
            // BotonOrdenesEntrega
            // 
            BotonOrdenesEntrega.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonOrdenesEntrega.Location = new Point(485, 275);
            BotonOrdenesEntrega.Margin = new Padding(3, 4, 3, 4);
            BotonOrdenesEntrega.Name = "BotonOrdenesEntrega";
            BotonOrdenesEntrega.Size = new Size(225, 137);
            BotonOrdenesEntrega.TabIndex = 4;
            BotonOrdenesEntrega.Text = "Órdenes de Entrega";
            BotonOrdenesEntrega.UseVisualStyleBackColor = true;
            BotonOrdenesEntrega.Click += BotonOrdenesEntrega_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(686, 553);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 5;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // PaginaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonVolver);
            Controls.Add(BotonOrdenesEntrega);
            Controls.Add(BotonOrdenesSeleccion);
            Controls.Add(BotonOrdenesPreparacion);
            Controls.Add(BotonOrdenesRecepcion);
            Controls.Add(BotonGestionarStock);
            Margin = new Padding(3, 4, 3, 4);
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
