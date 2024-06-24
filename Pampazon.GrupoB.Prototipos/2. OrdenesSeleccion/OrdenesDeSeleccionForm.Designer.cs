namespace Pampazon.GrupoB.Prototipos
{
    partial class OrdenesDeSeleccionForm
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
            BotonGenerarOrdenSeleccion = new Button();
            BotonListarOrdenesSeleccion = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // BotonGenerarOrdenSeleccion
            // 
            BotonGenerarOrdenSeleccion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonGenerarOrdenSeleccion.Location = new Point(415, 146);
            BotonGenerarOrdenSeleccion.Name = "BotonGenerarOrdenSeleccion";
            BotonGenerarOrdenSeleccion.Size = new Size(197, 158);
            BotonGenerarOrdenSeleccion.TabIndex = 12;
            BotonGenerarOrdenSeleccion.Text = "Crear orden de selección";
            BotonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            BotonGenerarOrdenSeleccion.Click += BotonGenerarOrdenSeleccion_Click;
            // 
            // BotonListarOrdenesSeleccion
            // 
            BotonListarOrdenesSeleccion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonListarOrdenesSeleccion.Location = new Point(188, 146);
            BotonListarOrdenesSeleccion.Name = "BotonListarOrdenesSeleccion";
            BotonListarOrdenesSeleccion.Size = new Size(197, 158);
            BotonListarOrdenesSeleccion.TabIndex = 11;
            BotonListarOrdenesSeleccion.Text = "Listar órdenes de selección";
            BotonListarOrdenesSeleccion.UseVisualStyleBackColor = true;
            BotonListarOrdenesSeleccion.Click += BotonListarOrdenesSeleccion_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(600, 415);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 13;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGenerarOrdenSeleccion);
            Controls.Add(BotonListarOrdenesSeleccion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OrdenesDeSeleccionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdenesDeSeleccion";
            Load += OrdenesDeSeleccionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonGenerarOrdenSeleccion;
        private Button BotonListarOrdenesSeleccion;
        private Button BotonVolver;
    }
}