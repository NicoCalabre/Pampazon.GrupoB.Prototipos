namespace Pampazon.GrupoB.Prototipos
{
    partial class ListadoOrdenesSeleccionForm
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
            ListViewListaOrdenSeleccion = new ListView();
            IDClienteColumn = new ColumnHeader();
            DescripcionClienteColumn = new ColumnHeader();
            FechaColumn = new ColumnHeader();
            EstadoColumn = new ColumnHeader();
            PrioridadColumn = new ColumnHeader();
            IdOrdenSeleccionColumn = new ColumnHeader();
            IdOrdenPreparacionColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(548, 401);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 11;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // ListViewListaOrdenSeleccion
            // 
            ListViewListaOrdenSeleccion.BorderStyle = BorderStyle.FixedSingle;
            ListViewListaOrdenSeleccion.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumn, IDClienteColumn, DescripcionClienteColumn, IdOrdenPreparacionColumn, FechaColumn, EstadoColumn, PrioridadColumn });
            ListViewListaOrdenSeleccion.FullRowSelect = true;
            ListViewListaOrdenSeleccion.GridLines = true;
            ListViewListaOrdenSeleccion.Location = new Point(12, 58);
            ListViewListaOrdenSeleccion.MultiSelect = false;
            ListViewListaOrdenSeleccion.Name = "ListViewListaOrdenSeleccion";
            ListViewListaOrdenSeleccion.Size = new Size(724, 290);
            ListViewListaOrdenSeleccion.TabIndex = 10;
            ListViewListaOrdenSeleccion.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenSeleccion.View = View.Details;
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
            // IdOrdenSeleccionColumn
            // 
            IdOrdenSeleccionColumn.Text = "ID Orden Selección";
            IdOrdenSeleccionColumn.Width = 130;
            // 
            // IdOrdenPreparacionColumn
            // 
            IdOrdenPreparacionColumn.DisplayIndex = 4;
            IdOrdenPreparacionColumn.Text = "ID Orden Preparación";
            IdOrdenPreparacionColumn.Width = 130;
            // 
            // ListadoOrdenesSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(755, 436);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenSeleccion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoOrdenesSeleccionForm";
            Text = "ListadoOrdenesSeleccionForm";
            Load += ListadoOrdenesSeleccionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonVolver;
        private ListView ListViewListaOrdenSeleccion;
        private ColumnHeader IDClienteColumn;
        private ColumnHeader DescripcionClienteColumn;
        private ColumnHeader FechaColumn;
        private ColumnHeader EstadoColumn;
        private ColumnHeader PrioridadColumn;
        private ColumnHeader IdOrdenSeleccionColumn;
        private ColumnHeader IdOrdenPreparacionColumn;
    }
}