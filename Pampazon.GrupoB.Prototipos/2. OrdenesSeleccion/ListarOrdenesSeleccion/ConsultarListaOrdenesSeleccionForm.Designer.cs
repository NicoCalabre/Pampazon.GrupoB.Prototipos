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
            label1 = new Label();
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            BotonVolver = new Button();
            LabelIdOrdenSeleccion = new Label();
            ListViewListaOrdenesSeleccion = new ListView();
            IdOrdenSeleccionColumn = new ColumnHeader();
            FechaOrdenSeleccionCol = new ColumnHeader();
            IDProductoCol = new ColumnHeader();
            CantidadCol = new ColumnHeader();
            ComboBoxIDOrdenSeleccion = new ComboBox();
            ComboBoxFecha = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 43;
            label1.Text = "Fecha";
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(749, 27);
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
            BotonBuscar.Location = new Point(509, 27);
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
            ListViewListaOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { IdOrdenSeleccionColumn, FechaOrdenSeleccionCol, IDProductoCol, CantidadCol });
            ListViewListaOrdenesSeleccion.FullRowSelect = true;
            ListViewListaOrdenesSeleccion.GridLines = true;
            ListViewListaOrdenesSeleccion.Location = new Point(5, 79);
            ListViewListaOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            ListViewListaOrdenesSeleccion.MultiSelect = false;
            ListViewListaOrdenesSeleccion.Name = "ListViewListaOrdenesSeleccion";
            ListViewListaOrdenesSeleccion.Size = new Size(959, 480);
            ListViewListaOrdenesSeleccion.TabIndex = 45;
            ListViewListaOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesSeleccion.View = View.Details;
            // 
            // IdOrdenSeleccionColumn
            // 
            IdOrdenSeleccionColumn.Text = "ID Orden Selección";
            IdOrdenSeleccionColumn.Width = 150;
            // 
            // FechaOrdenSeleccionCol
            // 
            FechaOrdenSeleccionCol.Text = "Fecha Orden Selección";
            FechaOrdenSeleccionCol.Width = 150;
            // 
            // IDProductoCol
            // 
            IDProductoCol.Text = "ID Producto";
            IDProductoCol.Width = 150;
            // 
            // CantidadCol
            // 
            CantidadCol.Text = "Cantidad";
            CantidadCol.Width = 150;
            // 
            // ComboBoxIDOrdenSeleccion
            // 
            ComboBoxIDOrdenSeleccion.AllowDrop = true;
            ComboBoxIDOrdenSeleccion.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxIDOrdenSeleccion.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxIDOrdenSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDOrdenSeleccion.FormattingEnabled = true;
            ComboBoxIDOrdenSeleccion.Location = new Point(5, 29);
            ComboBoxIDOrdenSeleccion.Margin = new Padding(3, 4, 3, 4);
            ComboBoxIDOrdenSeleccion.Name = "ComboBoxIDOrdenSeleccion";
            ComboBoxIDOrdenSeleccion.Size = new Size(214, 28);
            ComboBoxIDOrdenSeleccion.Sorted = true;
            ComboBoxIDOrdenSeleccion.TabIndex = 47;
            // 
            // ComboBoxFecha
            // 
            ComboBoxFecha.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboBoxFecha.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBoxFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFecha.FormattingEnabled = true;
            ComboBoxFecha.Location = new Point(231, 29);
            ComboBoxFecha.Margin = new Padding(3, 4, 3, 4);
            ComboBoxFecha.Name = "ComboBoxFecha";
            ComboBoxFecha.Size = new Size(214, 28);
            ComboBoxFecha.Sorted = true;
            ComboBoxFecha.TabIndex = 49;
            // 
            // ConsultarListaOrdenesSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 639);
            Controls.Add(ComboBoxFecha);
            Controls.Add(ComboBoxIDOrdenSeleccion);
            Controls.Add(ListViewListaOrdenesSeleccion);
            Controls.Add(label1);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(LabelIdOrdenSeleccion);
            Name = "ConsultarListaOrdenesSeleccionForm";
            Text = "ConsultarListaOrdenesSeleccionForm";
            Load += ConsultarListaOrdenesSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button BotonLimpiar;
        private Button BotonBuscar;
        private Button BotonVolver;
        private Label LabelIdOrdenSeleccion;
        private ListView ListViewListaOrdenesSeleccion;
        private ColumnHeader IdOrdenSeleccionColumn;
        private ColumnHeader FechaOrdenSeleccionCol;
        private ColumnHeader IDProductoCol;
        private ColumnHeader CantidadCol;
        private ComboBox ComboBoxIDOrdenSeleccion;
        private ComboBox ComboBoxFecha;
    }
}