namespace Pampazon.GrupoB.Prototipos
{
    partial class ListadoOrdenesRecepcionForm
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
            ListViewListaOrdenesRecepcion = new ListView();
            IDClienteColumn = new ColumnHeader();
            DescripcionClienteColumn = new ColumnHeader();
            IDProductoColumn = new ColumnHeader();
            DescripcionProductoColumn = new ColumnHeader();
            CantidadColumn = new ColumnHeader();
            FechaColumn = new ColumnHeader();
            EstadoColumn = new ColumnHeader();
            PrioridadColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(686, 553);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 9;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ListViewListaOrdenesRecepcion
            // 
            ListViewListaOrdenesRecepcion.BorderStyle = BorderStyle.FixedSingle;
            ListViewListaOrdenesRecepcion.Columns.AddRange(new ColumnHeader[] { IDClienteColumn, DescripcionClienteColumn, IDProductoColumn, DescripcionProductoColumn, CantidadColumn, FechaColumn, EstadoColumn, PrioridadColumn });
            ListViewListaOrdenesRecepcion.FullRowSelect = true;
            ListViewListaOrdenesRecepcion.GridLines = true;
            ListViewListaOrdenesRecepcion.Location = new Point(12, 72);
            ListViewListaOrdenesRecepcion.Margin = new Padding(3, 4, 3, 4);
            ListViewListaOrdenesRecepcion.MultiSelect = false;
            ListViewListaOrdenesRecepcion.Name = "ListViewListaOrdenesRecepcion";
            ListViewListaOrdenesRecepcion.Size = new Size(887, 386);
            ListViewListaOrdenesRecepcion.TabIndex = 8;
            ListViewListaOrdenesRecepcion.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesRecepcion.View = View.Details;
            ListViewListaOrdenesRecepcion.SelectedIndexChanged += ListViewListadoProductos_SelectedIndexChanged;
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
            // ListadoOrdenesRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesRecepcion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListadoOrdenesRecepcionForm";
            Text = "ListadoOrdenesRecepcionForm";
            Load += ListadoOrdenesRecepcionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonVolver;
        private ListView ListViewListaOrdenesRecepcion;
        private ColumnHeader IDClienteColumn;
        private ColumnHeader DescripcionClienteColumn;
        private ColumnHeader IDProductoColumn;
        private ColumnHeader DescripcionProductoColumn;
        private ColumnHeader CantidadColumn;
        private ColumnHeader FechaColumn;
        private ColumnHeader EstadoColumn;
        private ColumnHeader PrioridadColumn;
    }
}