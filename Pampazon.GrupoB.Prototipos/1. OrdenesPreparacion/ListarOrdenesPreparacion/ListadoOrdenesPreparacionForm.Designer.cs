﻿namespace Pampazon.GrupoB.Prototipos
{
    partial class ListadoOrdenesPreparacionForm
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
            BotonVolver = new Button();
            ListViewListaOrdenesPreparacion = new ListView();
            IdOrdenPreparacionColumn = new ColumnHeader();
            IDClienteColumn = new ColumnHeader();
            DescripcionClienteColumn = new ColumnHeader();
            IDProductoColumn = new ColumnHeader();
            DescripcionProductoColumn = new ColumnHeader();
            CantidadColumn = new ColumnHeader();
            FechaColumn = new ColumnHeader();
            EstadoColumn = new ColumnHeader();
            PrioridadColumn = new ColumnHeader();
            ComboBoxEstado = new ComboBox();
            ComboEstado = new Label();
            TxtFecha = new TextBox();
            label1 = new Label();
            LabelEspacioDisponible = new Label();
            TxtIDCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIdOrdenPreparacion = new TextBox();
            LabelIdOrdenPreparacion = new Label();
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            ComboBoxPrioridad = new ComboBox();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 487);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 11;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ListViewListaOrdenesPreparacion
            // 
            ListViewListaOrdenesPreparacion.BorderStyle = BorderStyle.FixedSingle;
            ListViewListaOrdenesPreparacion.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionColumn, IDClienteColumn, DescripcionClienteColumn, IDProductoColumn, DescripcionProductoColumn, CantidadColumn, FechaColumn, EstadoColumn, PrioridadColumn });
            ListViewListaOrdenesPreparacion.FullRowSelect = true;
            ListViewListaOrdenesPreparacion.GridLines = true;
            ListViewListaOrdenesPreparacion.Location = new Point(12, 164);
            ListViewListaOrdenesPreparacion.MultiSelect = false;
            ListViewListaOrdenesPreparacion.Name = "ListViewListaOrdenesPreparacion";
            ListViewListaOrdenesPreparacion.Size = new Size(845, 290);
            ListViewListaOrdenesPreparacion.TabIndex = 10;
            ListViewListaOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesPreparacion.View = View.Details;
            // 
            // IdOrdenPreparacionColumn
            // 
            IdOrdenPreparacionColumn.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumn.Width = 130;
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
            // IDProductoColumn
            // 
            IDProductoColumn.Text = "ID Producto";
            IDProductoColumn.Width = 80;
            // 
            // DescripcionProductoColumn
            // 
            DescripcionProductoColumn.Text = "Descripción Producto";
            DescripcionProductoColumn.Width = 120;
            // 
            // CantidadColumn
            // 
            CantidadColumn.Text = "Cantidad";
            // 
            // FechaColumn
            // 
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
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(16, 79);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(212, 23);
            ComboBoxEstado.TabIndex = 56;
            // 
            // ComboEstado
            // 
            ComboEstado.AutoSize = true;
            ComboEstado.Location = new Point(16, 61);
            ComboEstado.Name = "ComboEstado";
            ComboEstado.Size = new Size(42, 15);
            ComboEstado.TabIndex = 55;
            ComboEstado.Text = "Estado";
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(452, 33);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(212, 23);
            TxtFecha.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(452, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 53;
            label1.Text = "Fecha";
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(669, 15);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(55, 15);
            LabelEspacioDisponible.TabIndex = 51;
            LabelEspacioDisponible.Text = "Prioridad";
            // 
            // TxtIDCliente
            // 
            TxtIDCliente.Location = new Point(234, 33);
            TxtIDCliente.Name = "TxtIDCliente";
            TxtIDCliente.Size = new Size(212, 23);
            TxtIDCliente.TabIndex = 50;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(234, 15);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 49;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenPreparacion
            // 
            TxtIdOrdenPreparacion.Location = new Point(16, 33);
            TxtIdOrdenPreparacion.Name = "TxtIdOrdenPreparacion";
            TxtIdOrdenPreparacion.Size = new Size(212, 23);
            TxtIdOrdenPreparacion.TabIndex = 48;
            // 
            // LabelIdOrdenPreparacion
            // 
            LabelIdOrdenPreparacion.AutoSize = true;
            LabelIdOrdenPreparacion.Location = new Point(16, 15);
            LabelIdOrdenPreparacion.Name = "LabelIdOrdenPreparacion";
            LabelIdOrdenPreparacion.Size = new Size(131, 15);
            LabelIdOrdenPreparacion.TabIndex = 47;
            LabelIdOrdenPreparacion.Text = "ID Órdenes Preparacion";
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(670, 125);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 58;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(476, 125);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(188, 23);
            BotonBuscar.TabIndex = 57;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(670, 33);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(212, 23);
            ComboBoxPrioridad.TabIndex = 59;
            // 
            // ListadoOrdenesPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(886, 522);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(ComboBoxEstado);
            Controls.Add(ComboEstado);
            Controls.Add(TxtFecha);
            Controls.Add(label1);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIDCliente);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIdOrdenPreparacion);
            Controls.Add(LabelIdOrdenPreparacion);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesPreparacion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoOrdenesPreparacionForm";
            Text = "ListadoOrdenesPreparacionForm";
            Load += ListadoOrdenesPreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private ListView ListViewListaOrdenesPreparacion;
        private ColumnHeader IDClienteColumn;
        private ColumnHeader DescripcionClienteColumn;
        private ColumnHeader IDProductoColumn;
        private ColumnHeader DescripcionProductoColumn;
        private ColumnHeader CantidadColumn;
        private ColumnHeader FechaColumn;
        private ColumnHeader EstadoColumn;
        private ColumnHeader PrioridadColumn;
        private ColumnHeader IdOrdenPreparacionColumn;
        private ComboBox ComboBoxEstado;
        private Label ComboEstado;
        private TextBox TxtFecha;
        private Label label1;
        private Label LabelEspacioDisponible;
        private TextBox TxtIDCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIdOrdenPreparacion;
        private Label LabelIdOrdenPreparacion;
        private Button BotonLimpiar;
        private Button BotonBuscar;
        private ComboBox ComboBoxPrioridad;
    }
}