namespace Pampazon.GrupoB.Prototipos
{
    partial class CargarEntradaMercaderiaForms
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
            BotonLimpiar.Location = new Point(354, 523);
            BotonLimpiar.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(215, 31);
            BotonLimpiar.TabIndex = 29;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonCargar
            // 
            BotonCargar.Location = new Point(133, 523);
            BotonCargar.Margin = new Padding(3, 4, 3, 4);
            BotonCargar.Name = "BotonCargar";
            BotonCargar.Size = new Size(215, 31);
            BotonCargar.TabIndex = 28;
            BotonCargar.Text = "&Cargar";
            BotonCargar.UseVisualStyleBackColor = true;
            BotonCargar.Click += BotonCargar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(576, 523);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 27;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(462, 283);
            TxtFecha.Margin = new Padding(3, 4, 3, 4);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(242, 27);
            TxtFecha.TabIndex = 26;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(462, 259);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(47, 20);
            LabelEspacioDisponible.TabIndex = 25;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(462, 224);
            TxtCantidad.Margin = new Padding(3, 4, 3, 4);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(242, 27);
            TxtCantidad.TabIndex = 24;
            // 
            // LabelPosicion
            // 
            LabelPosicion.AutoSize = true;
            LabelPosicion.Location = new Point(462, 200);
            LabelPosicion.Name = "LabelPosicion";
            LabelPosicion.Size = new Size(69, 20);
            LabelPosicion.TabIndex = 23;
            LabelPosicion.Text = "Cantidad";
            // 
            // TxtIDProducto
            // 
            TxtIDProducto.Location = new Point(186, 283);
            TxtIDProducto.Margin = new Padding(3, 4, 3, 4);
            TxtIDProducto.Name = "TxtIDProducto";
            TxtIDProducto.Size = new Size(242, 27);
            TxtIDProducto.TabIndex = 22;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(186, 259);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(88, 20);
            LabelDescripcionProducto.TabIndex = 21;
            LabelDescripcionProducto.Text = "ID Producto";
            // 
            // TxtIDCliente
            // 
            TxtIDCliente.Location = new Point(186, 224);
            TxtIDCliente.Margin = new Padding(3, 4, 3, 4);
            TxtIDCliente.Name = "TxtIDCliente";
            TxtIDCliente.Size = new Size(242, 27);
            TxtIDCliente.TabIndex = 20;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(186, 200);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(74, 20);
            LabelIDProducto.TabIndex = 19;
            LabelIDProducto.Text = "ID Cliente";
            // 
            // CargarEntradaMercaderiaForms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "CargarEntradaMercaderiaForms";
            Text = "CargarEntradaMercaderiaForms";
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