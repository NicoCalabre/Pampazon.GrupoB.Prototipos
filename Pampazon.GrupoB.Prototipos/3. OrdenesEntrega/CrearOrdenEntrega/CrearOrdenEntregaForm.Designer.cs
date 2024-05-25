namespace Pampazon.GrupoB.Prototipos
{
    partial class CrearOrdenEntregaForm
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
            label2 = new Label();
            BotonCrear = new Button();
            TxtFecha = new TextBox();
            LabelEspacioDisponible = new Label();
            LabelEstado = new Label();
            TxtIdOrdenPreparacion = new TextBox();
            LabelIDProducto = new Label();
            ComboBoxEstado = new ComboBox();
            BotonAOrdenEntrega = new Button();
            BotonSacarDeOrdenEntrega = new Button();
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            GenerarOrdenEntregaBoton = new Button();
            ComboBoxPrioridad = new ComboBox();
            BotonVolver = new Button();
            OrdenesPreparacionList = new ListView();
            NroOrdenPreparacionCol = new ColumnHeader();
            IDClienteOrdenPreparacion = new ColumnHeader();
            ClientePreparacionCol = new ColumnHeader();
            EstadoOrdenPreparacionCol = new ColumnHeader();
            PrioridadOrdenPreparacionCol = new ColumnHeader();
            FechaOrdenPreparacion = new ColumnHeader();
            IDProductoOrdenPreparacion = new ColumnHeader();
            OrdenesEntregaList = new ListView();
            NroOrdenEntregaCol = new ColumnHeader();
            IDClienteOrdenEntrega = new ColumnHeader();
            ClienteEntregaCol = new ColumnHeader();
            EstadoOrdenEntregaCol = new ColumnHeader();
            PrioridadOrdenEntregaCol = new ColumnHeader();
            FechaOrdenEntrega = new ColumnHeader();
            IDProductoOrdenEntrega = new ColumnHeader();
            OrdenConfirmntregaadaList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 67;
            label2.Text = "Prioridad";
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(181, 1055);
            BotonCrear.Margin = new Padding(4, 5, 4, 5);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(269, 38);
            BotonCrear.TabIndex = 65;
            BotonCrear.Text = "&Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(16, 118);
            TxtFecha.Margin = new Padding(4, 5, 4, 5);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(301, 31);
            TxtFecha.TabIndex = 63;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(16, 88);
            LabelEspacioDisponible.Margin = new Padding(4, 0, 4, 0);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(57, 25);
            LabelEspacioDisponible.TabIndex = 62;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(330, 15);
            LabelEstado.Margin = new Padding(4, 0, 4, 0);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(66, 25);
            LabelEstado.TabIndex = 58;
            LabelEstado.Text = "Estado";
            // 
            // TxtIdOrdenPreparacion
            // 
            TxtIdOrdenPreparacion.Location = new Point(16, 45);
            TxtIdOrdenPreparacion.Margin = new Padding(4, 5, 4, 5);
            TxtIdOrdenPreparacion.Name = "TxtIdOrdenPreparacion";
            TxtIdOrdenPreparacion.Size = new Size(301, 31);
            TxtIdOrdenPreparacion.TabIndex = 57;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(17, 15);
            LabelIDProducto.Margin = new Padding(4, 0, 4, 0);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(183, 25);
            LabelIDProducto.TabIndex = 56;
            LabelIDProducto.Text = "ID Orden Preparacion";
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(330, 43);
            ComboBoxEstado.Margin = new Padding(4, 3, 4, 3);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(301, 33);
            ComboBoxEstado.TabIndex = 69;
            // 
            // BotonAOrdenEntrega
            // 
            BotonAOrdenEntrega.Location = new Point(561, 352);
            BotonAOrdenEntrega.Margin = new Padding(4, 5, 4, 5);
            BotonAOrdenEntrega.Name = "BotonAOrdenEntrega";
            BotonAOrdenEntrega.Size = new Size(124, 38);
            BotonAOrdenEntrega.TabIndex = 73;
            BotonAOrdenEntrega.Text = "->";
            BotonAOrdenEntrega.UseVisualStyleBackColor = true;
            BotonAOrdenEntrega.Click += BotonAOrdenEntrega_Click;
            // 
            // BotonSacarDeOrdenEntrega
            // 
            BotonSacarDeOrdenEntrega.Location = new Point(561, 400);
            BotonSacarDeOrdenEntrega.Margin = new Padding(4, 5, 4, 5);
            BotonSacarDeOrdenEntrega.Name = "BotonSacarDeOrdenEntrega";
            BotonSacarDeOrdenEntrega.Size = new Size(124, 38);
            BotonSacarDeOrdenEntrega.TabIndex = 74;
            BotonSacarDeOrdenEntrega.Text = "<-";
            BotonSacarDeOrdenEntrega.UseVisualStyleBackColor = true;
            BotonSacarDeOrdenEntrega.Click += BotonSacarDeOrdenEntrega_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(919, 45);
            BotonLimpiar.Margin = new Padding(4, 5, 4, 5);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(269, 38);
            BotonLimpiar.TabIndex = 79;
            BotonLimpiar.Text = "Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click_1;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(641, 45);
            BotonBuscar.Margin = new Padding(4, 5, 4, 5);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(269, 38);
            BotonBuscar.TabIndex = 78;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // GenerarOrdenEntregaBoton
            // 
            GenerarOrdenEntregaBoton.Location = new Point(486, 592);
            GenerarOrdenEntregaBoton.Margin = new Padding(4, 5, 4, 5);
            GenerarOrdenEntregaBoton.Name = "GenerarOrdenEntregaBoton";
            GenerarOrdenEntregaBoton.Size = new Size(269, 38);
            GenerarOrdenEntregaBoton.TabIndex = 80;
            GenerarOrdenEntregaBoton.Text = "Generar Orden de Entrega";
            GenerarOrdenEntregaBoton.UseVisualStyleBackColor = true;
            GenerarOrdenEntregaBoton.Click += GenerarOrdenEntregaBoton_Click;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(330, 116);
            ComboBoxPrioridad.Margin = new Padding(4, 3, 4, 3);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(301, 33);
            ComboBoxPrioridad.TabIndex = 81;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(949, 1004);
            BotonVolver.Margin = new Padding(4, 5, 4, 5);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(269, 38);
            BotonVolver.TabIndex = 82;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.BorderStyle = BorderStyle.FixedSingle;
            OrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { NroOrdenPreparacionCol, IDClienteOrdenPreparacion, ClientePreparacionCol, EstadoOrdenPreparacionCol, PrioridadOrdenPreparacionCol, FechaOrdenPreparacion, IDProductoOrdenPreparacion });
            OrdenesPreparacionList.FullRowSelect = true;
            OrdenesPreparacionList.GridLines = true;
            OrdenesPreparacionList.Location = new Point(16, 225);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(538, 354);
            OrdenesPreparacionList.TabIndex = 83;
            OrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionList.View = View.Details;
            // 
            // NroOrdenPreparacionCol
            // 
            NroOrdenPreparacionCol.Text = "NroOrden";
            NroOrdenPreparacionCol.Width = 100;
            // 
            // IDClienteOrdenPreparacion
            // 
            IDClienteOrdenPreparacion.DisplayIndex = 5;
            IDClienteOrdenPreparacion.Text = "IDCliente";
            IDClienteOrdenPreparacion.Width = 100;
            // 
            // ClientePreparacionCol
            // 
            ClientePreparacionCol.DisplayIndex = 1;
            ClientePreparacionCol.Text = "Cliente";
            ClientePreparacionCol.Width = 100;
            // 
            // EstadoOrdenPreparacionCol
            // 
            EstadoOrdenPreparacionCol.DisplayIndex = 2;
            EstadoOrdenPreparacionCol.Text = "Estado";
            EstadoOrdenPreparacionCol.Width = 100;
            // 
            // PrioridadOrdenPreparacionCol
            // 
            PrioridadOrdenPreparacionCol.DisplayIndex = 3;
            PrioridadOrdenPreparacionCol.Text = "Prioridad";
            PrioridadOrdenPreparacionCol.Width = 100;
            // 
            // FechaOrdenPreparacion
            // 
            FechaOrdenPreparacion.DisplayIndex = 4;
            FechaOrdenPreparacion.Text = "Fecha";
            FechaOrdenPreparacion.Width = 120;
            // 
            // IDProductoOrdenPreparacion
            // 
            IDProductoOrdenPreparacion.Text = "Productos";
            IDProductoOrdenPreparacion.Width = 100;
            // 
            // OrdenesEntregaList
            // 
            OrdenesEntregaList.BorderStyle = BorderStyle.FixedSingle;
            OrdenesEntregaList.Columns.AddRange(new ColumnHeader[] { NroOrdenEntregaCol, IDClienteOrdenEntrega, ClienteEntregaCol, EstadoOrdenEntregaCol, PrioridadOrdenEntregaCol, FechaOrdenEntrega, IDProductoOrdenEntrega });
            OrdenesEntregaList.FullRowSelect = true;
            OrdenesEntregaList.GridLines = true;
            OrdenesEntregaList.Location = new Point(692, 225);
            OrdenesEntregaList.Name = "OrdenesEntregaList";
            OrdenesEntregaList.Size = new Size(537, 354);
            OrdenesEntregaList.TabIndex = 84;
            OrdenesEntregaList.UseCompatibleStateImageBehavior = false;
            OrdenesEntregaList.View = View.Details;
            // 
            // NroOrdenEntregaCol
            // 
            NroOrdenEntregaCol.Text = "NroOrden";
            NroOrdenEntregaCol.Width = 100;
            // 
            // IDClienteOrdenEntrega
            // 
            IDClienteOrdenEntrega.DisplayIndex = 5;
            IDClienteOrdenEntrega.Text = "IDCliente";
            IDClienteOrdenEntrega.Width = 100;
            // 
            // ClienteEntregaCol
            // 
            ClienteEntregaCol.DisplayIndex = 1;
            ClienteEntregaCol.Text = "Cliente";
            ClienteEntregaCol.Width = 100;
            // 
            // EstadoOrdenEntregaCol
            // 
            EstadoOrdenEntregaCol.DisplayIndex = 2;
            EstadoOrdenEntregaCol.Text = "Estado";
            EstadoOrdenEntregaCol.Width = 100;
            // 
            // PrioridadOrdenEntregaCol
            // 
            PrioridadOrdenEntregaCol.DisplayIndex = 3;
            PrioridadOrdenEntregaCol.Text = "Prioridad";
            PrioridadOrdenEntregaCol.Width = 100;
            // 
            // FechaOrdenEntrega
            // 
            FechaOrdenEntrega.DisplayIndex = 4;
            FechaOrdenEntrega.Text = "Fecha";
            FechaOrdenEntrega.Width = 120;
            // 
            // IDProductoOrdenEntrega
            // 
            IDProductoOrdenEntrega.Text = "Productos";
            IDProductoOrdenEntrega.Width = 100;
            // 
            // OrdenConfirmntregaadaList
            // 
            OrdenConfirmntregaadaList.BorderStyle = BorderStyle.FixedSingle;
            OrdenConfirmntregaadaList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            OrdenConfirmntregaadaList.FullRowSelect = true;
            OrdenConfirmntregaadaList.GridLines = true;
            OrdenConfirmntregaadaList.Location = new Point(17, 638);
            OrdenConfirmntregaadaList.Name = "OrdenConfirmntregaadaList";
            OrdenConfirmntregaadaList.Size = new Size(1212, 354);
            OrdenConfirmntregaadaList.TabIndex = 85;
            OrdenConfirmntregaadaList.UseCompatibleStateImageBehavior = false;
            OrdenConfirmntregaadaList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "NroOrden";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 5;
            columnHeader2.Text = "IDCliente";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 1;
            columnHeader3.Text = "Cliente";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex = 2;
            columnHeader4.Text = "Estado";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex = 3;
            columnHeader5.Text = "Prioridad";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 4;
            columnHeader6.Text = "Fecha";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Productos";
            columnHeader7.Width = 100;
            // 
            // CrearOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1241, 1050);
            Controls.Add(OrdenConfirmntregaadaList);
            Controls.Add(OrdenesEntregaList);
            Controls.Add(OrdenesPreparacionList);
            Controls.Add(BotonVolver);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(GenerarOrdenEntregaBoton);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonSacarDeOrdenEntrega);
            Controls.Add(BotonAOrdenEntrega);
            Controls.Add(ComboBoxEstado);
            Controls.Add(label2);
            Controls.Add(BotonCrear);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(LabelEstado);
            Controls.Add(TxtIdOrdenPreparacion);
            Controls.Add(LabelIDProducto);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CrearOrdenEntregaForm";
            Text = "CrearOrdenEntregaForm";
            Load += CrearOrdenEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCantidad;
        private Label label1;
        private Label label2;
        private Button BotonCrear;
        private TextBox TxtFecha;
        private Label LabelEspacioDisponible;
        private TextBox TxtIdProducto;
        private Label LabelPosicion;
        private TextBox TxtIdCliente;
        private Label LabelEstado;
        private TextBox TxtIdOrdenPreparacion;
        private Label LabelIDProducto;
        private ComboBox ComboBoxEstado;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button BotonAOrdenEntrega;
        private Button BotonSacarDeOrdenEntrega;
        private Label label4;
        private Button BotonLimpiar;
        private Button BotonBuscar;
        private Button GenerarOrdenEntregaBoton;
        private ComboBox ComboBoxPrioridad;
        private Button BotonVolver;
        private ListView OrdenesPreparacionList;
        private ColumnHeader NroOrdenPreparacionCol;
        private ColumnHeader ClientePreparacionCol;
        private ColumnHeader EstadoOrdenPreparacionCol;
        private ColumnHeader PrioridadOrdenPreparacionCol;
        private ListView OrdenesEntregaList;
        private ColumnHeader NroOrdenEntregaCol;
        private ColumnHeader ClienteEntregaCol;
        private ColumnHeader EstadoOrdenEntregaCol;
        private ColumnHeader PrioridadOrdenEntregaCol;
        private ColumnHeader FechaOrdenPreparacion;
        private ColumnHeader FechaOrdenEntrega;
        private ColumnHeader IDClienteOrdenPreparacion;
        private ColumnHeader IDProductoOrdenPreparacion;
        private ColumnHeader IDClienteOrdenEntrega;
        private ColumnHeader IDProductoOrdenEntrega;
        private ListView OrdenConfirmntregaadaList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}