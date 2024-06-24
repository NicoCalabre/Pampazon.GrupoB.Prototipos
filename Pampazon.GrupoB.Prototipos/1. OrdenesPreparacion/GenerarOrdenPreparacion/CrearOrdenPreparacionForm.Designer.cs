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
            ComboBoxIDCliente = new ComboBox();
            TxtCantidad = new TextBox();
            ComboBoxIDProducto = new ComboBox();
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
            LabelIDProd.Location = new Point(22, 63);
            LabelIDProd.Name = "LabelIDProd";
            LabelIDProd.Size = new Size(56, 15);
            LabelIDProd.TabIndex = 45;
            LabelIDProd.Text = "Producto";
            LabelIDProd.Click += LabelIDProd_Click;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(22, 9);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 43;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // LabelCantidad
            // 
            LabelCantidad.AutoSize = true;
            LabelCantidad.Location = new Point(207, 63);
            LabelCantidad.Name = "LabelCantidad";
            LabelCantidad.Size = new Size(55, 15);
            LabelCantidad.TabIndex = 54;
            LabelCantidad.Text = "Cantidad";
            // 
            // PrioridadLabel
            // 
            PrioridadLabel.AutoSize = true;
            PrioridadLabel.Location = new Point(213, 411);
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
            EliminarProductoBoton.Location = new Point(586, 81);
            EliminarProductoBoton.Name = "EliminarProductoBoton";
            EliminarProductoBoton.Size = new Size(146, 23);
            EliminarProductoBoton.TabIndex = 57;
            EliminarProductoBoton.Text = "Eliminar Producto";
            EliminarProductoBoton.UseVisualStyleBackColor = true;
            EliminarProductoBoton.Click += EliminarProductoBoton_Click;
            // 
            // AgregarProductoBoton
            // 
            AgregarProductoBoton.Location = new Point(434, 81);
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
            ComboBoxPrioridad.Location = new Point(213, 429);
            ComboBoxPrioridad.Name = "ComboBoxPrioridad";
            ComboBoxPrioridad.Size = new Size(173, 23);
            ComboBoxPrioridad.TabIndex = 59;
            ComboBoxPrioridad.SelectedIndexChanged += ComboBoxPrioridad_SelectedIndexChanged;
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(22, 429);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(173, 23);
            ComboBoxEstado.TabIndex = 61;
            ComboBoxEstado.SelectedIndexChanged += ComboBoxEstado_SelectedIndexChanged;
            // 
            // EstadoLabel
            // 
            EstadoLabel.AutoSize = true;
            EstadoLabel.Location = new Point(22, 411);
            EstadoLabel.Name = "EstadoLabel";
            EstadoLabel.Size = new Size(42, 15);
            EstadoLabel.TabIndex = 60;
            EstadoLabel.Text = "Estado";
            EstadoLabel.Click += label3_Click;
            // 
            // ComboBoxIDCliente
            // 
            ComboBoxIDCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDCliente.FormattingEnabled = true;
            ComboBoxIDCliente.Location = new Point(22, 27);
            ComboBoxIDCliente.Name = "ComboBoxIDCliente";
            ComboBoxIDCliente.Size = new Size(173, 23);
            ComboBoxIDCliente.TabIndex = 67;
            ComboBoxIDCliente.SelectedIndexChanged += ComboBoxIDCliente_SelectedIndexChanged;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(208, 81);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(173, 23);
            TxtCantidad.TabIndex = 69;
            // 
            // ComboBoxIDProducto
            // 
            ComboBoxIDProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxIDProducto.FormattingEnabled = true;
            ComboBoxIDProducto.Location = new Point(22, 81);
            ComboBoxIDProducto.Name = "ComboBoxIDProducto";
            ComboBoxIDProducto.Size = new Size(173, 23);
            ComboBoxIDProducto.TabIndex = 70;
            // 
            // CrearOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(771, 513);
            Controls.Add(ComboBoxIDProducto);
            Controls.Add(TxtCantidad);
            Controls.Add(ComboBoxIDCliente);
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
        private ComboBox ComboBoxIDCliente;
        private TextBox TxtCantidad;
        private ComboBox ComboBoxIDProducto;
    }
}