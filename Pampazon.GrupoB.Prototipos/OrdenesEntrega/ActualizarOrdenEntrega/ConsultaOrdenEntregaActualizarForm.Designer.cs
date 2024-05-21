namespace Pampazon.GrupoB.Prototipos
{
    partial class ConsultaOrdenEntregaActualizarForm
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
            ComboBoxEstado = new ComboBox();
            BotonLimpiar = new Button();
            BotonBuscar = new Button();
            BotonVolver = new Button();
            TxtFecha = new TextBox();
            LabelEspacioDisponible = new Label();
            LabelEstado = new Label();
            TxtIdOrdenSeleccion = new TextBox();
            LabelIdOrdenEntrega = new Label();
            SuspendLayout();
            // 
            // ComboBoxEstado
            // 
            ComboBoxEstado.FormattingEnabled = true;
            ComboBoxEstado.Location = new Point(405, 116);
            ComboBoxEstado.Name = "ComboBoxEstado";
            ComboBoxEstado.Size = new Size(242, 28);
            ComboBoxEstado.TabIndex = 80;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(293, 326);
            BotonLimpiar.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(215, 31);
            BotonLimpiar.TabIndex = 77;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonBuscar
            // 
            BotonBuscar.Location = new Point(71, 326);
            BotonBuscar.Margin = new Padding(3, 4, 3, 4);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(215, 31);
            BotonBuscar.TabIndex = 76;
            BotonBuscar.Text = "&Buscar";
            BotonBuscar.UseVisualStyleBackColor = true;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(515, 326);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 75;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(133, 176);
            TxtFecha.Margin = new Padding(3, 4, 3, 4);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(514, 27);
            TxtFecha.TabIndex = 74;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(133, 152);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(47, 20);
            LabelEspacioDisponible.TabIndex = 73;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(405, 93);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(54, 20);
            LabelEstado.TabIndex = 72;
            LabelEstado.Text = "Estado";
            // 
            // TxtIdOrdenSeleccion
            // 
            TxtIdOrdenSeleccion.Location = new Point(133, 117);
            TxtIdOrdenSeleccion.Margin = new Padding(3, 4, 3, 4);
            TxtIdOrdenSeleccion.Name = "TxtIdOrdenSeleccion";
            TxtIdOrdenSeleccion.Size = new Size(242, 27);
            TxtIdOrdenSeleccion.TabIndex = 71;
            // 
            // LabelIdOrdenEntrega
            // 
            LabelIdOrdenEntrega.AutoSize = true;
            LabelIdOrdenEntrega.Location = new Point(134, 93);
            LabelIdOrdenEntrega.Name = "LabelIdOrdenEntrega";
            LabelIdOrdenEntrega.Size = new Size(145, 20);
            LabelIdOrdenEntrega.TabIndex = 70;
            LabelIdOrdenEntrega.Text = "ID Orden de Entrega";
            // 
            // ActualizarOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(ComboBoxEstado);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonBuscar);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(LabelEstado);
            Controls.Add(TxtIdOrdenSeleccion);
            Controls.Add(LabelIdOrdenEntrega);
            Name = "ActualizarOrdenEntregaForm";
            Text = "ActualizarOrdenEntregaForm";
            Load += ActualizarOrdenEntregaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBoxEstado;
        private Button BotonLimpiar;
        private Button BotonBuscar;
        private Button BotonVolver;
        private TextBox TxtFecha;
        private Label LabelEspacioDisponible;
        private Label LabelEstado;
        private TextBox TxtIdOrdenSeleccion;
        private Label LabelIdOrdenEntrega;
    }
}