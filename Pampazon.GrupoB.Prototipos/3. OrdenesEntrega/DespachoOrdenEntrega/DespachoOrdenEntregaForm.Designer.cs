namespace Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega
{
    partial class DespachoOrdenEntregaForm
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
            BotonAgregarDespacho = new Button();
            LimpiarBoton = new Button();
            BotonListar = new Button();
            label3 = new Label();
            label1 = new Label();
            BotonSacarOrdenDespacho = new Button();
            BotonAgregarOrdenDespacho = new Button();
            BotonLimpiar = new Button();
            BotonCrear = new Button();
            BotonVolver = new Button();
            LabelEspacioDisponible = new Label();
            LabelIDProducto = new Label();
            OrdenesEntregaList = new ListView();
            NroOrdenEntregaCol = new ColumnHeader();
            NroOrdenPreparacionCol = new ColumnHeader();
            IDClienteOrdenPreparacion = new ColumnHeader();
            FechaOrdenEntregaCol = new ColumnHeader();
            OrdenesDespachoList = new ListView();
            IDOrdenEntregaDespacho = new ColumnHeader();
            NroOrdenPreparacionDespacho = new ColumnHeader();
            IDClienteOrdenDespacho = new ColumnHeader();
            FechaCreacionOrdenEntregaDespacho = new ColumnHeader();
            OrdenDespachoConfirmadaList = new ListView();
            NroOrdenDespacho = new ColumnHeader();
            IDClienteOrdenDespachoCreada = new ColumnHeader();
            FechaOrdenDespacho = new ColumnHeader();
            button1 = new Button();
            IDOrdenEntregaComboBox = new ComboBox();
            FechaOrdenEntregaComboBox = new ComboBox();
            OrdenDespachoBoton = new Button();
            SuspendLayout();
            // 
            // BotonAgregarDespacho
            // 
            BotonAgregarDespacho.Location = new Point(819, 494);
            BotonAgregarDespacho.Margin = new Padding(4, 5, 4, 5);
            BotonAgregarDespacho.Name = "BotonAgregarDespacho";
            BotonAgregarDespacho.Size = new Size(321, 38);
            BotonAgregarDespacho.TabIndex = 102;
            BotonAgregarDespacho.Text = "Agregar al listado de despachos";
            BotonAgregarDespacho.UseVisualStyleBackColor = true;
            BotonAgregarDespacho.Click += BotonAgregarDespacho_Click;
            // 
            // LimpiarBoton
            // 
            LimpiarBoton.Location = new Point(919, 45);
            LimpiarBoton.Margin = new Padding(4, 5, 4, 5);
            LimpiarBoton.Name = "LimpiarBoton";
            LimpiarBoton.Size = new Size(269, 38);
            LimpiarBoton.TabIndex = 101;
            LimpiarBoton.Text = "Limpiar";
            LimpiarBoton.UseVisualStyleBackColor = true;
            LimpiarBoton.Click += LimpiarBoton_Click;
            // 
            // BotonListar
            // 
            BotonListar.Location = new Point(641, 45);
            BotonListar.Margin = new Padding(4, 5, 4, 5);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(269, 38);
            BotonListar.TabIndex = 100;
            BotonListar.Text = "Buscar";
            BotonListar.UseVisualStyleBackColor = true;
            BotonListar.Click += BotonListar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(757, 292);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(459, 25);
            label3.TabIndex = 98;
            label3.Text = "Lista de ordenes de entrega para asignar a un transporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 292);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 97;
            label1.Text = "Lista de ordenes de entrega seleccionadas";
            // 
            // BotonSacarOrdenDespacho
            // 
            BotonSacarOrdenDespacho.Location = new Point(566, 353);
            BotonSacarOrdenDespacho.Margin = new Padding(4, 5, 4, 5);
            BotonSacarOrdenDespacho.Name = "BotonSacarOrdenDespacho";
            BotonSacarOrdenDespacho.Size = new Size(104, 38);
            BotonSacarOrdenDespacho.TabIndex = 96;
            BotonSacarOrdenDespacho.Text = "<-";
            BotonSacarOrdenDespacho.UseVisualStyleBackColor = true;
            BotonSacarOrdenDespacho.Click += BotonSacarOrdenDespacho_Click;
            // 
            // BotonAgregarOrdenDespacho
            // 
            BotonAgregarOrdenDespacho.Location = new Point(566, 294);
            BotonAgregarOrdenDespacho.Margin = new Padding(4, 5, 4, 5);
            BotonAgregarOrdenDespacho.Name = "BotonAgregarOrdenDespacho";
            BotonAgregarOrdenDespacho.Size = new Size(104, 38);
            BotonAgregarOrdenDespacho.TabIndex = 95;
            BotonAgregarOrdenDespacho.Text = "->";
            BotonAgregarOrdenDespacho.UseVisualStyleBackColor = true;
            BotonAgregarOrdenDespacho.Click += BotonAgregarOrdenDespacho_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(459, 1055);
            BotonLimpiar.Margin = new Padding(4, 5, 4, 5);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(269, 38);
            BotonLimpiar.TabIndex = 88;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(181, 1055);
            BotonCrear.Margin = new Padding(4, 5, 4, 5);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(269, 38);
            BotonCrear.TabIndex = 87;
            BotonCrear.Text = "&Despachar";
            BotonCrear.UseVisualStyleBackColor = true;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(737, 1055);
            BotonVolver.Margin = new Padding(4, 5, 4, 5);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(269, 38);
            BotonVolver.TabIndex = 86;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(16, 88);
            LabelEspacioDisponible.Margin = new Padding(4, 0, 4, 0);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(177, 25);
            LabelEspacioDisponible.TabIndex = 84;
            LabelEspacioDisponible.Text = "Fecha Orden Entrega";
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(17, 15);
            LabelIDProducto.Margin = new Padding(4, 0, 4, 0);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(150, 25);
            LabelIDProducto.TabIndex = 81;
            LabelIDProducto.Text = "ID Orden Entrega";
            // 
            // OrdenesEntregaList
            // 
            OrdenesEntregaList.BorderStyle = BorderStyle.FixedSingle;
            OrdenesEntregaList.Columns.AddRange(new ColumnHeader[] { NroOrdenEntregaCol, NroOrdenPreparacionCol, IDClienteOrdenPreparacion, FechaOrdenEntregaCol });
            OrdenesEntregaList.FullRowSelect = true;
            OrdenesEntregaList.GridLines = true;
            OrdenesEntregaList.Location = new Point(12, 178);
            OrdenesEntregaList.Name = "OrdenesEntregaList";
            OrdenesEntregaList.Size = new Size(538, 354);
            OrdenesEntregaList.TabIndex = 106;
            OrdenesEntregaList.UseCompatibleStateImageBehavior = false;
            OrdenesEntregaList.View = View.Details;
            // 
            // NroOrdenEntregaCol
            // 
            NroOrdenEntregaCol.Text = "NroOrdenEntrega";
            NroOrdenEntregaCol.Width = 120;
            // 
            // NroOrdenPreparacionCol
            // 
            NroOrdenPreparacionCol.Text = "NroOrdenPreparacion";
            NroOrdenPreparacionCol.Width = 120;
            // 
            // IDClienteOrdenPreparacion
            // 
            IDClienteOrdenPreparacion.Text = "IDCliente";
            IDClienteOrdenPreparacion.Width = 120;
            // 
            // FechaOrdenEntregaCol
            // 
            FechaOrdenEntregaCol.Text = "Fecha";
            FechaOrdenEntregaCol.Width = 120;
            // 
            // OrdenesDespachoList
            // 
            OrdenesDespachoList.BorderStyle = BorderStyle.FixedSingle;
            OrdenesDespachoList.Columns.AddRange(new ColumnHeader[] { IDOrdenEntregaDespacho, NroOrdenPreparacionDespacho, IDClienteOrdenDespacho, FechaCreacionOrdenEntregaDespacho });
            OrdenesDespachoList.FullRowSelect = true;
            OrdenesDespachoList.GridLines = true;
            OrdenesDespachoList.Location = new Point(689, 183);
            OrdenesDespachoList.Name = "OrdenesDespachoList";
            OrdenesDespachoList.Size = new Size(538, 291);
            OrdenesDespachoList.TabIndex = 107;
            OrdenesDespachoList.UseCompatibleStateImageBehavior = false;
            OrdenesDespachoList.View = View.Details;
            // 
            // IDOrdenEntregaDespacho
            // 
            IDOrdenEntregaDespacho.Text = "NroOrden";
            IDOrdenEntregaDespacho.Width = 120;
            // 
            // NroOrdenPreparacionDespacho
            // 
            NroOrdenPreparacionDespacho.Text = "NroOrdenPreparacion";
            NroOrdenPreparacionDespacho.Width = 120;
            // 
            // IDClienteOrdenDespacho
            // 
            IDClienteOrdenDespacho.Text = "IDCliente";
            IDClienteOrdenDespacho.Width = 120;
            // 
            // FechaCreacionOrdenEntregaDespacho
            // 
            FechaCreacionOrdenEntregaDespacho.Text = "Fecha";
            FechaCreacionOrdenEntregaDespacho.Width = 100;
            // 
            // OrdenDespachoConfirmadaList
            // 
            OrdenDespachoConfirmadaList.BorderStyle = BorderStyle.FixedSingle;
            OrdenDespachoConfirmadaList.Columns.AddRange(new ColumnHeader[] { NroOrdenDespacho, IDClienteOrdenDespachoCreada, FechaOrdenDespacho });
            OrdenDespachoConfirmadaList.FullRowSelect = true;
            OrdenDespachoConfirmadaList.GridLines = true;
            OrdenDespachoConfirmadaList.Location = new Point(12, 558);
            OrdenDespachoConfirmadaList.Name = "OrdenDespachoConfirmadaList";
            OrdenDespachoConfirmadaList.Size = new Size(1215, 354);
            OrdenDespachoConfirmadaList.TabIndex = 108;
            OrdenDespachoConfirmadaList.UseCompatibleStateImageBehavior = false;
            OrdenDespachoConfirmadaList.View = View.Details;
            // 
            // NroOrdenDespacho
            // 
            NroOrdenDespacho.Text = "NroOrden";
            NroOrdenDespacho.Width = 100;
            // 
            // IDClienteOrdenDespachoCreada
            // 
            IDClienteOrdenDespachoCreada.Text = "IDCliente";
            IDClienteOrdenDespachoCreada.Width = 120;
            // 
            // FechaOrdenDespacho
            // 
            FechaOrdenDespacho.Text = "Fecha";
            FechaOrdenDespacho.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(958, 920);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(269, 38);
            button1.TabIndex = 109;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IDOrdenEntregaComboBox
            // 
            IDOrdenEntregaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDOrdenEntregaComboBox.FormattingEnabled = true;
            IDOrdenEntregaComboBox.Location = new Point(17, 49);
            IDOrdenEntregaComboBox.Name = "IDOrdenEntregaComboBox";
            IDOrdenEntregaComboBox.Size = new Size(533, 33);
            IDOrdenEntregaComboBox.TabIndex = 110;
            // 
            // FechaOrdenEntregaComboBox
            // 
            FechaOrdenEntregaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FechaOrdenEntregaComboBox.FormattingEnabled = true;
            FechaOrdenEntregaComboBox.Location = new Point(17, 116);
            FechaOrdenEntregaComboBox.Name = "FechaOrdenEntregaComboBox";
            FechaOrdenEntregaComboBox.Size = new Size(533, 33);
            FechaOrdenEntregaComboBox.TabIndex = 111;
            // 
            // OrdenDespachoBoton
            // 
            OrdenDespachoBoton.Location = new Point(681, 920);
            OrdenDespachoBoton.Margin = new Padding(4, 5, 4, 5);
            OrdenDespachoBoton.Name = "OrdenDespachoBoton";
            OrdenDespachoBoton.Size = new Size(269, 38);
            OrdenDespachoBoton.TabIndex = 112;
            OrdenDespachoBoton.Text = "Crear Orden Despacho";
            OrdenDespachoBoton.UseVisualStyleBackColor = true;
            OrdenDespachoBoton.Click += BotonCrearOrdenDespacho_Click;
            // 
            // DespachoOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 971);
            Controls.Add(OrdenDespachoBoton);
            Controls.Add(FechaOrdenEntregaComboBox);
            Controls.Add(IDOrdenEntregaComboBox);
            Controls.Add(button1);
            Controls.Add(OrdenDespachoConfirmadaList);
            Controls.Add(OrdenesDespachoList);
            Controls.Add(OrdenesEntregaList);
            Controls.Add(BotonAgregarDespacho);
            Controls.Add(LimpiarBoton);
            Controls.Add(BotonListar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(BotonSacarOrdenDespacho);
            Controls.Add(BotonAgregarOrdenDespacho);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCrear);
            Controls.Add(BotonVolver);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(LabelIDProducto);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DespachoOrdenEntregaForm";
            Text = "DespachoOrdenEntrega";
            Load += DespachoOrdenEntrega_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonAgregarDespacho;
        private Button LimpiarBoton;
        private Button BotonListar;
        private Label label3;
        private Label label1;
        private Button BotonSacarOrdenDespacho;
        private Button BotonAgregarOrdenDespacho;
        private Button BotonLimpiar;
        private Button BotonCrear;
        private Button BotonVolver;
        private Label LabelEspacioDisponible;
        private Label LabelIDProducto;
        private ListView OrdenesEntregaList;
        private ColumnHeader NroOrdenEntregaCol;
        private ColumnHeader IDClienteOrdenPreparacion;
        private ColumnHeader ClientePreparacionCol;
        private ColumnHeader EstadoOrdenPreparacionCol;
        private ColumnHeader PrioridadOrdenPreparacionCol;
        private ColumnHeader FechaOrdenEntregaCol;
        private ColumnHeader IDProductoOrdenPreparacion;
        private ListView OrdenesDespachoList;
        private ColumnHeader NroOrdenPreparacionDespacho;
        private ColumnHeader FechaCreacionOrdenEntregaDespacho;
        private ColumnHeader IDOrdenEntregaDespacho;
        private ListView OrdenDespachoConfirmadaList;
        private ColumnHeader NroOrdenDespacho;
        private ColumnHeader FechaOrdenDespacho;
        private Button button1;
        private ColumnHeader NroOrdenPreparacionCol;
        private ComboBox IDOrdenEntregaComboBox;
        private ComboBox FechaOrdenEntregaComboBox;
        private ColumnHeader IDClienteOrdenDespacho;
        private ColumnHeader IDClienteOrdenDespachoCreada;
        private Button OrdenDespachoBoton;
    }
}