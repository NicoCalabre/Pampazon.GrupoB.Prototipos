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
            BotonLimpiar.Location = new Point(351, 553);
            BotonLimpiar.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(215, 31);
            BotonLimpiar.TabIndex = 40;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(129, 553);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(215, 31);
            BotonBuscar.TabIndex = 39;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(573, 553);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 38;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFechaRecepcion
            // 
            TxtFechaRecepcion.Location = new Point(475, 301);
            TxtFechaRecepcion.Margin = new Padding(3, 4, 3, 4);
            TxtFechaRecepcion.Name = "TxtFechaRecepcion";
            TxtFechaRecepcion.Size = new Size(242, 27);
            TxtFechaRecepcion.TabIndex = 37;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(475, 277);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(120, 20);
            LabelEspacioDisponible.TabIndex = 36;
            LabelEspacioDisponible.Text = "Fecha Recepción";
            // 
            // TxtIdProducto
            // 
            TxtIdProducto.Location = new Point(475, 243);
            TxtIdProducto.Margin = new Padding(3, 4, 3, 4);
            TxtIdProducto.Name = "TxtIdProducto";
            TxtIdProducto.Size = new Size(242, 27);
            TxtIdProducto.TabIndex = 35;
            // 
            // LabelPosicion
            // 
            LabelPosicion.AutoSize = true;
            LabelPosicion.Location = new Point(475, 219);
            LabelPosicion.Name = "LabelPosicion";
            LabelPosicion.Size = new Size(88, 20);
            LabelPosicion.TabIndex = 34;
            LabelPosicion.Text = "ID Producto";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(200, 301);
            TxtIdCliente.Margin = new Padding(3, 4, 3, 4);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(242, 27);
            TxtIdCliente.TabIndex = 33;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(200, 277);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(74, 20);
            LabelDescripcionProducto.TabIndex = 32;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenRecepcion
            // 
            TxtIdOrdenRecepcion.Location = new Point(200, 243);
            TxtIdOrdenRecepcion.Margin = new Padding(3, 4, 3, 4);
            TxtIdOrdenRecepcion.Name = "TxtIdOrdenRecepcion";
            TxtIdOrdenRecepcion.Size = new Size(242, 27);
            TxtIdOrdenRecepcion.TabIndex = 31;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(200, 219);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(142, 20);
            LabelIDProducto.TabIndex = 30;
            LabelIDProducto.Text = "ID Orden Recepción";
            // 
            // ConfirmarOrdenRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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