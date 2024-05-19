namespace Pampazon.GrupoB.Prototipos
{
    partial class ListadoOrdenesEntregaForm
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
            BotonActualizar = new Button();
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
            SuspendLayout();
            // 
            // BotonActualizar
            // 
            BotonActualizar.Location = new Point(212, 429);
            BotonActualizar.Margin = new Padding(3, 4, 3, 4);
            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Size = new Size(215, 31);
            BotonActualizar.TabIndex = 15;
            BotonActualizar.Text = "Actualizar";
            BotonActualizar.UseVisualStyleBackColor = true;
            BotonActualizar.Click += BotonActualizar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(433, 429);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 14;
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
            ListViewListaOrdenesEntregaConfirmar.Location = new Point(12, 13);
            ListViewListaOrdenesEntregaConfirmar.Margin = new Padding(3, 4, 3, 4);
            ListViewListaOrdenesEntregaConfirmar.MultiSelect = false;
            ListViewListaOrdenesEntregaConfirmar.Name = "ListViewListaOrdenesEntregaConfirmar";
            ListViewListaOrdenesEntregaConfirmar.Size = new Size(870, 388);
            ListViewListaOrdenesEntregaConfirmar.TabIndex = 13;
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
            // ListadoOrdenesEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 487);
            Controls.Add(BotonActualizar);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesEntregaConfirmar);
            Name = "ListadoOrdenesEntregaForm";
            Text = "ListadoOrdenesEntregaForm";
            Load += ListadoOrdenesEntregaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonActualizar;
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
    }
}