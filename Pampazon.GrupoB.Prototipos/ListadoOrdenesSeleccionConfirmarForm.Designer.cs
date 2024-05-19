namespace Pampazon.GrupoB.Prototipos
{
    partial class ListadoOrdenesSeleccionConfirmarForm
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
            ListViewListaOrdenesSeleccionConfirmar = new ListView();
            IDClienteColumn = new ColumnHeader();
            DescripcionClienteColumn = new ColumnHeader();
            IDProductoColumn = new ColumnHeader();
            DescripcionProductoColumn = new ColumnHeader();
            CantidadColumn = new ColumnHeader();
            FechaColumn = new ColumnHeader();
            EstadoColumn = new ColumnHeader();
            PrioridadColumn = new ColumnHeader();
            IdOrdenSeleccionColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // BotonActualizar
            // 
            BotonActualizar.Location = new Point(224, 356);
            BotonActualizar.Name = "BotonActualizar";
            BotonActualizar.Size = new Size(188, 23);
            BotonActualizar.TabIndex = 15;
            BotonActualizar.Text = "Actualizar";
            BotonActualizar.UseVisualStyleBackColor = true;
            BotonActualizar.Click += BotonActualizar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(417, 356);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 14;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ListViewListaOrdenesSeleccionConfirmar
            // 
            ListViewListaOrdenesSeleccionConfirmar.BorderStyle = BorderStyle.FixedSingle;
            ListViewListaOrdenesSeleccionConfirmar.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumn, IDClienteColumn, DescripcionClienteColumn, IDProductoColumn, DescripcionProductoColumn, CantidadColumn, FechaColumn, EstadoColumn, PrioridadColumn });
            ListViewListaOrdenesSeleccionConfirmar.FullRowSelect = true;
            ListViewListaOrdenesSeleccionConfirmar.GridLines = true;
            ListViewListaOrdenesSeleccionConfirmar.Location = new Point(10, 49);
            ListViewListaOrdenesSeleccionConfirmar.MultiSelect = false;
            ListViewListaOrdenesSeleccionConfirmar.Name = "ListViewListaOrdenesSeleccionConfirmar";
            ListViewListaOrdenesSeleccionConfirmar.Size = new Size(857, 290);
            ListViewListaOrdenesSeleccionConfirmar.TabIndex = 13;
            ListViewListaOrdenesSeleccionConfirmar.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesSeleccionConfirmar.View = View.Details;
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
            // IdOrdenSeleccionColumn
            // 
            IdOrdenSeleccionColumn.Text = "ID Orden Selección";
            IdOrdenSeleccionColumn.Width = 130;
            // 
            // ListadoOrdenesSeleccionConfirmarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 395);
            Controls.Add(BotonActualizar);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesSeleccionConfirmar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoOrdenesSeleccionConfirmarForm";
            Text = "ListadoOrdenesSeleccionConfirmarForm";
            Load += ListadoOrdenesSeleccionConfirmarForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonActualizar;
        private Button BotonVolver;
        private ListView ListViewListaOrdenesSeleccionConfirmar;
        private ColumnHeader IDClienteColumn;
        private ColumnHeader DescripcionClienteColumn;
        private ColumnHeader IDProductoColumn;
        private ColumnHeader DescripcionProductoColumn;
        private ColumnHeader CantidadColumn;
        private ColumnHeader FechaColumn;
        private ColumnHeader EstadoColumn;
        private ColumnHeader PrioridadColumn;
        private ColumnHeader IdOrdenSeleccionColumn;
    }
}