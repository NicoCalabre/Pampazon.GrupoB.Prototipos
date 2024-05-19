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
            BotonGenerarOrdenSeleccion.Location = new Point(474, 195);
            BotonGenerarOrdenSeleccion.Margin = new Padding(3, 4, 3, 4);
            BotonGenerarOrdenSeleccion.Name = "BotonGenerarOrdenSeleccion";
            BotonGenerarOrdenSeleccion.Size = new Size(225, 211);
            BotonGenerarOrdenSeleccion.TabIndex = 12;
            BotonGenerarOrdenSeleccion.Text = "Generar órden de selección";
            BotonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            BotonGenerarOrdenSeleccion.Click += BotonGenerarOrdenSeleccion_Click;
            // 
            // BotonListarOrdenesSeleccion
            // 
            BotonListarOrdenesSeleccion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonListarOrdenesSeleccion.Location = new Point(215, 195);
            BotonListarOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            BotonListarOrdenesSeleccion.Name = "BotonListarOrdenesSeleccion";
            BotonListarOrdenesSeleccion.Size = new Size(225, 211);
            BotonListarOrdenesSeleccion.TabIndex = 11;
            BotonListarOrdenesSeleccion.Text = "Listar órdenes de selección";
            BotonListarOrdenesSeleccion.UseVisualStyleBackColor = true;
            BotonListarOrdenesSeleccion.Click += BotonListarOrdenesSeleccion_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(686, 553);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 13;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonVolver);
            Controls.Add(BotonGenerarOrdenSeleccion);
            Controls.Add(BotonListarOrdenesSeleccion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenesDeSeleccionForm";
            Text = "OrdenesDeSeleccion";
            ResumeLayout(false);
        }

        #endregion

        private Button BotonGenerarOrdenSeleccion;
        private Button BotonListarOrdenesSeleccion;
        private Button BotonVolver;
    }
}