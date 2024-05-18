namespace Pampazon.GrupoB.Prototipos
{
    partial class ConfirmarOrdenRecepcionForm
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
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            BotonVolver = new Button();
            TxtFechaRecepcion = new TextBox();
            LabelEspacioDisponible = new Label();
            TxtIdProducto = new TextBox();
            LabelPosicion = new Label();
            TxtIdCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIdOrdenRecepcion = new TextBox();
            LabelIDProducto = new Label();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(307, 415);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 40;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(113, 415);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(188, 23);
            BotonBuscar.TabIndex = 39;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(501, 415);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 38;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFechaRecepcion
            // 
            TxtFechaRecepcion.Location = new Point(416, 226);
            TxtFechaRecepcion.Name = "TxtFechaRecepcion";
            TxtFechaRecepcion.Size = new Size(212, 23);
            TxtFechaRecepcion.TabIndex = 37;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(416, 208);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(96, 15);
            LabelEspacioDisponible.TabIndex = 36;
            LabelEspacioDisponible.Text = "Fecha Recepción";
            // 
            // TxtIdProducto
            // 
            TxtIdProducto.Location = new Point(416, 182);
            TxtIdProducto.Name = "TxtIdProducto";
            TxtIdProducto.Size = new Size(212, 23);
            TxtIdProducto.TabIndex = 35;
            // 
            // LabelPosicion
            // 
            LabelPosicion.AutoSize = true;
            LabelPosicion.Location = new Point(416, 164);
            LabelPosicion.Name = "LabelPosicion";
            LabelPosicion.Size = new Size(70, 15);
            LabelPosicion.TabIndex = 34;
            LabelPosicion.Text = "ID Producto";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(175, 226);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(212, 23);
            TxtIdCliente.TabIndex = 33;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(175, 208);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 32;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenRecepcion
            // 
            TxtIdOrdenRecepcion.Location = new Point(175, 182);
            TxtIdOrdenRecepcion.Name = "TxtIdOrdenRecepcion";
            TxtIdOrdenRecepcion.Size = new Size(212, 23);
            TxtIdOrdenRecepcion.TabIndex = 31;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(175, 164);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(112, 15);
            LabelIDProducto.TabIndex = 30;
            LabelIDProducto.Text = "ID Orden Recepción";
            // 
            // ConfirmarOrdenRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFechaRecepcion);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIdProducto);
            Controls.Add(LabelPosicion);
            Controls.Add(TxtIdCliente);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIdOrdenRecepcion);
            Controls.Add(LabelIDProducto);
            Name = "ConfirmarOrdenRecepcionForm";
            Text = "ConfirmarOrdenRecepcionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonBuscar;
        private Button BotonVolver;
        private TextBox TxtFechaRecepcion;
        private Label LabelEspacioDisponible;
        private TextBox TxtIdProducto;
        private Label LabelPosicion;
        private TextBox TxtIdCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIdOrdenRecepcion;
        private Label LabelIDProducto;
    }
}