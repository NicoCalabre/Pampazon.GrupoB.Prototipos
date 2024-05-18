namespace Pampazon.GrupoB.Prototipos
{
    partial class CargarEgresoMercaderiaForm
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
            TxtCantidad = new TextBox();
            LabelPosicion = new Label();
            TxtIDProducto = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIDCliente = new TextBox();
            LabelIDProducto = new Label();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(320, 382);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 40;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonCargar
            // 
            BotonCargar.Location = new Point(126, 382);
            BotonCargar.Name = "BotonCargar";
            BotonCargar.Size = new Size(188, 23);
            BotonCargar.TabIndex = 39;
            BotonCargar.Text = "&Cargar";
            BotonCargar.UseVisualStyleBackColor = true;
            BotonCargar.Click += BotonCargar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(514, 382);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 38;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(414, 202);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(212, 23);
            TxtFecha.TabIndex = 37;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(414, 184);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(38, 15);
            LabelEspacioDisponible.TabIndex = 36;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(414, 158);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(212, 23);
            TxtCantidad.TabIndex = 35;
            // 
            // LabelPosicion
            // 
            LabelPosicion.AutoSize = true;
            LabelPosicion.Location = new Point(414, 140);
            LabelPosicion.Name = "LabelPosicion";
            LabelPosicion.Size = new Size(55, 15);
            LabelPosicion.TabIndex = 34;
            LabelPosicion.Text = "Cantidad";
            // 
            // TxtIDProducto
            // 
            TxtIDProducto.Location = new Point(173, 202);
            TxtIDProducto.Name = "TxtIDProducto";
            TxtIDProducto.Size = new Size(212, 23);
            TxtIDProducto.TabIndex = 33;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(173, 184);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(70, 15);
            LabelDescripcionProducto.TabIndex = 32;
            LabelDescripcionProducto.Text = "ID Producto";
            // 
            // TxtIDCliente
            // 
            TxtIDCliente.Location = new Point(173, 158);
            TxtIDCliente.Name = "TxtIDCliente";
            TxtIDCliente.Size = new Size(212, 23);
            TxtIDCliente.TabIndex = 31;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(173, 140);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(58, 15);
            LabelIDProducto.TabIndex = 30;
            LabelIDProducto.Text = "ID Cliente";
            // 
            // CargarEgresoMercaderiaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCargar);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtCantidad);
            Controls.Add(LabelPosicion);
            Controls.Add(TxtIDProducto);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIDCliente);
            Controls.Add(LabelIDProducto);
            Name = "CargarEgresoMercaderiaForm";
            Text = "CargarEgresoMercaderiaForm";
            Load += CargarEgresoMercaderiaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonCargar;
        private Button BotonVolver;
        private TextBox TxtFecha;
        private Label LabelEspacioDisponible;
        private TextBox TxtCantidad;
        private Label LabelPosicion;
        private TextBox TxtIDProducto;
        private Label LabelDescripcionProducto;
        private TextBox TxtIDCliente;
        private Label LabelIDProducto;
    }
}