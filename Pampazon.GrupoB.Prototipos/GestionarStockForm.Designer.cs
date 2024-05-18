namespace Pampazon.GrupoB.Prototipos
{
    partial class GestionarStockForm
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
            BotonEgresoMercaderia = new Button();
            BotonEntradaMercaderia = new Button();
            BotonConsultarStock = new Button();
            BotonVolver = new Button();
            SuspendLayout();
            // 
            // BotonEgresoMercaderia
            // 
            BotonEgresoMercaderia.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonEgresoMercaderia.Location = new Point(538, 130);
            BotonEgresoMercaderia.Name = "BotonEgresoMercaderia";
            BotonEgresoMercaderia.Size = new Size(197, 158);
            BotonEgresoMercaderia.TabIndex = 5;
            BotonEgresoMercaderia.Text = "Cargar Egreso de Mercadería";
            BotonEgresoMercaderia.UseVisualStyleBackColor = true;
            // 
            // BotonEntradaMercaderia
            // 
            BotonEntradaMercaderia.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonEntradaMercaderia.Location = new Point(305, 130);
            BotonEntradaMercaderia.Name = "BotonEntradaMercaderia";
            BotonEntradaMercaderia.Size = new Size(197, 158);
            BotonEntradaMercaderia.TabIndex = 4;
            BotonEntradaMercaderia.Text = "Cargar entrada de mercadería";
            BotonEntradaMercaderia.UseVisualStyleBackColor = true;
            // 
            // BotonConsultarStock
            // 
            BotonConsultarStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonConsultarStock.Location = new Point(78, 130);
            BotonConsultarStock.Name = "BotonConsultarStock";
            BotonConsultarStock.Size = new Size(197, 158);
            BotonConsultarStock.TabIndex = 3;
            BotonConsultarStock.Text = "Consultar Stock";
            BotonConsultarStock.UseVisualStyleBackColor = true;
            BotonConsultarStock.Click += BotonConsultarStock_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(600, 415);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(188, 23);
            BotonVolver.TabIndex = 6;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // GestionarStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEgresoMercaderia);
            Controls.Add(BotonEntradaMercaderia);
            Controls.Add(BotonConsultarStock);
            Name = "GestionarStockForm";
            Text = "GestionarStock";
            ResumeLayout(false);
        }

        #endregion

        private Button BotonEgresoMercaderia;
        private Button BotonEntradaMercaderia;
        private Button BotonConsultarStock;
        private Button BotonVolver;
    }
}