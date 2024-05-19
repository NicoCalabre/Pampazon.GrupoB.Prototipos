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
            TxtPrioridad = new TextBox();
            label2 = new Label();
            BotonLimpiar = new Button();
            BotonCrear = new Button();
            BotonVolver = new Button();
            TxtFecha = new TextBox();
            LabelEspacioDisponible = new Label();
            LabelEstado = new Label();
            TxtIdOrdenSeleccion = new TextBox();
            LabelIDProducto = new Label();
            ComboBoxEstado = new ComboBox();
            SuspendLayout();
            // 
            // TxtPrioridad
            // 
            TxtPrioridad.Location = new Point(405, 211);
            TxtPrioridad.Margin = new Padding(3, 4, 3, 4);
            TxtPrioridad.Name = "TxtPrioridad";
            TxtPrioridad.Size = new Size(242, 27);
            TxtPrioridad.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 187);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 67;
            label2.Text = "Prioridad";
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(293, 361);
            BotonLimpiar.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(215, 31);
            BotonLimpiar.TabIndex = 66;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(71, 361);
            BotonCrear.Margin = new Padding(3, 4, 3, 4);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(215, 31);
            BotonCrear.TabIndex = 65;
            BotonCrear.Text = "&Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            BotonCrear.Click += BotonCrear_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(515, 361);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 64;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(133, 211);
            TxtFecha.Margin = new Padding(3, 4, 3, 4);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(242, 27);
            TxtFecha.TabIndex = 63;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(133, 187);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(47, 20);
            LabelEspacioDisponible.TabIndex = 62;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(405, 128);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(54, 20);
            LabelEstado.TabIndex = 58;
            LabelEstado.Text = "Estado";
            // 
            // TxtIdOrdenSeleccion
            // 
            TxtIdOrdenSeleccion.Location = new Point(133, 152);
            TxtIdOrdenSeleccion.Margin = new Padding(3, 4, 3, 4);
            TxtIdOrdenSeleccion.Name = "TxtIdOrdenSeleccion";
            TxtIdOrdenSeleccion.Size = new Size(242, 27);
            TxtIdOrdenSeleccion.TabIndex = 57;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(134, 128);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(136, 20);
            LabelIDProducto.TabIndex = 56;
            LabelIDProducto.Text = "ID Orden Selección";
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(405, 151);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(242, 28);
            ComboBoxEstado.TabIndex = 69;
            // 
            // CrearOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ComboBoxEstado);
            Controls.Add(TxtPrioridad);
            Controls.Add(label2);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCrear);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(LabelEstado);
            Controls.Add(TxtIdOrdenSeleccion);
            Controls.Add(LabelIDProducto);
            Name = "CrearOrdenEntregaForm";
            Text = "CrearOrdenEntregaForm";
            Load += CrearOrdenEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCantidad;
        private Label label1;
        private TextBox TxtPrioridad;
        private Label label2;
        private Button BotonLimpiar;
        private Button BotonCrear;
        private Button BotonVolver;
        private TextBox TxtFecha;
        private Label LabelEspacioDisponible;
        private TextBox TxtIdProducto;
        private Label LabelPosicion;
        private TextBox TxtIdCliente;
        private Label LabelEstado;
        private TextBox TxtIdOrdenSeleccion;
        private Label LabelIDProducto;
        private ComboBox ComboBoxEstado;
    }
}