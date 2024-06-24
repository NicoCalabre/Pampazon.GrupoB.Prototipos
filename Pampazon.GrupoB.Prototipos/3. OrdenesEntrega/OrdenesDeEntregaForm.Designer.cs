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
            BotonActualizarOrdenEntrega.Location = new Point(415, 146);
            BotonActualizarOrdenEntrega.Name = "BotonActualizarOrdenEntrega";
            BotonActualizarOrdenEntrega.Size = new Size(197, 158);
            BotonActualizarOrdenEntrega.TabIndex = 14;
            BotonActualizarOrdenEntrega.Text = "Despachar órden de entrega";
            BotonActualizarOrdenEntrega.UseVisualStyleBackColor = true;
            BotonActualizarOrdenEntrega.Click += BotonActualizarOrdenEntrega_Click;
            // 
            // BotonCrearOrdenEntrega
            // 
            BotonCrearOrdenEntrega.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonCrearOrdenEntrega.Location = new Point(188, 146);
            BotonCrearOrdenEntrega.Name = "BotonCrearOrdenEntrega";
            BotonCrearOrdenEntrega.Size = new Size(197, 158);
            BotonCrearOrdenEntrega.TabIndex = 13;
            BotonCrearOrdenEntrega.Text = "Crear órden de entrega";
            BotonCrearOrdenEntrega.UseVisualStyleBackColor = true;
            BotonCrearOrdenEntrega.Click += BotonCrearOrdenEntrega_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(600, 415);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 15;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // OrdenesDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonActualizarOrdenEntrega);
            Controls.Add(BotonCrearOrdenEntrega);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OrdenesDeEntregaForm";
            StartPosition = FormStartPosition.CenterScreen;
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