namespace Pampazon.GrupoB.Prototipos
{
    partial class CrearOrdenPreparacionForm
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
            BotonLimpiar = new Button();
            BotonCrear = new Button();
            BotonVolver = new Button();
            LabelIDProd = new Label();
            LabelDescripcionProducto = new Label();
            LabelCantidad = new Label();
            PrioridadLabel = new Label();
            ProductosList = new ListView();
            EliminarProductoBoton = new Button();
            AgregarProductoBoton = new Button();
            ComboBoxPrioridad = new ComboBox();
            ComboBoxEstado = new ComboBox();
            EstadoLabel = new Label();
            LabelDescProd = new Label();
            ComboBoxIDCliente = new ComboBox();
            TxtIDProducto = new TextBox();
            TxtCantidad = new TextBox();
            TxtDescProd = new TextBox();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(288, 481);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 51;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click_1;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(94, 481);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(188, 23);
            BotonCrear.TabIndex = 50;
            BotonCrear.Text = "&Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            BotonCrear.Click += BotonCrear_Click_1;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(482, 481);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 49;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // LabelIDProd
            // 
            LabelIDProd.AutoSize = true;
            LabelIDProd.Location = new Point(22, 12);
            LabelIDProd.Name = "LabelIDProd";
            LabelIDProd.Size = new Size(70, 15);
            LabelIDProd.TabIndex = 45;
            LabelIDProd.Text = "ID Producto";
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(22, 411);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 43;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // LabelCantidad
            // 
            LabelCantidad.AutoSize = true;
            LabelCantidad.Location = new Point(207, 12);
            LabelCantidad.Name = "LabelCantidad";
            LabelCantidad.Size = new Size(55, 15);
            LabelCantidad.TabIndex = 54;
            LabelCantidad.Text = "Cantidad";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(399, 411);
            PrioridadLabel.Name = "PrioridadLabel";
            PrioridadLabel.Size = new Size(55, 15);
            PrioridadLabel.TabIndex = 52;
            PrioridadLabel.Text = "Prioridad";
            // 
            // ProductosList
            // 
            ProductosList.CheckBoxes = true;
            ProductosList.FullRowSelect = true;
            ProductosList.Location = new Point(22, 129);
            ProductosList.MultiSelect = false;
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(726, 269);
            ProductosList.TabIndex = 56;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            ProductosList.SelectedIndexChanged += ProductosList_SelectedIndexChanged;
            // 
            // EliminarProductoBoton
            // 
            EliminarProductoBoton.Location = new Point(578, 29);
            EliminarProductoBoton.Name = "EliminarProductoBoton";
            EliminarProductoBoton.Size = new Size(146, 23);
            EliminarProductoBoton.TabIndex = 57;
            EliminarProductoBoton.Text = "Eliminar Producto";
            EliminarProductoBoton.UseVisualStyleBackColor = true;
            EliminarProductoBoton.Click += EliminarProductoBoton_Click;
            // 
            // AgregarProductoBoton
            // 
            AgregarProductoBoton.Location = new Point(426, 29);
            AgregarProductoBoton.Name = "AgregarProductoBoton";
            AgregarProductoBoton.Size = new Size(146, 23);
            AgregarProductoBoton.TabIndex = 58;
            AgregarProductoBoton.Text = "Agregar Producto";
            AgregarProductoBoton.UseVisualStyleBackColor = true;
            AgregarProductoBoton.Click += AgregarProductoBoton_Click;
            // 
            // ComboBoxPrioridad
            // 
            ComboBoxPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxPrioridad.FormattingEnabled = true;
            ComboBoxPrioridad.Location = new Point(399, 429);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(173, 23);
            ComboBoxPrioridad.TabIndex = 59;
            ComboBoxPrioridad.SelectedIndexChanged += ComboBoxPrioridad_SelectedIndexChanged;
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(208, 429);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(173, 23);
            ComboBoxEstado.TabIndex = 61;
            ComboBoxEstado.SelectedIndexChanged += ComboBoxEstado_SelectedIndexChanged;
            // 
            // EstadoLabel
            // 
            EstadoLabel.AutoSize = true;
            EstadoLabel.Location = new Point(208, 411);
            EstadoLabel.Name = "EstadoLabel";
            EstadoLabel.Size = new Size(42, 15);
            EstadoLabel.TabIndex = 60;
            EstadoLabel.Text = "Estado";
            EstadoLabel.Click += label3_Click;
            // 
            // LabelDescProd
            // 
            LabelDescProd.AutoSize = true;
            LabelDescProd.Location = new Point(23, 59);
            LabelDescProd.Name = "LabelDescProd";
            LabelDescProd.Size = new Size(121, 15);
            LabelDescProd.TabIndex = 62;
            LabelDescProd.Text = "Descripción Producto";
            LabelDescProd.Click += label2_Click;
            // 
            // ComboBoxIDCliente
            // 
            ComboBoxIDCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDCliente.FormattingEnabled = true;
            ComboBoxIDCliente.Location = new Point(22, 429);
            ComboBoxIDCliente.Name = "ComboBoxIDCliente";
            ComboBoxIDCliente.Size = new Size(173, 23);
            ComboBoxIDCliente.TabIndex = 67;
            // 
            // TxtIDProducto
            // 
            TxtIDProducto.Location = new Point(22, 29);
            TxtIDProducto.Name = "TxtIDProducto";
            TxtIDProducto.Size = new Size(173, 23);
            TxtIDProducto.TabIndex = 68;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(208, 30);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(173, 23);
            TxtCantidad.TabIndex = 69;
            // 
            // TxtDescProd
            // 
            TxtDescProd.Location = new Point(22, 77);
            TxtDescProd.Name = "TxtDescProd";
            TxtDescProd.Size = new Size(173, 23);
            TxtDescProd.TabIndex = 70;
            // 
            // CrearOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(771, 513);
            Controls.Add(TxtDescProd);
            Controls.Add(TxtCantidad);
            Controls.Add(TxtIDProducto);
            Controls.Add(ComboBoxIDCliente);
            Controls.Add(LabelDescProd);
            Controls.Add(ComboBoxEstado);
            Controls.Add(EstadoLabel);
            Controls.Add(ComboBoxPrioridad);
            Controls.Add(AgregarProductoBoton);
            Controls.Add(EliminarProductoBoton);
            Controls.Add(ProductosList);
            Controls.Add(LabelCantidad);
            Controls.Add(PrioridadLabel);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCrear);
            Controls.Add(BotonVolver);
            Controls.Add(LabelIDProd);
            Controls.Add(LabelDescripcionProducto);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrearOrdenPreparacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearOrdenPreparacionForm";
            Load += CrearOrdenPreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonCrear;
        private Button BotonVolver;
        private Label LabelIDProd;
        private Label LabelDescripcionProducto;
        private Label LabelCantidad;
        private Label PrioridadLabel;
        private ListView ProductosList;
        private Button EliminarProductoBoton;
        private Button AgregarProductoBoton;
        private ComboBox ComboBoxPrioridad;
        private ComboBox ComboBoxEstado;
        private Label EstadoLabel;
        private Label LabelDescProd;
        private ComboBox ComboBoxIDCliente;
        private TextBox TxtIDProducto;
        private TextBox TxtCantidad;
        private TextBox TxtDescProd;
    }
}