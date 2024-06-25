namespace Pampazon.GrupoB.Prototipos
{
    partial class CrearOrdenEntregaForm
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
            label2 = new Label();
            BotonCrear = new Button();
            LabelEspacioDisponible = new Label();
            LabelIDProducto = new Label();
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            AgregarOrdenEntregaBoton = new Button();
            ComboBoxPrioridad = new ComboBox();
            BotonVolver = new Button();
            OrdenesPreparacionList = new ListView();
            NroOrdenPreparacionCol = new ColumnHeader();
            IDClienteOrdenPreparacion = new ColumnHeader();
            ClientePreparacionCol = new ColumnHeader();
            EstadoOrdenPreparacionCol = new ColumnHeader();
            PrioridadOrdenPreparacionCol = new ColumnHeader();
            FechaOrdenPreparacion = new ColumnHeader();
            OrdenesEntregaList = new ListView();
            NroOrdenEntregaCol = new ColumnHeader();
            IDProductoOrdenEntrega = new ColumnHeader();
            DescripcionProductoOrdenEntrega = new ColumnHeader();
            CantidadOrdenEntrega = new ColumnHeader();
            OrdenConfirmntregaadaList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            IDOrdenPreparacionComboBox = new ComboBox();
            FechaOrdenPreparacionComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 53);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 67;
            label2.Text = "Prioridad";
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(127, 633);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(188, 23);
            BotonCrear.TabIndex = 65;
            BotonCrear.Text = "&Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(11, 53);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(38, 15);
            LabelEspacioDisponible.TabIndex = 62;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(12, 9);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(120, 15);
            LabelIDProducto.TabIndex = 56;
            LabelIDProducto.Text = "ID Orden Preparacion";
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(643, 27);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 79;
            BotonLimpiar.Text = "Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click_1;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(449, 27);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(188, 23);
            BotonBuscar.TabIndex = 78;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // AgregarOrdenEntregaBoton
            // 
            AgregarOrdenEntregaBoton.Location = new Point(484, 256);
            AgregarOrdenEntregaBoton.Name = "AgregarOrdenEntregaBoton";
            AgregarOrdenEntregaBoton.Size = new Size(375, 23);
            AgregarOrdenEntregaBoton.TabIndex = 80;
            AgregarOrdenEntregaBoton.Text = "Agregar orden empaquetada";
            AgregarOrdenEntregaBoton.UseVisualStyleBackColor = true;
            AgregarOrdenEntregaBoton.Click += AgregarOrdenEntregaBoton_Click;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(231, 70);
            ComboBoxPrioridad.Margin = new Padding(3, 2, 3, 2);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(212, 23);
            ComboBoxPrioridad.TabIndex = 81;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(664, 556);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 82;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click_1;
            // 
            // OrdenesPreparacionList
            // 
            OrdenesPreparacionList.BorderStyle = BorderStyle.FixedSingle;
            OrdenesPreparacionList.Columns.AddRange(new ColumnHeader[] { NroOrdenPreparacionCol, IDClienteOrdenPreparacion, ClientePreparacionCol, EstadoOrdenPreparacionCol, PrioridadOrdenPreparacionCol, FechaOrdenPreparacion });
            OrdenesPreparacionList.FullRowSelect = true;
            OrdenesPreparacionList.GridLines = true;
            OrdenesPreparacionList.Location = new Point(11, 110);
            OrdenesPreparacionList.Margin = new Padding(2);
            OrdenesPreparacionList.Name = "OrdenesPreparacionList";
            OrdenesPreparacionList.Size = new Size(377, 213);
            OrdenesPreparacionList.TabIndex = 83;
            OrdenesPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacionList.View = View.Details;
            // 
            // NroOrdenPreparacionCol
            // 
            NroOrdenPreparacionCol.Text = "IDOrdenPreparacion";
            NroOrdenPreparacionCol.Width = 100;
            // 
            // IDClienteOrdenPreparacion
            // 
            IDClienteOrdenPreparacion.Text = "IDCliente";
            IDClienteOrdenPreparacion.Width = 100;
            // 
            // ClientePreparacionCol
            // 
            ClientePreparacionCol.Text = "Cliente";
            ClientePreparacionCol.Width = 100;
            // 
            // EstadoOrdenPreparacionCol
            // 
            EstadoOrdenPreparacionCol.Text = "Estado";
            EstadoOrdenPreparacionCol.Width = 100;
            // 
            // PrioridadOrdenPreparacionCol
            // 
            PrioridadOrdenPreparacionCol.Text = "Prioridad";
            PrioridadOrdenPreparacionCol.Width = 100;
            // 
            // FechaOrdenPreparacion
            // 
            FechaOrdenPreparacion.Text = "Fecha";
            FechaOrdenPreparacion.Width = 120;
            // 
            // OrdenesEntregaList
            // 
            OrdenesEntregaList.BorderStyle = BorderStyle.FixedSingle;
            OrdenesEntregaList.Columns.AddRange(new ColumnHeader[] { NroOrdenEntregaCol, IDProductoOrdenEntrega, DescripcionProductoOrdenEntrega, CantidadOrdenEntrega });
            OrdenesEntregaList.FullRowSelect = true;
            OrdenesEntregaList.GridLines = true;
            OrdenesEntregaList.Location = new Point(484, 110);
            OrdenesEntregaList.Margin = new Padding(2);
            OrdenesEntregaList.Name = "OrdenesEntregaList";
            OrdenesEntregaList.Size = new Size(376, 129);
            OrdenesEntregaList.TabIndex = 84;
            OrdenesEntregaList.UseCompatibleStateImageBehavior = false;
            OrdenesEntregaList.View = View.Details;
            // 
            // NroOrdenEntregaCol
            // 
            NroOrdenEntregaCol.Text = "IDOrdenPreparación";
            NroOrdenEntregaCol.Width = 100;
            // 
            // IDProductoOrdenEntrega
            // 
            IDProductoOrdenEntrega.Text = "IDCliente";
            IDProductoOrdenEntrega.Width = 100;
            // 
            // DescripcionProductoOrdenEntrega
            // 
            DescripcionProductoOrdenEntrega.Text = "DescripcionProducto";
            DescripcionProductoOrdenEntrega.Width = 120;
            // 
            // CantidadOrdenEntrega
            // 
            CantidadOrdenEntrega.Text = "Cantidad";
            CantidadOrdenEntrega.Width = 100;
            // 
            // OrdenConfirmntregaadaList
            // 
            OrdenConfirmntregaadaList.BorderStyle = BorderStyle.FixedSingle;
            OrdenConfirmntregaadaList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader7, columnHeader8 });
            OrdenConfirmntregaadaList.FullRowSelect = true;
            OrdenConfirmntregaadaList.GridLines = true;
            OrdenConfirmntregaadaList.Location = new Point(12, 337);
            OrdenConfirmntregaadaList.Margin = new Padding(2);
            OrdenConfirmntregaadaList.Name = "OrdenConfirmntregaadaList";
            OrdenConfirmntregaadaList.Size = new Size(849, 213);
            OrdenConfirmntregaadaList.TabIndex = 85;
            OrdenConfirmntregaadaList.UseCompatibleStateImageBehavior = false;
            OrdenConfirmntregaadaList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IDOrdenPreparacion";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "IDCliente";
            columnHeader2.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Productos";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Cantidad";
            columnHeader8.Width = 100;
            // 
            // IDOrdenPreparacionComboBox
            // 
            IDOrdenPreparacionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDOrdenPreparacionComboBox.FormattingEnabled = true;
            IDOrdenPreparacionComboBox.Location = new Point(13, 26);
            IDOrdenPreparacionComboBox.Margin = new Padding(2);
            IDOrdenPreparacionComboBox.Name = "IDOrdenPreparacionComboBox";
            IDOrdenPreparacionComboBox.Size = new Size(210, 23);
            IDOrdenPreparacionComboBox.TabIndex = 86;
            // 
            // FechaOrdenPreparacionComboBox
            // 
            FechaOrdenPreparacionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FechaOrdenPreparacionComboBox.FormattingEnabled = true;
            FechaOrdenPreparacionComboBox.Location = new Point(13, 70);
            FechaOrdenPreparacionComboBox.Margin = new Padding(2);
            FechaOrdenPreparacionComboBox.Name = "FechaOrdenPreparacionComboBox";
            FechaOrdenPreparacionComboBox.Size = new Size(210, 23);
            FechaOrdenPreparacionComboBox.TabIndex = 87;
            // 
            // button1
            // 
            button1.Location = new Point(470, 556);
            button1.Name = "button1";
            button1.Size = new Size(188, 23);
            button1.TabIndex = 88;
            button1.Text = "Crear Orden Entrega";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GenerarOrdenEntregaBoton_Click;
            // 
            // CrearOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 581);
            Controls.Add(button1);
            Controls.Add(FechaOrdenPreparacionComboBox);
            Controls.Add(IDOrdenPreparacionComboBox);
            Controls.Add(OrdenConfirmntregaadaList);
            Controls.Add(OrdenesEntregaList);
            Controls.Add(OrdenesPreparacionList);
            Controls.Add(BotonVolver);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(AgregarOrdenEntregaBoton);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(label2);
            Controls.Add(BotonCrear);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(LabelIDProducto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrearOrdenEntregaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearOrdenEntregaForm";
            Load += CrearOrdenEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCantidad;
        private Label label1;
        private Label label2;
        private Button BotonCrear;
        private Label LabelEspacioDisponible;
        private TextBox TxtIdProducto;
        private Label LabelPosicion;
        private TextBox TxtIdCliente;
        private Label LabelIDProducto;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Button BotonLimpiar;
        private Button BotonBuscar;
        private Button AgregarOrdenEntregaBoton;
        private ComboBox ComboBoxPrioridad;
        private Button BotonVolver;
        private ListView OrdenesPreparacionList;
        private ColumnHeader NroOrdenPreparacionCol;
        private ColumnHeader ClientePreparacionCol;
        private ColumnHeader EstadoOrdenPreparacionCol;
        private ColumnHeader PrioridadOrdenPreparacionCol;
        private ListView OrdenesEntregaList;
        private ColumnHeader NroOrdenEntregaCol;
        private ColumnHeader FechaOrdenPreparacion;
        private ColumnHeader IDClienteOrdenPreparacion;
        private ColumnHeader IDProductoOrdenEntrega;
        private ListView OrdenConfirmntregaadaList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private ColumnHeader DescripcionProductoOrdenEntrega;
        private ColumnHeader CantidadOrdenEntrega;
        private ComboBox IDOrdenPreparacionComboBox;
        private ComboBox FechaOrdenPreparacionComboBox;
        private Button button1;
        private ColumnHeader columnHeader8;
    }
}