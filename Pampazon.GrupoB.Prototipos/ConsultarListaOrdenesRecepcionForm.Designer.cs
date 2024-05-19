namespace Pampazon.GrupoB.Prototipos
{
    partial class ConsultarListaOrdenesRecepcionForm
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
            BotonBuscar = new Button();
            BotonVolver = new Button();
            TxtPrioridad = new TextBox();
            LabelEspacioDisponible = new Label();
            TxtIDCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIDOrdenesRecepcion = new TextBox();
            LabelIDProducto = new Label();
            TxtFecha = new TextBox();
            label1 = new Label();
            ComboBoxEstado = new ComboBox();
            ComboEstado = new Label();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(353, 533);
            BotonLimpiar.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(215, 31);
            BotonLimpiar.TabIndex = 29;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(131, 533);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(215, 31);
            BotonBuscar.TabIndex = 28;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(575, 533);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 27;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtPrioridad
            // 
            TxtPrioridad.Location = new Point(472, 264);
            TxtPrioridad.Margin = new Padding(3, 4, 3, 4);
            TxtPrioridad.Name = "TxtPrioridad";
            TxtPrioridad.Size = new Size(242, 27);
            TxtPrioridad.TabIndex = 26;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(472, 240);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(70, 20);
            LabelEspacioDisponible.TabIndex = 25;
            LabelEspacioDisponible.Text = "Prioridad";
            // 
            // TxtIDCliente
            // 
            TxtIDCliente.Location = new Point(197, 264);
            TxtIDCliente.Margin = new Padding(3, 4, 3, 4);
            TxtIDCliente.Name = "TxtIDCliente";
            TxtIDCliente.Size = new Size(242, 27);
            TxtIDCliente.TabIndex = 22;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(197, 240);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(74, 20);
            LabelDescripcionProducto.TabIndex = 21;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIDOrdenesRecepcion
            // 
            TxtIDOrdenesRecepcion.Location = new Point(197, 205);
            TxtIDOrdenesRecepcion.Margin = new Padding(3, 4, 3, 4);
            TxtIDOrdenesRecepcion.Name = "TxtIDOrdenesRecepcion";
            TxtIDOrdenesRecepcion.Size = new Size(242, 27);
            TxtIDOrdenesRecepcion.TabIndex = 20;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(197, 181);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(156, 20);
            LabelIDProducto.TabIndex = 19;
            LabelIDProducto.Text = "ID Órdenes Recepción";
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(197, 335);
            TxtFecha.Margin = new Padding(3, 4, 3, 4);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(517, 27);
            TxtFecha.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 311);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 30;
            label1.Text = "Fecha";
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(472, 205);
            ComboBoxEstado.Margin = new Padding(3, 4, 3, 4);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(242, 28);
            ComboBoxEstado.TabIndex = 33;
            // 
            // ComboEstado
            // 
            ComboEstado.AutoSize = true;
            ComboEstado.Location = new Point(472, 181);
            ComboEstado.Name = "ComboEstado";
            ComboEstado.Size = new Size(54, 20);
            ComboEstado.TabIndex = 32;
            ComboEstado.Text = "Estado";
            // 
            // ConsultarListaOrdenesRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(ComboBoxEstado);
            Controls.Add(ComboEstado);
            Controls.Add(TxtFecha);
            Controls.Add(label1);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(TxtPrioridad);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIDCliente);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIDOrdenesRecepcion);
            Controls.Add(LabelIDProducto);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConsultarListaOrdenesRecepcionForm";
            Text = "ConsultarListaOrdenesRecepcionForm";
            Load += ConsultarListaOrdenesRecepcionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonBuscar;
        private Button BotonVolver;
        private TextBox TxtPrioridad;
        private Label LabelEspacioDisponible;
        private TextBox TxtIDCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIDOrdenesRecepcion;
        private Label LabelIDProducto;
        private TextBox TxtFecha;
        private Label label1;
        private ComboBox ComboBoxEstado;
        private Label ComboEstado;
    }
}