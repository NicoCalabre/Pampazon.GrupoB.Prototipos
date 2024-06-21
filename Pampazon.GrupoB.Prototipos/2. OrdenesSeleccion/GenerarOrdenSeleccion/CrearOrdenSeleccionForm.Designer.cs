namespace Pampazon.GrupoB.Prototipos
{
    partial class CrearOrdenSeleccionForm
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
            BotonGenerarOrdenSeleccion = new Button();
            BotonBuscar = new Button();
            BotonVolver = new Button();
            LabelPrioridad = new Label();
            LabelIdCliente = new Label();
            LabelIdOrdenPreparacion = new Label();
            LabelFecha = new Label();
            BotonMoverOrdenPreparacion = new Button();
            BotonMoverOrdenSeleccion = new Button();
            BotonLimpiarBusqueda = new Button();
            BotonLimpiarOrdenesSeleccion = new Button();
            ListViewOrdenesPreparacion = new ListView();
            NroOrdenPreparacionCol = new ColumnHeader();
            IDClienteCol = new ColumnHeader();
            DescripcionClienteCol = new ColumnHeader();
            EstadoOrdenPreparacionCol = new ColumnHeader();
            PrioridadOrdenPreparacionCol = new ColumnHeader();
            FechaOrdenPreparacionCol = new ColumnHeader();
            DescripcionProductosCol = new ColumnHeader();
            ComboBoxPrioridad = new ComboBox();
            ListViewOrdenesSeleccion = new ListView();
            IDOrdenSeleccionCol = new ColumnHeader();
            IDProductoSeleccionadaCol = new ColumnHeader();
            CantidadSeleccionadaCol = new ColumnHeader();
            UbicacionSeleccionadaCol = new ColumnHeader();
            ListViewOrdenesPreparacionSeleccionadas = new ListView();
            NroOrdenPreparacionSeleccionadaCol = new ColumnHeader();
            IDClienteSeleccionadoCol = new ColumnHeader();
            DescripcionClienteSeleccionadoCol = new ColumnHeader();
            EstadoSeleccionadoCol = new ColumnHeader();
            PrioridadSeleccionadoCol = new ColumnHeader();
            FechaOrdenPreparacionSeleccionadoCol = new ColumnHeader();
            IDProductoSeleccionadoCol = new ColumnHeader();
            ComboBoxIDOrdenPreparacion = new ComboBox();
            ComboBoxIDCliente = new ComboBox();
            ComboBoxFecha = new ComboBox();
            SuspendLayout();
            // 
            // BotonGenerarOrdenSeleccion
            // 
            BotonGenerarOrdenSeleccion.Location = new Point(331, 360);
            BotonGenerarOrdenSeleccion.Name = "BotonGenerarOrdenSeleccion";
            BotonGenerarOrdenSeleccion.Size = new Size(188, 23);
            BotonGenerarOrdenSeleccion.TabIndex = 51;
            BotonGenerarOrdenSeleccion.Text = "Generar Orden de Selección";
            BotonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            BotonGenerarOrdenSeleccion.Click += BotonGenerarOrdenSeleccion_Click_1;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(448, 27);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(188, 23);
            BotonBuscar.TabIndex = 50;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click_1;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(652, 660);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 49;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // LabelPrioridad
            // 
            LabelPrioridad.AutoSize = true;
            LabelPrioridad.ForeColor = SystemColors.ActiveCaptionText;
            LabelPrioridad.Location = new Point(229, 9);
            LabelPrioridad.Name = "LabelPrioridad";
            LabelPrioridad.Size = new Size(55, 15);
            LabelPrioridad.TabIndex = 47;
            LabelPrioridad.Text = "Prioridad";
            // 
            // LabelIdCliente
            // 
            LabelIdCliente.AutoSize = true;
            LabelIdCliente.ForeColor = SystemColors.ActiveCaptionText;
            LabelIdCliente.Location = new Point(11, 52);
            LabelIdCliente.Name = "LabelIdCliente";
            LabelIdCliente.Size = new Size(58, 15);
            LabelIdCliente.TabIndex = 43;
            LabelIdCliente.Text = "ID Cliente";
            // 
            // LabelIdOrdenPreparacion
            // 
            LabelIdOrdenPreparacion.AutoSize = true;
            LabelIdOrdenPreparacion.ForeColor = SystemColors.ActiveCaptionText;
            LabelIdOrdenPreparacion.Location = new Point(12, 9);
            LabelIdOrdenPreparacion.Name = "LabelIdOrdenPreparacion";
            LabelIdOrdenPreparacion.Size = new Size(120, 15);
            LabelIdOrdenPreparacion.TabIndex = 41;
            LabelIdOrdenPreparacion.Text = "ID Orden Preparación";
            // 
            // LabelFecha
            // 
            LabelFecha.AutoSize = true;
            LabelFecha.ForeColor = SystemColors.ActiveCaptionText;
            LabelFecha.Location = new Point(229, 53);
            LabelFecha.Name = "LabelFecha";
            LabelFecha.Size = new Size(38, 15);
            LabelFecha.TabIndex = 54;
            LabelFecha.Text = "Fecha";
            // 
            // BotonMoverOrdenPreparacion
            // 
            BotonMoverOrdenPreparacion.Location = new Point(350, 221);
            BotonMoverOrdenPreparacion.Name = "BotonMoverOrdenPreparacion";
            BotonMoverOrdenPreparacion.Size = new Size(149, 23);
            BotonMoverOrdenPreparacion.TabIndex = 58;
            BotonMoverOrdenPreparacion.Text = "->";
            BotonMoverOrdenPreparacion.UseVisualStyleBackColor = true;
            BotonMoverOrdenPreparacion.Click += BotonMoverOrdenPreparacion_Click;
            // 
            // BotonMoverOrdenSeleccion
            // 
            BotonMoverOrdenSeleccion.Location = new Point(350, 250);
            BotonMoverOrdenSeleccion.Name = "BotonMoverOrdenSeleccion";
            BotonMoverOrdenSeleccion.Size = new Size(149, 23);
            BotonMoverOrdenSeleccion.TabIndex = 59;
            BotonMoverOrdenSeleccion.Text = "<-";
            BotonMoverOrdenSeleccion.UseVisualStyleBackColor = true;
            BotonMoverOrdenSeleccion.Click += BotonMoverOrdenSeleccion_Click;
            // 
            // BotonLimpiarBusqueda
            // 
            BotonLimpiarBusqueda.Location = new Point(642, 27);
            BotonLimpiarBusqueda.Name = "BotonLimpiarBusqueda";
            BotonLimpiarBusqueda.Size = new Size(188, 23);
            BotonLimpiarBusqueda.TabIndex = 64;
            BotonLimpiarBusqueda.Text = "Limpiar";
            BotonLimpiarBusqueda.UseVisualStyleBackColor = true;
            BotonLimpiarBusqueda.Click += BotonLimpiarBusqueda_Click;
            // 
            // BotonLimpiarOrdenesSeleccion
            // 
            BotonLimpiarOrdenesSeleccion.Location = new Point(458, 660);
            BotonLimpiarOrdenesSeleccion.Name = "BotonLimpiarOrdenesSeleccion";
            BotonLimpiarOrdenesSeleccion.Size = new Size(188, 23);
            BotonLimpiarOrdenesSeleccion.TabIndex = 65;
            BotonLimpiarOrdenesSeleccion.Text = "Limpiar";
            BotonLimpiarOrdenesSeleccion.UseVisualStyleBackColor = true;
            BotonLimpiarOrdenesSeleccion.Click += BotonLimpiarOrdenesSeleccion_Click;
            // 
            // ListViewOrdenesPreparacion
            // 
            ListViewOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { NroOrdenPreparacionCol, IDClienteCol, DescripcionClienteCol, EstadoOrdenPreparacionCol, PrioridadOrdenPreparacionCol, FechaOrdenPreparacionCol, DescripcionProductosCol });
            ListViewOrdenesPreparacion.FullRowSelect = true;
            ListViewOrdenesPreparacion.GridLines = true;
            ListViewOrdenesPreparacion.Location = new Point(9, 125);
            ListViewOrdenesPreparacion.MultiSelect = false;
            ListViewOrdenesPreparacion.Name = "ListViewOrdenesPreparacion";
            ListViewOrdenesPreparacion.Size = new Size(335, 229);
            ListViewOrdenesPreparacion.TabIndex = 66;
            ListViewOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            ListViewOrdenesPreparacion.View = View.Details;
            // 
            // NroOrdenPreparacionCol
            // 
            NroOrdenPreparacionCol.Text = "ID Orden Preparación";
            NroOrdenPreparacionCol.Width = 100;
            // 
            // IDClienteCol
            // 
            IDClienteCol.Text = "ID Cliente";
            IDClienteCol.Width = 80;
            // 
            // DescripcionClienteCol
            // 
            DescripcionClienteCol.Text = "Descripcion Cliente";
            DescripcionClienteCol.Width = 80;
            // 
            // EstadoOrdenPreparacionCol
            // 
            EstadoOrdenPreparacionCol.Text = "Estado";
            // 
            // PrioridadOrdenPreparacionCol
            // 
            PrioridadOrdenPreparacionCol.Text = "Prioridad";
            // 
            // FechaOrdenPreparacionCol
            // 
            FechaOrdenPreparacionCol.Text = "Fecha Orden Preparacion";
            FechaOrdenPreparacionCol.Width = 100;
            // 
            // DescripcionProductosCol
            // 
            DescripcionProductosCol.Text = "Descripción Productos";
            DescripcionProductosCol.Width = 250;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(230, 27);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(212, 23);
            ComboBoxPrioridad.TabIndex = 69;
            // 
            // ListViewOrdenesSeleccion
            // 
            ListViewOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { IDOrdenSeleccionCol, IDProductoSeleccionadaCol, CantidadSeleccionadaCol, UbicacionSeleccionadaCol });
            ListViewOrdenesSeleccion.FullRowSelect = true;
            ListViewOrdenesSeleccion.GridLines = true;
            ListViewOrdenesSeleccion.Location = new Point(9, 389);
            ListViewOrdenesSeleccion.MultiSelect = false;
            ListViewOrdenesSeleccion.Name = "ListViewOrdenesSeleccion";
            ListViewOrdenesSeleccion.Size = new Size(831, 265);
            ListViewOrdenesSeleccion.Sorting = SortOrder.Ascending;
            ListViewOrdenesSeleccion.TabIndex = 71;
            ListViewOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            ListViewOrdenesSeleccion.View = View.Details;
            // 
            // IDOrdenSeleccionCol
            // 
            IDOrdenSeleccionCol.Text = "ID Orden Selección";
            IDOrdenSeleccionCol.Width = 100;
            // 
            // IDProductoSeleccionadaCol
            // 
            IDProductoSeleccionadaCol.Text = "ID Producto";
            IDProductoSeleccionadaCol.Width = 100;
            // 
            // CantidadSeleccionadaCol
            // 
            CantidadSeleccionadaCol.Text = "Cantidad";
            CantidadSeleccionadaCol.Width = 100;
            // 
            // UbicacionSeleccionadaCol
            // 
            UbicacionSeleccionadaCol.Text = "Ubicación";
            UbicacionSeleccionadaCol.Width = 100;
            // 
            // ListViewOrdenesPreparacionSeleccionadas
            // 
            ListViewOrdenesPreparacionSeleccionadas.Columns.AddRange(new ColumnHeader[] { NroOrdenPreparacionSeleccionadaCol, IDClienteSeleccionadoCol, DescripcionClienteSeleccionadoCol, EstadoSeleccionadoCol, PrioridadSeleccionadoCol, FechaOrdenPreparacionSeleccionadoCol, IDProductoSeleccionadoCol });
            ListViewOrdenesPreparacionSeleccionadas.FullRowSelect = true;
            ListViewOrdenesPreparacionSeleccionadas.GridLines = true;
            ListViewOrdenesPreparacionSeleccionadas.Location = new Point(505, 125);
            ListViewOrdenesPreparacionSeleccionadas.MultiSelect = false;
            ListViewOrdenesPreparacionSeleccionadas.Name = "ListViewOrdenesPreparacionSeleccionadas";
            ListViewOrdenesPreparacionSeleccionadas.Size = new Size(335, 229);
            ListViewOrdenesPreparacionSeleccionadas.TabIndex = 72;
            ListViewOrdenesPreparacionSeleccionadas.UseCompatibleStateImageBehavior = false;
            ListViewOrdenesPreparacionSeleccionadas.View = View.Details;
            // 
            // NroOrdenPreparacionSeleccionadaCol
            // 
            NroOrdenPreparacionSeleccionadaCol.Text = "ID Orden Preparación";
            NroOrdenPreparacionSeleccionadaCol.Width = 100;
            // 
            // IDClienteSeleccionadoCol
            // 
            IDClienteSeleccionadoCol.Text = "ID Cliente";
            IDClienteSeleccionadoCol.Width = 80;
            // 
            // DescripcionClienteSeleccionadoCol
            // 
            DescripcionClienteSeleccionadoCol.Text = "Descripcion Cliente";
            DescripcionClienteSeleccionadoCol.Width = 80;
            // 
            // EstadoSeleccionadoCol
            // 
            EstadoSeleccionadoCol.Text = "Estado";
            // 
            // PrioridadSeleccionadoCol
            // 
            PrioridadSeleccionadoCol.Text = "Prioridad";
            // 
            // FechaOrdenPreparacionSeleccionadoCol
            // 
            FechaOrdenPreparacionSeleccionadoCol.Text = "Fecha Orden Preparacion";
            FechaOrdenPreparacionSeleccionadoCol.Width = 100;
            // 
            // IDProductoSeleccionadoCol
            // 
            IDProductoSeleccionadoCol.Text = "ID Producto";
            IDProductoSeleccionadoCol.Width = 250;
            // 
            // ComboBoxIDOrdenPreparacion
            // 
            ComboBoxIDOrdenPreparacion.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxIDOrdenPreparacion.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxIDOrdenPreparacion.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDOrdenPreparacion.FormattingEnabled = true;
            ComboBoxIDOrdenPreparacion.Location = new Point(9, 26);
            ComboBoxIDOrdenPreparacion.Name = "ComboBoxIDOrdenPreparacion";
            ComboBoxIDOrdenPreparacion.Size = new Size(212, 23);
            ComboBoxIDOrdenPreparacion.TabIndex = 73;
            // 
            // ComboBoxIDCliente
            // 
            ComboBoxIDCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxIDCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxIDCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDCliente.FormattingEnabled = true;
            ComboBoxIDCliente.Location = new Point(9, 71);
            ComboBoxIDCliente.Name = "ComboBoxIDCliente";
            ComboBoxIDCliente.Size = new Size(212, 23);
            ComboBoxIDCliente.TabIndex = 75;
            // 
            // ComboBoxFecha
            // 
            ComboBoxFecha.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxFecha.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFecha.FormattingEnabled = true;
            ComboBoxFecha.Location = new Point(230, 71);
            ComboBoxFecha.Name = "ComboBoxFecha";
            ComboBoxFecha.Size = new Size(212, 23);
            ComboBoxFecha.TabIndex = 76;
            // 
            // CrearOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(852, 688);
            Controls.Add(ComboBoxFecha);
            Controls.Add(ComboBoxIDCliente);
            Controls.Add(ComboBoxIDOrdenPreparacion);
            Controls.Add(ListViewOrdenesPreparacionSeleccionadas);
            Controls.Add(ListViewOrdenesSeleccion);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(ListViewOrdenesPreparacion);
            Controls.Add(BotonLimpiarOrdenesSeleccion);
            Controls.Add(BotonLimpiarBusqueda);
            Controls.Add(BotonMoverOrdenSeleccion);
            Controls.Add(BotonMoverOrdenPreparacion);
            Controls.Add(LabelFecha);
            Controls.Add(BotonGenerarOrdenSeleccion);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(LabelPrioridad);
            Controls.Add(LabelIdCliente);
            Controls.Add(LabelIdOrdenPreparacion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrearOrdenSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearOrdenSeleccionForm";
            Load += CrearOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonGenerarOrdenSeleccion;
        private Button BotonBuscar;
        private Button BotonVolver;
        private Label LabelPrioridad;
        private Label LabelIdCliente;
        private Label LabelIdOrdenPreparacion;
        private Label LabelFecha;
        private Button BotonMoverOrdenPreparacion;
        private Button BotonMoverOrdenSeleccion;
        private Button BotonLimpiarBusqueda;
        private Button BotonLimpiarOrdenesSeleccion;
        private ListView ListViewOrdenesPreparacion;
        private ComboBox ComboBoxPrioridad;
        private ListView ListViewOrdenesSeleccion;
        private ColumnHeader NroOrdenPreparacionCol;
        private ColumnHeader IDClienteCol;
        private ColumnHeader DescripcionClienteCol;
        private ColumnHeader EstadoOrdenPreparacionCol;
        private ColumnHeader PrioridadOrdenPreparacionCol;
        private ColumnHeader FechaOrdenPreparacionCol;
        private ColumnHeader DescripcionProductosCol;
        private ListView ListViewOrdenesPreparacionSeleccionadas;
        private ColumnHeader NroOrdenPreparacionSeleccionadaCol;
        private ColumnHeader IDClienteSeleccionadoCol;
        private ColumnHeader DescripcionClienteSeleccionadoCol;
        private ColumnHeader EstadoSeleccionadoCol;
        private ColumnHeader PrioridadSeleccionadoCol;
        private ColumnHeader FechaOrdenPreparacionSeleccionadoCol;
        private ColumnHeader IDProductoSeleccionadoCol;
        private ComboBox ComboBoxIDOrdenPreparacion;
        private ColumnHeader IDOrdenSeleccionCol;
        private ColumnHeader IDProductoSeleccionadaCol;
        private ColumnHeader CantidadSeleccionadaCol;
        private ColumnHeader UbicacionSeleccionadaCol;
        private ComboBox ComboBoxIDCliente;
        private ComboBox ComboBoxFecha;
    }
}