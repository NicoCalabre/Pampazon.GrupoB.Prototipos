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
            ComboBoxEstado = new ComboBox();
            ComboEstado = new Label();
            label1 = new Label();
            LabelEspacioDisponible = new Label();
            LabelDescripcionProducto = new Label();
            LabelIdOrdenPreparacion = new Label();
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            ComboBoxPrioridad = new ComboBox();
            ComboBoxIDCliente = new ComboBox();
            ComboBoxIDOrden = new ComboBox();
            ComboBoxFecha = new ComboBox();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(669, 487);
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
            ListViewListaOrdenesPreparacion.FullRowSelect = true;
            ListViewListaOrdenesPreparacion.GridLines = true;
            ListViewListaOrdenesPreparacion.Location = new Point(12, 164);
            ListViewListaOrdenesPreparacion.MultiSelect = false;
            ListViewListaOrdenesPreparacion.Name = "ListViewListaOrdenesPreparacion";
            ListViewListaOrdenesPreparacion.Size = new Size(845, 290);
            ListViewListaOrdenesPreparacion.TabIndex = 10;
            ListViewListaOrdenesPreparacion.UseCompatibleStateImageBehavior = false;
            ListViewListaOrdenesPreparacion.View = View.Details;
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(16, 79);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(212, 23);
            ComboBoxEstado.TabIndex = 56;
            // 
            // ComboEstado
            // 
            ComboEstado.AutoSize = true;
            ComboEstado.Location = new Point(16, 61);
            ComboEstado.Name = "ComboEstado";
            ComboEstado.Size = new Size(42, 15);
            ComboEstado.TabIndex = 55;
            ComboEstado.Text = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(452, 15);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 53;
            label1.Text = "Fecha";
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(669, 15);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(55, 15);
            LabelEspacioDisponible.TabIndex = 51;
            LabelEspacioDisponible.Text = "Prioridad";
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(234, 15);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 49;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // LabelIdOrdenPreparacion
            // 
            LabelIdOrdenPreparacion.AutoSize = true;
            LabelIdOrdenPreparacion.Location = new Point(16, 15);
            LabelIdOrdenPreparacion.Name = "LabelIdOrdenPreparacion";
            LabelIdOrdenPreparacion.Size = new Size(120, 15);
            LabelIdOrdenPreparacion.TabIndex = 47;
            LabelIdOrdenPreparacion.Text = "ID Órden Preparacion";
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(670, 125);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 58;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(476, 125);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(188, 23);
            BotonBuscar.TabIndex = 57;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(670, 33);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(212, 23);
            ComboBoxPrioridad.TabIndex = 59;
            // 
            // ComboBoxIDCliente
            // 
            ComboBoxIDCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDCliente.FormattingEnabled = true;
            ComboBoxIDCliente.Location = new Point(234, 33);
            ComboBoxIDCliente.Name = "ComboBoxIDCliente";
            ComboBoxIDCliente.Size = new Size(212, 23);
            ComboBoxIDCliente.TabIndex = 60;
            // 
            // ComboBoxIDOrden
            // 
            ComboBoxIDOrden.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDOrden.FormattingEnabled = true;
            ComboBoxIDOrden.Location = new Point(16, 35);
            ComboBoxIDOrden.Name = "ComboBoxIDOrden";
            ComboBoxIDOrden.Size = new Size(212, 23);
            ComboBoxIDOrden.TabIndex = 61;
            // 
            // ComboBoxFecha
            // 
            ComboBoxFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxFecha.FormattingEnabled = true;
            ComboBoxFecha.Location = new Point(452, 33);
            ComboBoxFecha.Name = "ComboBoxFecha";
            ComboBoxFecha.Size = new Size(212, 23);
            ComboBoxFecha.TabIndex = 62;
            // 
            // ListadoOrdenesPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(886, 522);
            Controls.Add(ComboBoxFecha);
            Controls.Add(ComboBoxIDOrden);
            Controls.Add(ComboBoxIDCliente);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(ComboBoxEstado);
            Controls.Add(ComboEstado);
            Controls.Add(label1);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(LabelIdOrdenPreparacion);
            Controls.Add(BotonVolver);
            Controls.Add(ListViewListaOrdenesPreparacion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoOrdenesPreparacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListadoOrdenesPreparacionForm";
            Load += ListadoOrdenesPreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonVolver;
        private ListView ListViewListaOrdenesPreparacion;
        private ComboBox ComboBoxEstado;
        private Label ComboEstado;
        private Label label1;
        private Label LabelEspacioDisponible;
        private Label LabelDescripcionProducto;
        private Label LabelIdOrdenPreparacion;
        private Button BotonLimpiar;
        private Button BotonBuscar;
        private ComboBox ComboBoxPrioridad;
        private ComboBox ComboBoxIDCliente;
        private ComboBox ComboBoxIDOrden;
        private ComboBox ComboBoxFecha;
    }
}