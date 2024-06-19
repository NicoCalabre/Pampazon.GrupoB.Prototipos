namespace Pampazon.GrupoB.Prototipos
{
    partial class OrdenesDeEntregaForm
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
            BotonActualizarOrdenEntrega = new Button();
            BotonCrearOrdenEntrega = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // BotonActualizarOrdenEntrega
            // 
            BotonActualizarOrdenEntrega.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonActualizarOrdenEntrega.Location = new Point(593, 243);
            BotonActualizarOrdenEntrega.Margin = new Padding(4, 5, 4, 5);
            BotonActualizarOrdenEntrega.Name = "BotonActualizarOrdenEntrega";
            BotonActualizarOrdenEntrega.Size = new Size(281, 263);
            BotonActualizarOrdenEntrega.TabIndex = 14;
            BotonActualizarOrdenEntrega.Text = "Despachar órden de entrega";
            BotonActualizarOrdenEntrega.UseVisualStyleBackColor = true;
            BotonActualizarOrdenEntrega.Click += BotonActualizarOrdenEntrega_Click;
            // 
            // BotonCrearOrdenEntrega
            // 
            BotonCrearOrdenEntrega.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonCrearOrdenEntrega.Location = new Point(269, 243);
            BotonCrearOrdenEntrega.Margin = new Padding(4, 5, 4, 5);
            BotonCrearOrdenEntrega.Name = "BotonCrearOrdenEntrega";
            BotonCrearOrdenEntrega.Size = new Size(281, 263);
            BotonCrearOrdenEntrega.TabIndex = 13;
            BotonCrearOrdenEntrega.Text = "Crear órden de entrega";
            BotonCrearOrdenEntrega.UseVisualStyleBackColor = true;
            BotonCrearOrdenEntrega.Click += BotonCrearOrdenEntrega_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(857, 692);
            BotonVolver.Margin = new Padding(4, 5, 4, 5);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(269, 38);
            BotonVolver.TabIndex = 15;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 750);
            Controls.Add(BotonVolver);
            Controls.Add(BotonActualizarOrdenEntrega);
            Controls.Add(BotonCrearOrdenEntrega);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OrdenesDeEntregaForm";
            Text = "OrdenesDeEntrega";
            Load += OrdenesDeEntregaForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BotonActualizarOrdenEntrega;
        private Button BotonCrearOrdenEntrega;
        private Button BotonVolver;
    }
}