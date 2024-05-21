namespace Pampazon.GrupoB.Prototipos
{
    partial class CrearOrdenRecepcionForm
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
            BotonCargar = new Button();
            BotonVolver = new Button();
            TxtFecha = new TextBox();
            LabelEspacioDisponible = new Label();
            TxtIdProducto = new TextBox();
            LabelPosicion = new Label();
            TxtIdCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIdOrdenRecepcion = new TextBox();
            LabelIDProducto = new Label();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(309, 397);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 40;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonCargar
            // 
            BotonCargar.Location = new Point(115, 397);
            BotonCargar.Name = "BotonCargar";
            BotonCargar.Size = new Size(188, 23);
            BotonCargar.TabIndex = 39;
            BotonCargar.Text = "&Cargar";
            BotonCargar.UseVisualStyleBackColor = true;
            BotonCargar.Click += BotonCargar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(503, 397);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 38;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(407, 218);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(212, 23);
            TxtFecha.TabIndex = 37;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(407, 200);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(38, 15);
            LabelEspacioDisponible.TabIndex = 36;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // TxtIdProducto
            // 
            TxtIdProducto.Location = new Point(407, 174);
            TxtIdProducto.Name = "TxtIdProducto";
            TxtIdProducto.Size = new Size(212, 23);
            TxtIdProducto.TabIndex = 35;
            // 
            // LabelPosicion
            // 
            LabelPosicion.AutoSize = true;
            LabelPosicion.Location = new Point(407, 156);
            LabelPosicion.Name = "LabelPosicion";
            LabelPosicion.Size = new Size(70, 15);
            LabelPosicion.TabIndex = 34;
            LabelPosicion.Text = "ID Producto";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(166, 218);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(212, 23);
            TxtIdCliente.TabIndex = 33;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(166, 200);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 32;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenRecepcion
            // 
            TxtIdOrdenRecepcion.Location = new Point(166, 174);
            TxtIdOrdenRecepcion.Name = "TxtIdOrdenRecepcion";
            TxtIdOrdenRecepcion.Size = new Size(212, 23);
            TxtIdOrdenRecepcion.TabIndex = 31;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(166, 156);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(112, 15);
            LabelIDProducto.TabIndex = 30;
            LabelIDProducto.Text = "ID Orden Recepción";
            // 
            // CrearOrdenRecepcionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCargar);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIdProducto);
            Controls.Add(LabelPosicion);
            Controls.Add(TxtIdCliente);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIdOrdenRecepcion);
            Controls.Add(LabelIDProducto);
            Name = "CrearOrdenRecepcionForm";
            Text = "CrearOrdenRecepcionForm";
            Load += CrearOrdenRecepcionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonCargar;
        private Button BotonVolver;
        private TextBox TxtFecha;
        private Label LabelEspacioDisponible;
        private TextBox TxtIdProducto;
        private Label LabelPosicion;
        private TextBox TxtIdCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIdOrdenRecepcion;
        private Label LabelIDProducto;
    }
}