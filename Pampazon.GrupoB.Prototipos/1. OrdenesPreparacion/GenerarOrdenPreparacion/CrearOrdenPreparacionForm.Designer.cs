namespace Pampazon.GrupoB.Prototipos
{
    partial class CrearOrdenPreparacionForm
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
            BotonCrear = new Button();
            BotonVolver = new Button();
            TxtFecha = new TextBox();
            LabelEspacioDisponible = new Label();
            TxtIdProducto = new TextBox();
            LabelPosicion = new Label();
            TxtIdCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIdOrdenPreparacion = new TextBox();
            LabelIDProducto = new Label();
            TxtCantidad = new TextBox();
            label1 = new Label();
            PrioridadLabel = new Label();
            OrdenesPreparacionList = new ListView();
            EliminarProductoBoton = new Button();
            AgregarProductoBoton = new Button();
            ComboBoxPrioridad = new ComboBox();
            ComboBoxEstado = new ComboBox();
            EstadoLabel = new Label();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(277, 525);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 51;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click_1;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(83, 525);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(188, 23);
            BotonCrear.TabIndex = 50;
            BotonCrear.Text = "&Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            BotonCrear.Click += BotonCrear_Click_1;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(471, 525);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 49;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(386, 86);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(173, 23);
            TxtFecha.TabIndex = 48;
            TxtFecha.TextChanged += TxtFecha_TextChanged;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(386, 68);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(38, 15);
            LabelEspacioDisponible.TabIndex = 47;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // TxtIdProducto
            // 
            TxtIdProducto.Location = new Point(22, 30);
            TxtIdProducto.Name = "TxtIdProducto";
            TxtIdProducto.Size = new Size(172, 23);
            TxtIdProducto.TabIndex = 46;
            TxtIdProducto.TextChanged += TxtIdProducto_TextChanged;
            // 
            // LabelPosicion
            // 
            LabelPosicion.AutoSize = true;
            LabelPosicion.Location = new Point(22, 12);
            LabelPosicion.Name = "LabelPosicion";
            LabelPosicion.Size = new Size(70, 15);
            LabelPosicion.TabIndex = 45;
            LabelPosicion.Text = "ID Producto";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(207, 86);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(173, 23);
            TxtIdCliente.TabIndex = 44;
            TxtIdCliente.TextChanged += TxtIdCliente_TextChanged;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(207, 68);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 43;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenPreparacion
            // 
            TxtIdOrdenPreparacion.Location = new Point(21, 86);
            TxtIdOrdenPreparacion.Name = "TxtIdOrdenPreparacion";
            TxtIdOrdenPreparacion.Size = new Size(173, 23);
            TxtIdOrdenPreparacion.TabIndex = 42;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(22, 68);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(120, 15);
            LabelIDProducto.TabIndex = 41;
            LabelIDProducto.Text = "ID Orden Preparación";
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(207, 30);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(172, 23);
            TxtCantidad.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 12);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 54;
            label1.Text = "Cantidad";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(569, 12);
            PrioridadLabel.Name = "PrioridadLabel";
            PrioridadLabel.Size = new Size(55, 15);
            PrioridadLabel.TabIndex = 52;
            PrioridadLabel.Text = "Prioridad";
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.Location = new Point(12, 236);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(726, 269);
            OrdenesPreparacionList.TabIndex = 56;
            OrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionList.View = View.Details;
            OrdenesPreparacionList.SelectedIndexChanged += OrdenesPreparacionList_SelectedIndexChanged;
            // 
            // EliminarProductoBoton
            // 
            EliminarProductoBoton.Location = new Point(587, 192);
            EliminarProductoBoton.Name = "EliminarProductoBoton";
            EliminarProductoBoton.Size = new Size(146, 23);
            EliminarProductoBoton.TabIndex = 57;
            EliminarProductoBoton.Text = "Eliminar Producto";
            EliminarProductoBoton.UseVisualStyleBackColor = true;
            EliminarProductoBoton.Click += button1_Click;
            // 
            // AgregarProductoBoton
            // 
            AgregarProductoBoton.Location = new Point(435, 192);
            AgregarProductoBoton.Name = "AgregarProductoBoton";
            AgregarProductoBoton.Size = new Size(146, 23);
            AgregarProductoBoton.TabIndex = 58;
            AgregarProductoBoton.Text = "Agregar Producto";
            AgregarProductoBoton.UseVisualStyleBackColor = true;
            AgregarProductoBoton.Click += button2_Click;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(564, 30);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(173, 23);
            ComboBoxPrioridad.TabIndex = 59;
            ComboBoxPrioridad.SelectedIndexChanged += ComboBoxPrioridad_SelectedIndexChanged;
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(386, 30);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(173, 23);
            ComboBoxEstado.TabIndex = 61;
            ComboBoxEstado.SelectedIndexChanged += ComboBoxEstado_SelectedIndexChanged;
            // 
            // EstadoLabel
            // 
            EstadoLabel.AutoSize = true;
            EstadoLabel.Location = new Point(391, 12);
            EstadoLabel.Name = "EstadoLabel";
            EstadoLabel.Size = new Size(42, 15);
            EstadoLabel.TabIndex = 60;
            EstadoLabel.Text = "Estado";
            EstadoLabel.Click += label3_Click;
            // 
            // CrearOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(754, 572);
            Controls.Add(ComboBoxEstado);
            Controls.Add(EstadoLabel);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(AgregarProductoBoton);
            Controls.Add(EliminarProductoBoton);
            Controls.Add(OrdenesPreparacionList);
            Controls.Add(TxtCantidad);
            Controls.Add(label1);
            Controls.Add(PrioridadLabel);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCrear);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIdProducto);
            Controls.Add(LabelPosicion);
            Controls.Add(TxtIdCliente);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIdOrdenPreparacion);
            Controls.Add(LabelIDProducto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrearOrdenPreparacionForm";
            Text = "CrearOrdenPreparacionForm";
            Load += CrearOrdenPreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonCrear;
        private Button BotonVolver;
        private TextBox TxtFecha;
        private Label LabelEspacioDisponible;
        private TextBox TxtIdProducto;
        private Label LabelPosicion;
        private TextBox TxtIdCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIdOrdenPreparacion;
        private Label LabelIDProducto;
        private TextBox TxtCantidad;
        private Label label1;
        private Label PrioridadLabel;
        private ListView OrdenesPreparacionList;
        private Button EliminarProductoBoton;
        private Button AgregarProductoBoton;
        private ComboBox ComboBoxPrioridad;
        private ComboBox ComboBoxEstado;
        private Label EstadoLabel;
    }
}