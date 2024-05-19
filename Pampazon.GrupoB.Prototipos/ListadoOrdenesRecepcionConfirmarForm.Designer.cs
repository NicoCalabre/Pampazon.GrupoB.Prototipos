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
            BotonVolver.Location = new Point(474, 533);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 11;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ListViewListaOrdenesEntregaConfirmar
            // 
            ListViewListaOrdenesEntregaConfirmar.BorderStyle = BorderStyle.FixedSingle;
            ListViewListaOrdenesEntregaConfirmar.Columns.AddRange(new ColumnHeader[] { IDClienteColumn, DescripcionClienteColumn, IDProductoColumn, DescripcionProductoColumn, CantidadColumn, FechaColumn, EstadoColumn, PrioridadColumn });
            ListViewListaOrdenesEntregaConfirmar.FullRowSelect = true;
            ListViewListaOrdenesEntregaConfirmar.GridLines = true;
            ListViewListaOrdenesEntregaConfirmar.Location = new Point(15, 73);
            ListViewListaOrdenesEntregaConfirmar.Margin = new Padding(3, 4, 3, 4);
            ListViewListaOrdenesEntregaConfirmar.MultiSelect = false;
            ListViewListaOrdenesEntregaConfirmar.Name = "ListViewListaOrdenesEntregaConfirmar";
            ListViewListaOrdenesEntregaConfirmar.Size = new Size(887, 386);
            ListViewListaOrdenesEntregaConfirmar.TabIndex = 10;
            ListViewListaOrdenesEntregaConfirmar.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesEntregaConfirmar.View = View.Details;
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
            BotonActualizar.Location = new Point(253, 533);
            BotonActualizar.Margin = new Padding(3, 4, 3, 4);
            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Size = new Size(215, 31);
            BotonActualizar.TabIndex = 12;
            BotonActualizar.Text = "Actualizar";
            BotonActualizar.UseVisualStyleBackColor = true;
            BotonActualizar.Click += BotonActualizar_Click;
            // 
            // ListadoOrdenesRecepcionConfirmarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonActualizar);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesEntregaConfirmar);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}