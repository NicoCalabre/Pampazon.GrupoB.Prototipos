namespace Pampazon.GrupoB.Prototipos
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
            IDClienteColumn = new ColumnHeader();
            DescripcionClienteColumn = new ColumnHeader();
            IDProductoColumn = new ColumnHeader();
            DescripcionProductoColumn = new ColumnHeader();
            CantidadColumn = new ColumnHeader();
            FechaColumn = new ColumnHeader();
            EstadoColumn = new ColumnHeader();
            PrioridadColumn = new ColumnHeader();
            IdOrdenPreparacionColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(619, 413);
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
            ListViewListaOrdenesPreparacion.Location = new Point(20, 57);
            ListViewListaOrdenesPreparacion.MultiSelect = false;
            ListViewListaOrdenesPreparacion.Name = "ListViewListaOrdenesPreparacion";
            ListViewListaOrdenesPreparacion.Size = new Size(845, 290);
            ListViewListaOrdenesPreparacion.TabIndex = 10;
            ListViewListaOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesPreparacion.View = View.Details;
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
            // IdOrdenPreparacionColumn
            // 
            IdOrdenPreparacionColumn.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumn.Width = 130;
            // 
            // ListadoOrdenesPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(886, 446);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesPreparacion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoOrdenesPreparacionForm";
            Text = "ListadoOrdenesPreparacionForm";
            Load += ListadoOrdenesPreparacionForm_Load;
            ResumeLayout(false);
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
    }
}