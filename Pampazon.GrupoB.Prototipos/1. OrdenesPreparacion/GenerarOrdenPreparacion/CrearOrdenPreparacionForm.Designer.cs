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
            TxtFecha = new TextBox();
            LabelEspacioDisponible = new Label();
            TxtIdProducto = new TextBox();
            LabelPosicion = new Label();
            TxtIdCliente = new TextBox();
            LabelDescripcionProducto = new Label();
            TxtIdOrdenPreparacion = new TextBox();
            LabelIDProducto = new Label();
            TxtCantidad = new TextBox();
            label1 = new Label();
            TxtPrioridad = new TextBox();
            label2 = new Label();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(277, 525);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(188, 23);
            BotonLimpiar.TabIndex = 51;
            BotonLimpiar.Text = "&Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click_1;
            // 
            // BotonCrear
            // 
            BotonCrear.Location = new Point(83, 525);
            BotonCrear.Name = "BotonCrear";
            BotonCrear.Size = new Size(188, 23);
            BotonCrear.TabIndex = 50;
            BotonCrear.Text = "&Crear";
            BotonCrear.UseVisualStyleBackColor = true;
            BotonCrear.Click += BotonCrear_Click_1;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(471, 525);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 49;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(196, 27);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(173, 23);
            TxtFecha.TabIndex = 48;
            // 
            // LabelEspacioDisponible
            // 
            LabelEspacioDisponible.AutoSize = true;
            LabelEspacioDisponible.Location = new Point(196, 9);
            LabelEspacioDisponible.Name = "LabelEspacioDisponible";
            LabelEspacioDisponible.Size = new Size(38, 15);
            LabelEspacioDisponible.TabIndex = 47;
            LabelEspacioDisponible.Text = "Fecha";
            // 
            // TxtIdProducto
            // 
            TxtIdProducto.Location = new Point(11, 409);
            TxtIdProducto.Name = "TxtIdProducto";
            TxtIdProducto.Size = new Size(172, 23);
            TxtIdProducto.TabIndex = 46;
            // 
            // LabelPosicion
            // 
            LabelPosicion.AutoSize = true;
            LabelPosicion.Location = new Point(11, 391);
            LabelPosicion.Name = "LabelPosicion";
            LabelPosicion.Size = new Size(70, 15);
            LabelPosicion.TabIndex = 45;
            LabelPosicion.Text = "ID Producto";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(380, 27);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(173, 23);
            TxtIdCliente.TabIndex = 44;
            // 
            // LabelDescripcionProducto
            // 
            LabelDescripcionProducto.AutoSize = true;
            LabelDescripcionProducto.Location = new Point(380, 9);
            LabelDescripcionProducto.Name = "LabelDescripcionProducto";
            LabelDescripcionProducto.Size = new Size(58, 15);
            LabelDescripcionProducto.TabIndex = 43;
            LabelDescripcionProducto.Text = "ID Cliente";
            // 
            // TxtIdOrdenPreparacion
            // 
            TxtIdOrdenPreparacion.Location = new Point(11, 27);
            TxtIdOrdenPreparacion.Name = "TxtIdOrdenPreparacion";
            TxtIdOrdenPreparacion.Size = new Size(173, 23);
            TxtIdOrdenPreparacion.TabIndex = 42;
            // 
            // LabelIDProducto
            // 
            LabelIDProducto.AutoSize = true;
            LabelIDProducto.Location = new Point(12, 9);
            LabelIDProducto.Name = "LabelIDProducto";
            LabelIDProducto.Size = new Size(120, 15);
            LabelIDProducto.TabIndex = 41;
            LabelIDProducto.Text = "ID Orden Preparación";
            // 
            // TxtCantidad
            // 
            TxtCantidad.Location = new Point(196, 409);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(172, 23);
            TxtCantidad.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 391);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 54;
            label1.Text = "Cantidad";
            // 
            // TxtPrioridad
            // 
            TxtPrioridad.Location = new Point(564, 27);
            TxtPrioridad.Name = "TxtPrioridad";
            TxtPrioridad.Size = new Size(173, 23);
            TxtPrioridad.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(564, 9);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 52;
            label2.Text = "Prioridad";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 98);
            listView1.Name = "listView1";
            listView1.Size = new Size(725, 269);
            listView1.TabIndex = 56;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(591, 409);
            button1.Name = "button1";
            button1.Size = new Size(146, 23);
            button1.TabIndex = 57;
            button1.Text = "Eliminar Producto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(439, 409);
            button2.Name = "button2";
            button2.Size = new Size(146, 23);
            button2.TabIndex = 58;
            button2.Text = "Agregar Producto";
            button2.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(754, 572);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(TxtCantidad);
            Controls.Add(label1);
            Controls.Add(TxtPrioridad);
            Controls.Add(label2);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonCrear);
            Controls.Add(BotonVolver);
            Controls.Add(TxtFecha);
            Controls.Add(LabelEspacioDisponible);
            Controls.Add(TxtIdProducto);
            Controls.Add(LabelPosicion);
            Controls.Add(TxtIdCliente);
            Controls.Add(LabelDescripcionProducto);
            Controls.Add(TxtIdOrdenPreparacion);
            Controls.Add(LabelIDProducto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CrearOrdenPreparacionForm";
            Text = "CrearOrdenPreparacionForm";
            Load += CrearOrdenPreparacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonCrear;
        private Button BotonVolver;
        private TextBox TxtFecha;
        private Label LabelEspacioDisponible;
        private TextBox TxtIdProducto;
        private Label LabelPosicion;
        private TextBox TxtIdCliente;
        private Label LabelDescripcionProducto;
        private TextBox TxtIdOrdenPreparacion;
        private Label LabelIDProducto;
        private TextBox TxtCantidad;
        private Label label1;
        private TextBox TxtPrioridad;
        private Label label2;
        private ListView listView1;
        private Button button1;
        private Button button2;
    }
}