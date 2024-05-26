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
            TxtIdCliente = new TextBox();
            LabelIdCliente = new Label();
            LabelIdOrdenPreparacion = new Label();
            TxtFecha = new TextBox();
            LabelFecha = new Label();
            BotonMoverOrdenPreparacion = new Button();
            BotonMoverOrdenSeleccion = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            listView2 = new ListView();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            ComboBoxIDOrdenPreparacion = new ComboBox();
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
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(11, 70);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(212, 23);
            TxtIdCliente.TabIndex = 44;
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
            // TxtFecha
            // 
            TxtFecha.Location = new Point(229, 71);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(212, 23);
            TxtFecha.TabIndex = 55;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 324);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 61;
            label1.Text = "Ordenes de preparación pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 324);
            label2.Name = "label2";
            label2.Size = new Size(314, 15);
            label2.TabIndex = 62;
            label2.Text = "Orden de preparación incluidas en esta orden de selección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 415);
            label3.Name = "label3";
            label3.Size = new Size(356, 15);
            label3.TabIndex = 63;
            label3.Text = "Detalle de la orden de selección. Es una lista de producto/cantidad";
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
            ListViewOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { NroOrdenPreparacionCol, IDClienteCol, DescripcionClienteCol, EstadoOrdenPreparacionCol, PrioridadOrdenPreparacionCol, FechaOrdenPreparacionCol, IDProductoCol });
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
            ComboBoxPrioridad.Location = new Point(230, 27);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(212, 23);
            ComboBoxPrioridad.TabIndex = 69;
            // 
            // listView2
            // 
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Location = new Point(9, 389);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(831, 265);
            listView2.TabIndex = 71;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(505, 125);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(335, 229);
            listView1.TabIndex = 72;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NroOrdenPreparacion";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID Cliente";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Descripcion Cliente";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Estado";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Prioridad";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fecha Orden Preparacion";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID Producto";
            columnHeader7.Width = 250;
            // 
            // ComboBoxIDOrdenPreparacion
            // 
            ComboBoxIDOrdenPreparacion.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxIDOrdenPreparacion.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxIDOrdenPreparacion.FormattingEnabled = true;
            ComboBoxIDOrdenPreparacion.Location = new Point(9, 26);
            ComboBoxIDOrdenPreparacion.Name = "ComboBoxIDOrdenPreparacion";
            ComboBoxIDOrdenPreparacion.Size = new Size(212, 23);
            ComboBoxIDOrdenPreparacion.TabIndex = 73;
            // 
            // CrearOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(852, 688);
            Controls.Add(ComboBoxIDOrdenPreparacion);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label3);
            Controls.Add(listView2);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(label1);
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
            Controls.Add(TxtIdCliente);
            Controls.Add(LabelIdCliente);
            Controls.Add(LabelIdOrdenPreparacion);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox TxtIdCliente;
        private Label LabelIdCliente;
        private Label LabelIdOrdenPreparacion;
        private TextBox TxtFecha;
        private Label LabelFecha;
        private Button BotonMoverOrdenPreparacion;
        private Button BotonMoverOrdenSeleccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BotonLimpiarBusqueda;
        private Button BotonLimpiarOrdenesSeleccion;
        private ListView ListViewOrdenesPreparacion;
        private ComboBox ComboBoxPrioridad;
        private ListView listView2;
        private ColumnHeader NroOrdenPreparacionCol;
        private ColumnHeader IDClienteCol;
        private ColumnHeader DescripcionClienteCol;
        private ColumnHeader EstadoOrdenPreparacionCol;
        private ColumnHeader PrioridadOrdenPreparacionCol;
        private ColumnHeader FechaOrdenPreparacionCol;
        private ColumnHeader IDProductoCol;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ComboBox ComboBoxIDOrdenPreparacion;
    }
}