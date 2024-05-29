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
            BotonGenerarOrdenPreparacion.Location = new Point(419, 143);
            BotonGenerarOrdenPreparacion.Name = "BotonGenerarOrdenPreparacion";
            BotonGenerarOrdenPreparacion.Size = new Size(197, 158);
            BotonGenerarOrdenPreparacion.TabIndex = 10;
            BotonGenerarOrdenPreparacion.Text = "Generar orden de preparación";
            BotonGenerarOrdenPreparacion.UseVisualStyleBackColor = true;
            BotonGenerarOrdenPreparacion.Click += BotonGenerarOrdenPreparacion_Click;
            // 
            // BotonListarOrdenesPreparacion
            // 
            BotonListarOrdenesPreparacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonListarOrdenesPreparacion.Location = new Point(192, 143);
            BotonListarOrdenesPreparacion.Name = "BotonListarOrdenesPreparacion";
            BotonListarOrdenesPreparacion.Size = new Size(197, 158);
            BotonListarOrdenesPreparacion.TabIndex = 9;
            BotonListarOrdenesPreparacion.Text = "Listar órdenes de preparación";
            BotonListarOrdenesPreparacion.UseVisualStyleBackColor = true;
            BotonListarOrdenesPreparacion.Click += BotonListarOrdenesPreparacion_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(600, 415);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 11;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGenerarOrdenPreparacion);
            Controls.Add(BotonListarOrdenesPreparacion);
            Name = "OrdenesDePreparacionForm";
            Text = "OrdenesDePreparacion";
            Load += OrdenesDePreparacionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonGenerarOrdenPreparacion;
        private Button BotonListarOrdenesPreparacion;
        private Button BotonVolver;
    }
}