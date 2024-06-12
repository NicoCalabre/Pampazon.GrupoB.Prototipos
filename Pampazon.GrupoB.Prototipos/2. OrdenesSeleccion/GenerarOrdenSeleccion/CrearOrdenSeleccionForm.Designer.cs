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
            TxtFecha = new TextBox();
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
            IDProductoCol = new ColumnHeader();
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
            SuspendLayout();
            // 
            // BotonGenerarOrdenSeleccion
            // 
            BotonGenerarOrdenSeleccion.Location = new Point(378, 480);
            BotonGenerarOrdenSeleccion.Margin = new Padding(3, 4, 3, 4);
            BotonGenerarOrdenSeleccion.Name = "BotonGenerarOrdenSeleccion";
            BotonGenerarOrdenSeleccion.Size = new Size(215, 31);
            BotonGenerarOrdenSeleccion.TabIndex = 51;
            BotonGenerarOrdenSeleccion.Text = "Generar Orden de Selección";
            BotonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            BotonGenerarOrdenSeleccion.Click += BotonGenerarOrdenSeleccion_Click_1;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(512, 36);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(215, 31);
            BotonBuscar.TabIndex = 50;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click_1;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(745, 880);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 49;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // LabelPrioridad
            // 
            LabelPrioridad.AutoSize = true;
            LabelPrioridad.ForeColor = SystemColors.ActiveCaptionText;
            LabelPrioridad.Location = new Point(262, 12);
            LabelPrioridad.Name = "LabelPrioridad";
            LabelPrioridad.Size = new Size(70, 20);
            LabelPrioridad.TabIndex = 47;
            LabelPrioridad.Text = "Prioridad";
            // 
            // LabelIdCliente
            // 
            LabelIdCliente.AutoSize = true;
            LabelIdCliente.ForeColor = SystemColors.ActiveCaptionText;
            LabelIdCliente.Location = new Point(13, 69);
            LabelIdCliente.Name = "LabelIdCliente";
            LabelIdCliente.Size = new Size(74, 20);
            LabelIdCliente.TabIndex = 43;
            LabelIdCliente.Text = "ID Cliente";
            // 
            // LabelIdOrdenPreparacion
            // 
            LabelIdOrdenPreparacion.AutoSize = true;
            LabelIdOrdenPreparacion.ForeColor = SystemColors.ActiveCaptionText;
            LabelIdOrdenPreparacion.Location = new Point(14, 12);
            LabelIdOrdenPreparacion.Name = "LabelIdOrdenPreparacion";
            LabelIdOrdenPreparacion.Size = new Size(152, 20);
            LabelIdOrdenPreparacion.TabIndex = 41;
            LabelIdOrdenPreparacion.Text = "ID Orden Preparación";
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(262, 95);
            TxtFecha.Margin = new Padding(3, 4, 3, 4);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(242, 27);
            TxtFecha.TabIndex = 55;
            // 
            // LabelFecha
            // 
            LabelFecha.AutoSize = true;
            LabelFecha.ForeColor = SystemColors.ActiveCaptionText;
            LabelFecha.Location = new Point(262, 71);
            LabelFecha.Name = "LabelFecha";
            LabelFecha.Size = new Size(47, 20);
            LabelFecha.TabIndex = 54;
            LabelFecha.Text = "Fecha";
            // 
            // BotonMoverOrdenPreparacion
            // 
            BotonMoverOrdenPreparacion.Location = new Point(400, 295);
            BotonMoverOrdenPreparacion.Margin = new Padding(3, 4, 3, 4);
            BotonMoverOrdenPreparacion.Name = "BotonMoverOrdenPreparacion";
            BotonMoverOrdenPreparacion.Size = new Size(170, 31);
            BotonMoverOrdenPreparacion.TabIndex = 58;
            BotonMoverOrdenPreparacion.Text = "->";
            BotonMoverOrdenPreparacion.UseVisualStyleBackColor = true;
            BotonMoverOrdenPreparacion.Click += BotonMoverOrdenPreparacion_Click;
            // 
            // BotonMoverOrdenSeleccion
            // 
            BotonMoverOrdenSeleccion.Location = new Point(400, 333);
            BotonMoverOrdenSeleccion.Margin = new Padding(3, 4, 3, 4);
            BotonMoverOrdenSeleccion.Name = "BotonMoverOrdenSeleccion";
            BotonMoverOrdenSeleccion.Size = new Size(170, 31);
            BotonMoverOrdenSeleccion.TabIndex = 59;
            BotonMoverOrdenSeleccion.Text = "<-";
            BotonMoverOrdenSeleccion.UseVisualStyleBackColor = true;
            BotonMoverOrdenSeleccion.Click += BotonMoverOrdenSeleccion_Click;
            // 
            // BotonLimpiarBusqueda
            // 
            BotonLimpiarBusqueda.Location = new Point(734, 36);
            BotonLimpiarBusqueda.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiarBusqueda.Name = "BotonLimpiarBusqueda";
            BotonLimpiarBusqueda.Size = new Size(215, 31);
            BotonLimpiarBusqueda.TabIndex = 64;
            BotonLimpiarBusqueda.Text = "Limpiar";
            BotonLimpiarBusqueda.UseVisualStyleBackColor = true;
            BotonLimpiarBusqueda.Click += BotonLimpiarBusqueda_Click;
            // 
            // BotonLimpiarOrdenesSeleccion
            // 
            BotonLimpiarOrdenesSeleccion.Location = new Point(523, 880);
            BotonLimpiarOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiarOrdenesSeleccion.Name = "BotonLimpiarOrdenesSeleccion";
            BotonLimpiarOrdenesSeleccion.Size = new Size(215, 31);
            BotonLimpiarOrdenesSeleccion.TabIndex = 65;
            BotonLimpiarOrdenesSeleccion.Text = "Limpiar";
            BotonLimpiarOrdenesSeleccion.UseVisualStyleBackColor = true;
            BotonLimpiarOrdenesSeleccion.Click += BotonLimpiarOrdenesSeleccion_Click;
            // 
            // ListViewOrdenesPreparacion
            // 
            ListViewOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { NroOrdenPreparacionCol, IDClienteCol, DescripcionClienteCol, EstadoOrdenPreparacionCol, PrioridadOrdenPreparacionCol, FechaOrdenPreparacionCol, IDProductoCol });
            ListViewOrdenesPreparacion.FullRowSelect = true;
            ListViewOrdenesPreparacion.GridLines = true;
            ListViewOrdenesPreparacion.Location = new Point(10, 167);
            ListViewOrdenesPreparacion.Margin = new Padding(3, 4, 3, 4);
            ListViewOrdenesPreparacion.MultiSelect = false;
            ListViewOrdenesPreparacion.Name = "ListViewOrdenesPreparacion";
            ListViewOrdenesPreparacion.Size = new Size(382, 304);
            ListViewOrdenesPreparacion.TabIndex = 66;
            ListViewOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            ListViewOrdenesPreparacion.View = View.Details;
            // 
            // NroOrdenPreparacionCol
            // 
            NroOrdenPreparacionCol.Text = "NroOrdenPreparacion";
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
            // IDProductoCol
            // 
            IDProductoCol.Text = "ID Producto";
            IDProductoCol.Width = 250;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(263, 36);
            ComboBoxPrioridad.Margin = new Padding(3, 4, 3, 4);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(242, 28);
            ComboBoxPrioridad.TabIndex = 69;
            // 
            // ListViewOrdenesSeleccion
            // 
            ListViewOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { IDOrdenSeleccionCol, IDProductoSeleccionadaCol, CantidadSeleccionadaCol, UbicacionSeleccionadaCol });
            ListViewOrdenesSeleccion.FullRowSelect = true;
            ListViewOrdenesSeleccion.GridLines = true;
            ListViewOrdenesSeleccion.Location = new Point(10, 519);
            ListViewOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            ListViewOrdenesSeleccion.MultiSelect = false;
            ListViewOrdenesSeleccion.Name = "ListViewOrdenesSeleccion";
            ListViewOrdenesSeleccion.Size = new Size(949, 352);
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
            ListViewOrdenesPreparacionSeleccionadas.Location = new Point(577, 167);
            ListViewOrdenesPreparacionSeleccionadas.Margin = new Padding(3, 4, 3, 4);
            ListViewOrdenesPreparacionSeleccionadas.MultiSelect = false;
            ListViewOrdenesPreparacionSeleccionadas.Name = "ListViewOrdenesPreparacionSeleccionadas";
            ListViewOrdenesPreparacionSeleccionadas.Size = new Size(382, 304);
            ListViewOrdenesPreparacionSeleccionadas.TabIndex = 72;
            ListViewOrdenesPreparacionSeleccionadas.UseCompatibleStateImageBehavior = false;
            ListViewOrdenesPreparacionSeleccionadas.View = View.Details;
            // 
            // NroOrdenPreparacionSeleccionadaCol
            // 
            NroOrdenPreparacionSeleccionadaCol.Text = "NroOrdenPreparacion";
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
            ComboBoxIDOrdenPreparacion.FormattingEnabled = true;
            ComboBoxIDOrdenPreparacion.Location = new Point(10, 35);
            ComboBoxIDOrdenPreparacion.Margin = new Padding(3, 4, 3, 4);
            ComboBoxIDOrdenPreparacion.Name = "ComboBoxIDOrdenPreparacion";
            ComboBoxIDOrdenPreparacion.Size = new Size(242, 28);
            ComboBoxIDOrdenPreparacion.TabIndex = 73;
            // 
            // ComboBoxIDCliente
            // 
            ComboBoxIDCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxIDCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxIDCliente.FormattingEnabled = true;
            ComboBoxIDCliente.Location = new Point(10, 95);
            ComboBoxIDCliente.Margin = new Padding(3, 4, 3, 4);
            ComboBoxIDCliente.Name = "ComboBoxIDCliente";
            ComboBoxIDCliente.Size = new Size(242, 28);
            ComboBoxIDCliente.TabIndex = 75;
            // 
            // CrearOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 917);
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
            Controls.Add(TxtFecha);
            Controls.Add(LabelFecha);
            Controls.Add(BotonGenerarOrdenSeleccion);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(LabelPrioridad);
            Controls.Add(LabelIdCliente);
            Controls.Add(LabelIdOrdenPreparacion);
            Name = "CrearOrdenSeleccionForm";
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
        private TextBox TxtFecha;
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
        private ColumnHeader IDProductoCol;
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
    }
}