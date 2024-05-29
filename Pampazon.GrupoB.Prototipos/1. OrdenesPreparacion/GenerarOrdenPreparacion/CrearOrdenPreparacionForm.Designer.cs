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
            LabelIDProd = new Label();
            TxtIdCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIdOrdenPreparacion = new TextBox();
            LabelIDProducto = new Label();
            TxtCantidad = new TextBox();
            LabelCantidad = new Label();
            PrioridadLabel = new Label();
            ProductosList = new ListView();
            EliminarProductoBoton = new Button();
            AgregarProductoBoton = new Button();
            ComboBoxPrioridad = new ComboBox();
            ComboBoxEstado = new ComboBox();
            EstadoLabel = new Label();
            TxtDescProd = new TextBox();
            LabelDescProd = new Label();
            TxtUbicacion = new TextBox();
            LabelUbicacion = new Label();
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
            TxtFecha.Location = new Point(387, 429);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(173, 23);
            TxtFecha.TabIndex = 48;
            TxtFecha.TextChanged += TxtFecha_TextChanged;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(387, 411);
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
            // LabelIDProd
            // 
            LabelIDProd.AutoSize = true;
            LabelIDProd.Location = new Point(22, 12);
            LabelIDProd.Name = "LabelIDProd";
            LabelIDProd.Size = new Size(70, 15);
            LabelIDProd.TabIndex = 45;
            LabelIDProd.Text = "ID Producto";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(208, 429);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(173, 23);
            TxtIdCliente.TabIndex = 44;
            TxtIdCliente.TextChanged += TxtIdCliente_TextChanged;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(208, 411);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 43;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenPreparacion
            // 
            TxtIdOrdenPreparacion.Location = new Point(22, 429);
            TxtIdOrdenPreparacion.Name = "TxtIdOrdenPreparacion";
            TxtIdOrdenPreparacion.Size = new Size(173, 23);
            TxtIdOrdenPreparacion.TabIndex = 42;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(23, 411);
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
            // LabelCantidad
            // 
            LabelCantidad.AutoSize = true;
            LabelCantidad.Location = new Point(207, 12);
            LabelCantidad.Name = "LabelCantidad";
            LabelCantidad.Size = new Size(55, 15);
            LabelCantidad.TabIndex = 54;
            LabelCantidad.Text = "Cantidad";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(570, 460);
            PrioridadLabel.Name = "PrioridadLabel";
            PrioridadLabel.Size = new Size(55, 15);
            PrioridadLabel.TabIndex = 52;
            PrioridadLabel.Text = "Prioridad";
            // 
            // ProductosList
            // 
            ProductosList.Location = new Point(22, 129);
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(726, 269);
            ProductosList.TabIndex = 56;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            ProductosList.SelectedIndexChanged += ProductosList_SelectedIndexChanged;
            // 
            // EliminarProductoBoton
            // 
            EliminarProductoBoton.Location = new Point(578, 29);
            EliminarProductoBoton.Name = "EliminarProductoBoton";
            EliminarProductoBoton.Size = new Size(146, 23);
            EliminarProductoBoton.TabIndex = 57;
            EliminarProductoBoton.Text = "Eliminar Producto";
            EliminarProductoBoton.UseVisualStyleBackColor = true;
            EliminarProductoBoton.Click += EliminarProductoBoton_Click;
            // 
            // AgregarProductoBoton
            // 
            AgregarProductoBoton.Location = new Point(426, 29);
            AgregarProductoBoton.Name = "AgregarProductoBoton";
            AgregarProductoBoton.Size = new Size(146, 23);
            AgregarProductoBoton.TabIndex = 58;
            AgregarProductoBoton.Text = "Agregar Producto";
            AgregarProductoBoton.UseVisualStyleBackColor = true;
            AgregarProductoBoton.Click += AgregarProductoBoton_Click;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(570, 478);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(173, 23);
            ComboBoxPrioridad.TabIndex = 59;
            ComboBoxPrioridad.SelectedIndexChanged += ComboBoxPrioridad_SelectedIndexChanged;
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(570, 429);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(173, 23);
            ComboBoxEstado.TabIndex = 61;
            ComboBoxEstado.SelectedIndexChanged += ComboBoxEstado_SelectedIndexChanged;
            // 
            // EstadoLabel
            // 
            EstadoLabel.AutoSize = true;
            EstadoLabel.Location = new Point(570, 411);
            EstadoLabel.Name = "EstadoLabel";
            EstadoLabel.Size = new Size(42, 15);
            EstadoLabel.TabIndex = 60;
            EstadoLabel.Text = "Estado";
            EstadoLabel.Click += label3_Click;
            // 
            // TxtDescProd
            // 
            TxtDescProd.Location = new Point(23, 77);
            TxtDescProd.Name = "TxtDescProd";
            TxtDescProd.Size = new Size(172, 23);
            TxtDescProd.TabIndex = 63;
            // 
            // LabelDescProd
            // 
            LabelDescProd.AutoSize = true;
            LabelDescProd.Location = new Point(23, 59);
            LabelDescProd.Name = "LabelDescProd";
            LabelDescProd.Size = new Size(121, 15);
            LabelDescProd.TabIndex = 62;
            LabelDescProd.Text = "Descripción Producto";
            LabelDescProd.Click += label2_Click;
            // 
            // TxtUbicacion
            // 
            TxtUbicacion.Location = new Point(209, 77);
            TxtUbicacion.Name = "TxtUbicacion";
            TxtUbicacion.Size = new Size(172, 23);
            TxtUbicacion.TabIndex = 65;
            // 
            // LabelUbicacion
            // 
            LabelUbicacion.AutoSize = true;
            LabelUbicacion.Location = new Point(209, 59);
            LabelUbicacion.Name = "LabelUbicacion";
            LabelUbicacion.Size = new Size(60, 15);
            LabelUbicacion.TabIndex = 64;
            LabelUbicacion.Text = "Ubicación";
            // 
            // CrearOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(771, 572);
            Controls.Add(TxtUbicacion);
            Controls.Add(LabelUbicacion);
            Controls.Add(TxtDescProd);
            Controls.Add(LabelDescProd);
            Controls.Add(ComboBoxEstado);
            Controls.Add(EstadoLabel);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(AgregarProductoBoton);
            Controls.Add(EliminarProductoBoton);
            Controls.Add(ProductosList);
            Controls.Add(TxtCantidad);
            Controls.Add(LabelCantidad);
            Controls.Add(PrioridadLabel);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCrear);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIdProducto);
            Controls.Add(LabelIDProd);
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
        private Label LabelIDProd;
        private TextBox TxtIdCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIdOrdenPreparacion;
        private Label LabelIDProducto;
        private TextBox TxtCantidad;
        private Label LabelCantidad;
        private Label PrioridadLabel;
        private ListView ProductosList;
        private Button EliminarProductoBoton;
        private Button AgregarProductoBoton;
        private ComboBox ComboBoxPrioridad;
        private ComboBox ComboBoxEstado;
        private Label EstadoLabel;
        private TextBox TxtDescProd;
        private Label LabelDescProd;
        private TextBox TxtUbicacion;
        private Label LabelUbicacion;
    }
}