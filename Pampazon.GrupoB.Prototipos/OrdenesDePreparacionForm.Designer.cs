namespace Pampazon.GrupoB.Prototipos
{
    partial class OrdenesDePreparacionForm
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
            BotonGenerarOrdenPreparacion = new Button();
            BotonListarOrdenesPreparacion = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // BotonGenerarOrdenPreparacion
            // 
            BotonGenerarOrdenPreparacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonGenerarOrdenPreparacion.Location = new Point(479, 191);
            BotonGenerarOrdenPreparacion.Margin = new Padding(3, 4, 3, 4);
            BotonGenerarOrdenPreparacion.Name = "BotonGenerarOrdenPreparacion";
            BotonGenerarOrdenPreparacion.Size = new Size(225, 211);
            BotonGenerarOrdenPreparacion.TabIndex = 10;
            BotonGenerarOrdenPreparacion.Text = "Generar orden de preparación";
            BotonGenerarOrdenPreparacion.UseVisualStyleBackColor = true;
            BotonGenerarOrdenPreparacion.Click += BotonGenerarOrdenPreparacion_Click;
            // 
            // BotonListarOrdenesPreparacion
            // 
            BotonListarOrdenesPreparacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonListarOrdenesPreparacion.Location = new Point(219, 191);
            BotonListarOrdenesPreparacion.Margin = new Padding(3, 4, 3, 4);
            BotonListarOrdenesPreparacion.Name = "BotonListarOrdenesPreparacion";
            BotonListarOrdenesPreparacion.Size = new Size(225, 211);
            BotonListarOrdenesPreparacion.TabIndex = 9;
            BotonListarOrdenesPreparacion.Text = "Listar órdenes de preparación";
            BotonListarOrdenesPreparacion.UseVisualStyleBackColor = true;
            BotonListarOrdenesPreparacion.Click += BotonListarOrdenesPreparacion_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(686, 553);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 11;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGenerarOrdenPreparacion);
            Controls.Add(BotonListarOrdenesPreparacion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenesDePreparacionForm";
            Text = "OrdenesDePreparacion";
            ResumeLayout(false);
        }

        #endregion

        private Button BotonGenerarOrdenPreparacion;
        private Button BotonListarOrdenesPreparacion;
        private Button BotonVolver;
    }
}