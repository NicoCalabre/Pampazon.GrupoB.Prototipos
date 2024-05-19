namespace Pampazon.GrupoB.Prototipos
{
    partial class ListadoOrdenesRecepcionConfirmarForm
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
            ListViewListaOrdenesEntregaConfirmar = new ListView();
            IdOrdenRecepcionColumn = new ColumnHeader();
            IDClienteColumn = new ColumnHeader();
            DescripcionClienteColumn = new ColumnHeader();
            IDProductoColumn = new ColumnHeader();
            DescripcionProductoColumn = new ColumnHeader();
            CantidadColumn = new ColumnHeader();
            FechaColumn = new ColumnHeader();
            EstadoColumn = new ColumnHeader();
            PrioridadColumn = new ColumnHeader();
            BotonActualizar = new Button();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(415, 400);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 11;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ListViewListaOrdenesEntregaConfirmar
            // 
            ListViewListaOrdenesEntregaConfirmar.BorderStyle = BorderStyle.FixedSingle;
            ListViewListaOrdenesEntregaConfirmar.Columns.AddRange(new ColumnHeader[] { IdOrdenRecepcionColumn, IDClienteColumn, DescripcionClienteColumn, IDProductoColumn, DescripcionProductoColumn, CantidadColumn, FechaColumn, EstadoColumn, PrioridadColumn });
            ListViewListaOrdenesEntregaConfirmar.FullRowSelect = true;
            ListViewListaOrdenesEntregaConfirmar.GridLines = true;
            ListViewListaOrdenesEntregaConfirmar.Location = new Point(13, 55);
            ListViewListaOrdenesEntregaConfirmar.MultiSelect = false;
            ListViewListaOrdenesEntregaConfirmar.Name = "ListViewListaOrdenesEntregaConfirmar";
            ListViewListaOrdenesEntregaConfirmar.Size = new Size(851, 290);
            ListViewListaOrdenesEntregaConfirmar.TabIndex = 10;
            ListViewListaOrdenesEntregaConfirmar.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesEntregaConfirmar.View = View.Details;
            // 
            // IdOrdenRecepcionColumn
            // 
            IdOrdenRecepcionColumn.Text = "ID Orden Recepción";
            IdOrdenRecepcionColumn.Width = 120;
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
            // BotonActualizar
            // 
            BotonActualizar.Location = new Point(221, 400);
            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Size = new Size(188, 23);
            BotonActualizar.TabIndex = 12;
            BotonActualizar.Text = "Actualizar";
            BotonActualizar.UseVisualStyleBackColor = true;
            BotonActualizar.Click += BotonActualizar_Click;
            // 
            // ListadoOrdenesRecepcionConfirmarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(875, 450);
            Controls.Add(BotonActualizar);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesEntregaConfirmar);
            Name = "ListadoOrdenesRecepcionConfirmarForm";
            Text = "ListadoOrdenesRecepcionConfirmarForm";
            Load += ListadoOrdenesRecepcionConfirmarForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonVolver;
        private ListView ListViewListaOrdenesEntregaConfirmar;
        private ColumnHeader IDClienteColumn;
        private ColumnHeader DescripcionClienteColumn;
        private ColumnHeader IDProductoColumn;
        private ColumnHeader DescripcionProductoColumn;
        private ColumnHeader CantidadColumn;
        private ColumnHeader FechaColumn;
        private ColumnHeader EstadoColumn;
        private ColumnHeader PrioridadColumn;
        private Button BotonActualizar;
        private ColumnHeader IdOrdenRecepcionColumn;
    }
}