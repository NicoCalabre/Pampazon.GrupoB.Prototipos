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
            BotonEgresoMercaderia.Location = new Point(615, 173);
            BotonEgresoMercaderia.Margin = new Padding(3, 4, 3, 4);
            BotonEgresoMercaderia.Name = "BotonEgresoMercaderia";
            BotonEgresoMercaderia.Size = new Size(225, 211);
            BotonEgresoMercaderia.TabIndex = 5;
            BotonEgresoMercaderia.Text = "Cargar Egreso de Mercadería";
            BotonEgresoMercaderia.UseVisualStyleBackColor = true;
            BotonEgresoMercaderia.Click += BotonEgresoMercaderia_Click;
            // 
            // BotonEntradaMercaderia
            // 
            BotonEntradaMercaderia.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonEntradaMercaderia.Location = new Point(349, 173);
            BotonEntradaMercaderia.Margin = new Padding(3, 4, 3, 4);
            BotonEntradaMercaderia.Name = "BotonEntradaMercaderia";
            BotonEntradaMercaderia.Size = new Size(225, 211);
            BotonEntradaMercaderia.TabIndex = 4;
            BotonEntradaMercaderia.Text = "Cargar entrada de mercadería";
            BotonEntradaMercaderia.UseVisualStyleBackColor = true;
            BotonEntradaMercaderia.Click += BotonEntradaMercaderia_Click;
            // 
            // BotonConsultarStock
            // 
            BotonConsultarStock.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotonConsultarStock.Location = new Point(89, 173);
            BotonConsultarStock.Margin = new Padding(3, 4, 3, 4);
            BotonConsultarStock.Name = "BotonConsultarStock";
            BotonConsultarStock.Size = new Size(225, 211);
            BotonConsultarStock.TabIndex = 3;
            BotonConsultarStock.Text = "Consultar Stock";
            BotonConsultarStock.UseVisualStyleBackColor = true;
            BotonConsultarStock.Click += BotonConsultarStock_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(686, 553);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(215, 31);
            BotonVolver.TabIndex = 6;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // GestionarStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo_casos_de_uso;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEgresoMercaderia);
            Controls.Add(BotonEntradaMercaderia);
            Controls.Add(BotonConsultarStock);
            Margin = new Padding(3, 4, 3, 4);
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