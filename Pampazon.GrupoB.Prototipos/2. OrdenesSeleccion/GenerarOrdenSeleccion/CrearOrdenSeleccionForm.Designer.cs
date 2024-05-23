namespace Pampazon.GrupoB.Prototipos
{
    partial class CrearOrdenSeleccionForm
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
            BotonListar = new Button();
            BotonVolver = new Button();
            TxtPrioridad = new TextBox();
            LabelPrioridad = new Label();
            TxtIdCliente = new TextBox();
            LabelIdCliente = new Label();
            TxtIdOrdenPreparacion = new TextBox();
            LabelIdOrdenPreparacion = new Label();
            TxtFecha = new TextBox();
            LabelFecha = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            listBox3 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Location = new Point(374, 544);
            BotonLimpiar.Margin = new Padding(3, 4, 3, 4);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(215, 31);
            BotonLimpiar.TabIndex = 51;
            BotonLimpiar.Text = "Generar Orden de Selección";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonListar
            // 
            BotonListar.Location = new Point(512, 36);
            BotonListar.Margin = new Padding(3, 4, 3, 4);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(215, 31);
            BotonListar.TabIndex = 50;
            BotonListar.Text = "Buscar";
            BotonListar.UseVisualStyleBackColor = true;
            BotonListar.Click += BotonListar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(734, 957);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 49;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // TxtPrioridad
            // 
            TxtPrioridad.Location = new Point(262, 96);
            TxtPrioridad.Margin = new Padding(3, 4, 3, 4);
            TxtPrioridad.Name = "TxtPrioridad";
            TxtPrioridad.Size = new Size(242, 27);
            TxtPrioridad.TabIndex = 48;
            // 
            // LabelPrioridad
            // 
            LabelPrioridad.AutoSize = true;
            LabelPrioridad.ForeColor = SystemColors.ActiveCaptionText;
            LabelPrioridad.Location = new Point(262, 72);
            LabelPrioridad.Name = "LabelPrioridad";
            LabelPrioridad.Size = new Size(70, 20);
            LabelPrioridad.TabIndex = 47;
            LabelPrioridad.Text = "Prioridad";
            // 
            // TxtIdCliente
            // 
            TxtIdCliente.Location = new Point(14, 36);
            TxtIdCliente.Margin = new Padding(3, 4, 3, 4);
            TxtIdCliente.Name = "TxtIdCliente";
            TxtIdCliente.Size = new Size(242, 27);
            TxtIdCliente.TabIndex = 44;
            // 
            // LabelIdCliente
            // 
            LabelIdCliente.AutoSize = true;
            LabelIdCliente.ForeColor = SystemColors.ActiveCaptionText;
            LabelIdCliente.Location = new Point(14, 12);
            LabelIdCliente.Name = "LabelIdCliente";
            LabelIdCliente.Size = new Size(74, 20);
            LabelIdCliente.TabIndex = 43;
            LabelIdCliente.Text = "ID Cliente";
            // 
            // TxtIdOrdenPreparacion
            // 
            TxtIdOrdenPreparacion.Location = new Point(14, 96);
            TxtIdOrdenPreparacion.Margin = new Padding(3, 4, 3, 4);
            TxtIdOrdenPreparacion.Name = "TxtIdOrdenPreparacion";
            TxtIdOrdenPreparacion.Size = new Size(242, 27);
            TxtIdOrdenPreparacion.TabIndex = 42;
            // 
            // LabelIdOrdenPreparacion
            // 
            LabelIdOrdenPreparacion.AutoSize = true;
            LabelIdOrdenPreparacion.ForeColor = SystemColors.ActiveCaptionText;
            LabelIdOrdenPreparacion.Location = new Point(14, 72);
            LabelIdOrdenPreparacion.Name = "LabelIdOrdenPreparacion";
            LabelIdOrdenPreparacion.Size = new Size(152, 20);
            LabelIdOrdenPreparacion.TabIndex = 41;
            LabelIdOrdenPreparacion.Text = "ID Orden Preparación";
            // 
            // TxtFecha
            // 
            TxtFecha.Location = new Point(263, 37);
            TxtFecha.Margin = new Padding(3, 4, 3, 4);
            TxtFecha.Name = "TxtFecha";
            TxtFecha.Size = new Size(242, 27);
            TxtFecha.TabIndex = 55;
            // 
            // LabelFecha
            // 
            LabelFecha.AutoSize = true;
            LabelFecha.ForeColor = SystemColors.ActiveCaptionText;
            LabelFecha.Location = new Point(263, 13);
            LabelFecha.Name = "LabelFecha";
            LabelFecha.Size = new Size(47, 20);
            LabelFecha.TabIndex = 54;
            LabelFecha.Text = "Fecha";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(14, 216);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(382, 304);
            listBox1.TabIndex = 56;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(566, 216);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(382, 304);
            listBox2.TabIndex = 57;
            // 
            // button1
            // 
            button1.Location = new Point(403, 343);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(155, 31);
            button1.TabIndex = 58;
            button1.Text = "->";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(403, 381);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(155, 31);
            button2.TabIndex = 59;
            button2.Text = "<-";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(14, 583);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(934, 344);
            listBox3.TabIndex = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 277);
            label1.Name = "label1";
            label1.Size = new Size(246, 20);
            label1.TabIndex = 61;
            label1.Text = "Ordenes de preparación pendientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 277);
            label2.Name = "label2";
            label2.Size = new Size(397, 20);
            label2.TabIndex = 62;
            label2.Text = "Orden de preparación incluidas en esta orden de selección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 617);
            label3.Name = "label3";
            label3.Size = new Size(453, 20);
            label3.TabIndex = 63;
            label3.Text = "Detalle de la orden de selección. Es una lista de producto/cantidad";
            // 
            // button3
            // 
            button3.Location = new Point(734, 36);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(215, 31);
            button3.TabIndex = 64;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(512, 957);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(215, 31);
            button4.TabIndex = 65;
            button4.Text = "Limpiar";
            button4.UseVisualStyleBackColor = true;
            // 
            // CrearOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(985, 1003);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(TxtFecha);
            Controls.Add(LabelFecha);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonListar);
            Controls.Add(BotonVolver);
            Controls.Add(TxtPrioridad);
            Controls.Add(LabelPrioridad);
            Controls.Add(TxtIdCliente);
            Controls.Add(LabelIdCliente);
            Controls.Add(TxtIdOrdenPreparacion);
            Controls.Add(LabelIdOrdenPreparacion);
            Name = "CrearOrdenSeleccionForm";
            Text = "CrearOrdenSeleccionForm";
            Load += CrearOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonLimpiar;
        private Button BotonListar;
        private Button BotonVolver;
        private TextBox TxtPrioridad;
        private Label LabelPrioridad;
        private TextBox TxtIdCliente;
        private Label LabelIdCliente;
        private TextBox TxtIdOrdenPreparacion;
        private Label LabelIdOrdenPreparacion;
        private TextBox TxtFecha;
        private Label LabelFecha;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button4;
    }
}