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
            BotonLimpiar.Location = new Point(309, 400);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 29;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(115, 400);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(188, 23);
            BotonBuscar.TabIndex = 28;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(503, 400);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 27;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtPrioridad
            // 
            TxtPrioridad.Location = new Point(413, 198);
            TxtPrioridad.Name = "TxtPrioridad";
            TxtPrioridad.Size = new Size(212, 23);
            TxtPrioridad.TabIndex = 26;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(413, 180);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(55, 15);
            LabelEspacioDisponible.TabIndex = 25;
            LabelEspacioDisponible.Text = "Prioridad";
            // 
            // TxtIDCliente
            // 
            TxtIDCliente.Location = new Point(172, 198);
            TxtIDCliente.Name = "TxtIDCliente";
            TxtIDCliente.Size = new Size(212, 23);
            TxtIDCliente.TabIndex = 22;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(172, 180);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 21;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIDOrdenesRecepcion
            // 
            TxtIDOrdenesRecepcion.Location = new Point(172, 154);
            TxtIDOrdenesRecepcion.Name = "TxtIDOrdenesRecepcion";
            TxtIDOrdenesRecepcion.Size = new Size(212, 23);
            TxtIDOrdenesRecepcion.TabIndex = 20;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(172, 136);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(123, 15);
            LabelIDProducto.TabIndex = 19;
            LabelIDProducto.Text = "ID Órdenes Recepción";
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(172, 251);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(453, 23);
            TxtFecha.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 233);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 30;
            label1.Text = "Fecha";
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(413, 154);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(212, 23);
            ComboBoxEstado.TabIndex = 33;
            // 
            // ComboEstado
            // 
            ComboEstado.AutoSize = true;
            ComboEstado.Location = new Point(413, 136);
            ComboEstado.Name = "ComboEstado";
            ComboEstado.Size = new Size(42, 15);
            ComboEstado.TabIndex = 32;
            ComboEstado.Text = "Estado";
            // 
            // ConsultarListaOrdenesRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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