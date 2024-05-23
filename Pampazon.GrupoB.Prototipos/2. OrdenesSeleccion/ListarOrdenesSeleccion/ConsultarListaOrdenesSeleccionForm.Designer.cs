namespace Pampazon.GrupoB.Prototipos
{
    partial class ConsultarListaOrdenesSeleccionForm
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
            TxtFecha = new TextBox();
            label1 = new Label();
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            BotonVolver = new Button();
            TxtPrioridad = new TextBox();
            LabelEspacioDisponible = new Label();
            TxtIDCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIdOrdenSeleccion = new TextBox();
            LabelIdOrdenSeleccion = new Label();
            ListViewListaOrdenesSeleccion = new ListView();
            IdOrdenSeleccionColumn = new ColumnHeader();
            IDClienteColumn = new ColumnHeader();
            DescripcionClienteColumn = new ColumnHeader();
            IdOrdenPreparacionColumn = new ColumnHeader();
            FechaColumn = new ColumnHeader();
            EstadoColumn = new ColumnHeader();
            PrioridadColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(5, 88);
            TxtFecha.Margin = new Padding(3, 4, 3, 4);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(214, 27);
            TxtFecha.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 64);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 43;
            label1.Text = "Fecha";
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(749, 33);
            BotonLimpiar.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(215, 31);
            BotonLimpiar.TabIndex = 42;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(509, 33);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(215, 31);
            BotonBuscar.TabIndex = 41;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(749, 584);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 40;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtPrioridad
            // 
            TxtPrioridad.Location = new Point(231, 88);
            TxtPrioridad.Margin = new Padding(3, 4, 3, 4);
            TxtPrioridad.Name = "TxtPrioridad";
            TxtPrioridad.Size = new Size(214, 27);
            TxtPrioridad.TabIndex = 39;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(231, 64);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(70, 20);
            LabelEspacioDisponible.TabIndex = 38;
            LabelEspacioDisponible.Text = "Prioridad";
            // 
            // TxtIDCliente
            // 
            TxtIDCliente.Location = new Point(231, 33);
            TxtIDCliente.Margin = new Padding(3, 4, 3, 4);
            TxtIDCliente.Name = "TxtIDCliente";
            TxtIDCliente.Size = new Size(214, 27);
            TxtIDCliente.TabIndex = 37;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(231, 9);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(74, 20);
            LabelDescripcionProducto.TabIndex = 36;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenSeleccion
            // 
            TxtIdOrdenSeleccion.Location = new Point(5, 33);
            TxtIdOrdenSeleccion.Margin = new Padding(3, 4, 3, 4);
            TxtIdOrdenSeleccion.Name = "TxtIdOrdenSeleccion";
            TxtIdOrdenSeleccion.Size = new Size(214, 27);
            TxtIdOrdenSeleccion.TabIndex = 35;
            // 
            // LabelIdOrdenSeleccion
            // 
            LabelIdOrdenSeleccion.AutoSize = true;
            LabelIdOrdenSeleccion.Location = new Point(5, 9);
            LabelIdOrdenSeleccion.Name = "LabelIdOrdenSeleccion";
            LabelIdOrdenSeleccion.Size = new Size(136, 20);
            LabelIdOrdenSeleccion.TabIndex = 34;
            LabelIdOrdenSeleccion.Text = "ID Orden Selección";
            // 
            // ListViewListaOrdenesSeleccion
            // 
            ListViewListaOrdenesSeleccion.BorderStyle = BorderStyle.FixedSingle;
            ListViewListaOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumn, IDClienteColumn, DescripcionClienteColumn, IdOrdenPreparacionColumn, FechaColumn, EstadoColumn, PrioridadColumn });
            ListViewListaOrdenesSeleccion.FullRowSelect = true;
            ListViewListaOrdenesSeleccion.GridLines = true;
            ListViewListaOrdenesSeleccion.Location = new Point(5, 174);
            ListViewListaOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            ListViewListaOrdenesSeleccion.MultiSelect = false;
            ListViewListaOrdenesSeleccion.Name = "ListViewListaOrdenesSeleccion";
            ListViewListaOrdenesSeleccion.Size = new Size(959, 386);
            ListViewListaOrdenesSeleccion.TabIndex = 45;
            ListViewListaOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesSeleccion.View = View.Details;
            // 
            // IdOrdenSeleccionColumn
            // 
            IdOrdenSeleccionColumn.Text = "ID Orden Selección";
            IdOrdenSeleccionColumn.Width = 130;
            // 
            // IDClienteColumn
            // 
            IDClienteColumn.Text = "ID Cliente";
            IDClienteColumn.Width = 70;
            // 
            // DescripcionClienteColumn
            // 
            DescripcionClienteColumn.Text = "Descripción Cliente";
            DescripcionClienteColumn.Width = 120;
            // 
            // IdOrdenPreparacionColumn
            // 
            IdOrdenPreparacionColumn.DisplayIndex = 4;
            IdOrdenPreparacionColumn.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumn.Width = 130;
            // 
            // FechaColumn
            // 
            FechaColumn.DisplayIndex = 3;
            FechaColumn.Text = "Fecha";
            FechaColumn.Width = 100;
            // 
            // EstadoColumn
            // 
            EstadoColumn.Text = "Estado";
            EstadoColumn.Width = 80;
            // 
            // PrioridadColumn
            // 
            PrioridadColumn.Text = "Prioridad";
            PrioridadColumn.Width = 80;
            // 
            // ConsultarListaOrdenesSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 639);
            Controls.Add(ListViewListaOrdenesSeleccion);
            Controls.Add(TxtFecha);
            Controls.Add(label1);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(TxtPrioridad);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIDCliente);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIdOrdenSeleccion);
            Controls.Add(LabelIdOrdenSeleccion);
            Name = "ConsultarListaOrdenesSeleccionForm";
            Text = "ConsultarListaOrdenesSeleccionForm";
            Load += ConsultarListaOrdenesSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtFecha;
        private Label label1;
        private Button BotonLimpiar;
        private Button BotonBuscar;
        private Button BotonVolver;
        private TextBox TxtPrioridad;
        private Label LabelEspacioDisponible;
        private TextBox TxtIDCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIdOrdenSeleccion;
        private Label LabelIdOrdenSeleccion;
        private ListView ListViewListaOrdenesSeleccion;
        private ColumnHeader IdOrdenSeleccionColumn;
        private ColumnHeader IDClienteColumn;
        private ColumnHeader DescripcionClienteColumn;
        private ColumnHeader IdOrdenPreparacionColumn;
        private ColumnHeader FechaColumn;
        private ColumnHeader EstadoColumn;
        private ColumnHeader PrioridadColumn;
    }
}