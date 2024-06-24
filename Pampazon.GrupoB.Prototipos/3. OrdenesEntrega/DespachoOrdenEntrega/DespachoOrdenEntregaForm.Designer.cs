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
            BotonAgregarDespacho.Location = new Point(573, 296);
            BotonAgregarDespacho.Name = "BotonAgregarDespacho";
            BotonAgregarDespacho.Size = new Size(225, 23);
            BotonAgregarDespacho.TabIndex = 102;
            BotonAgregarDespacho.Text = "Agregar al listado de despachos";
            BotonAgregarDespacho.UseVisualStyleBackColor = true;
            BotonAgregarDespacho.Click += BotonAgregarDespacho_Click;
            // 
            // LimpiarBoton
            // 
            LimpiarBoton.Location = new Point(643, 27);
            LimpiarBoton.Name = "LimpiarBoton";
            LimpiarBoton.Size = new Size(188, 23);
            LimpiarBoton.TabIndex = 101;
            LimpiarBoton.Text = "Limpiar";
            LimpiarBoton.UseVisualStyleBackColor = true;
            LimpiarBoton.Click += LimpiarBoton_Click;
            // 
            // BotonListar
            // 
            BotonListar.Location = new Point(449, 27);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(188, 23);
            BotonListar.TabIndex = 100;
            BotonListar.Text = "Buscar";
            BotonListar.UseVisualStyleBackColor = true;
            BotonListar.Click += BotonListar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 175);
            label3.Name = "label3";
            label3.Size = new Size(301, 15);
            label3.TabIndex = 98;
            label3.Text = "Lista de ordenes de entrega para asignar a un transporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 175);
            label1.Name = "label1";
            label1.Size = new Size(227, 15);
            label1.TabIndex = 97;
            label1.Text = "Lista de ordenes de entrega seleccionadas";
            // 
            // BotonSacarOrdenDespacho
            // 
            BotonSacarOrdenDespacho.Location = new Point(396, 212);
            BotonSacarOrdenDespacho.Name = "BotonSacarOrdenDespacho";
            BotonSacarOrdenDespacho.Size = new Size(73, 23);
            BotonSacarOrdenDespacho.TabIndex = 96;
            BotonSacarOrdenDespacho.Text = "<-";
            BotonSacarOrdenDespacho.UseVisualStyleBackColor = true;
            BotonSacarOrdenDespacho.Click += BotonSacarOrdenDespacho_Click;
            // 
            // BotonAgregarOrdenDespacho
            // 
            BotonAgregarOrdenDespacho.Location = new Point(396, 176);
            BotonAgregarOrdenDespacho.Name = "BotonAgregarOrdenDespacho";
            BotonAgregarOrdenDespacho.Size = new Size(73, 23);
            BotonAgregarOrdenDespacho.TabIndex = 95;
            BotonAgregarOrdenDespacho.Text = "->";
            BotonAgregarOrdenDespacho.UseVisualStyleBackColor = true;
            BotonAgregarOrdenDespacho.Click += BotonAgregarOrdenDespacho_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(321, 633);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 88;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(127, 633);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(188, 23);
            BotonCrear.TabIndex = 87;
            BotonCrear.Text = "&Despachar";
            BotonCrear.UseVisualStyleBackColor = true;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(516, 633);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 86;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(11, 53);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(117, 15);
            LabelEspacioDisponible.TabIndex = 84;
            LabelEspacioDisponible.Text = "Fecha Orden Entrega";
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(12, 9);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(97, 15);
            LabelIDProducto.TabIndex = 81;
            LabelIDProducto.Text = "ID Orden Entrega";
            // 
            // OrdenesEntregaList
            // 
            OrdenesEntregaList.BorderStyle = BorderStyle.FixedSingle;
            OrdenesEntregaList.Columns.AddRange(new ColumnHeader[] { NroOrdenEntregaCol, NroOrdenPreparacionCol, IDClienteOrdenPreparacion, FechaOrdenEntregaCol });
            OrdenesEntregaList.FullRowSelect = true;
            OrdenesEntregaList.GridLines = true;
            OrdenesEntregaList.Location = new Point(8, 107);
            OrdenesEntregaList.Margin = new Padding(2, 2, 2, 2);
            OrdenesEntregaList.Name = "OrdenesEntregaList";
            OrdenesEntregaList.Size = new Size(377, 213);
            OrdenesEntregaList.TabIndex = 106;
            OrdenesEntregaList.UseCompatibleStateImageBehavior = false;
            OrdenesEntregaList.View = View.Details;
            // 
            // NroOrdenEntregaCol
            // 
            NroOrdenEntregaCol.Text = "IDOrdenEntrega";
            NroOrdenEntregaCol.Width = 120;
            // 
            // NroOrdenPreparacionCol
            // 
            NroOrdenPreparacionCol.Text = "IDOrdenPreparacion";
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
            OrdenesDespachoList.Location = new Point(482, 110);
            OrdenesDespachoList.Margin = new Padding(2, 2, 2, 2);
            OrdenesDespachoList.Name = "OrdenesDespachoList";
            OrdenesDespachoList.Size = new Size(377, 175);
            OrdenesDespachoList.TabIndex = 107;
            OrdenesDespachoList.UseCompatibleStateImageBehavior = false;
            OrdenesDespachoList.View = View.Details;
            // 
            // IDOrdenEntregaDespacho
            // 
            IDOrdenEntregaDespacho.Text = "IDOrdenEntrega";
            IDOrdenEntregaDespacho.Width = 120;
            // 
            // NroOrdenPreparacionDespacho
            // 
            NroOrdenPreparacionDespacho.Text = "IDOrdenPreparacion";
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
            OrdenDespachoConfirmadaList.Location = new Point(8, 335);
            OrdenDespachoConfirmadaList.Margin = new Padding(2, 2, 2, 2);
            OrdenDespachoConfirmadaList.Name = "OrdenDespachoConfirmadaList";
            OrdenDespachoConfirmadaList.Size = new Size(851, 213);
            OrdenDespachoConfirmadaList.TabIndex = 108;
            OrdenDespachoConfirmadaList.UseCompatibleStateImageBehavior = false;
            OrdenDespachoConfirmadaList.View = View.Details;
            // 
            // NroOrdenDespacho
            // 
            NroOrdenDespacho.Text = "IDOrdenPreparacion";
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
            button1.Location = new Point(671, 552);
            button1.Name = "button1";
            button1.Size = new Size(188, 23);
            button1.TabIndex = 109;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IDOrdenEntregaComboBox
            // 
            IDOrdenEntregaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            IDOrdenEntregaComboBox.FormattingEnabled = true;
            IDOrdenEntregaComboBox.Location = new Point(12, 29);
            IDOrdenEntregaComboBox.Margin = new Padding(2, 2, 2, 2);
            IDOrdenEntregaComboBox.Name = "IDOrdenEntregaComboBox";
            IDOrdenEntregaComboBox.Size = new Size(374, 23);
            IDOrdenEntregaComboBox.TabIndex = 110;
            // 
            // FechaOrdenEntregaComboBox
            // 
            FechaOrdenEntregaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FechaOrdenEntregaComboBox.FormattingEnabled = true;
            FechaOrdenEntregaComboBox.Location = new Point(12, 70);
            FechaOrdenEntregaComboBox.Margin = new Padding(2, 2, 2, 2);
            FechaOrdenEntregaComboBox.Name = "FechaOrdenEntregaComboBox";
            FechaOrdenEntregaComboBox.Size = new Size(374, 23);
            FechaOrdenEntregaComboBox.TabIndex = 111;
            // 
            // OrdenDespachoBoton
            // 
            OrdenDespachoBoton.Location = new Point(477, 552);
            OrdenDespachoBoton.Name = "OrdenDespachoBoton";
            OrdenDespachoBoton.Size = new Size(188, 23);
            OrdenDespachoBoton.TabIndex = 112;
            OrdenDespachoBoton.Text = "Crear Orden Despacho";
            OrdenDespachoBoton.UseVisualStyleBackColor = true;
            OrdenDespachoBoton.Click += BotonCrearOrdenDespacho_Click;
            // 
            // DespachoOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 583);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DespachoOrdenEntregaForm";
            StartPosition = FormStartPosition.CenterScreen;
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