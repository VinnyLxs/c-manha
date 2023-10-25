namespace AppRever.View
{
    partial class TelaForm
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
            this.txtSg = new System.Windows.Forms.TextBox();
            this.txtTr = new System.Windows.Forms.TextBox();
            this.txtPr = new System.Windows.Forms.TextBox();
            this.Limpar = new System.Windows.Forms.Button();
            this.Btn_calcular = new System.Windows.Forms.Button();
            this.TrValor = new System.Windows.Forms.Label();
            this.SgValor = new System.Windows.Forms.Label();
            this.PrValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Maior = new System.Windows.Forms.Label();
            this.Menor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSg
            // 
            this.txtSg.Location = new System.Drawing.Point(205, 142);
            this.txtSg.Name = "txtSg";
            this.txtSg.Size = new System.Drawing.Size(121, 20);
            this.txtSg.TabIndex = 26;
            // 
            // txtTr
            // 
            this.txtTr.Location = new System.Drawing.Point(205, 182);
            this.txtTr.Name = "txtTr";
            this.txtTr.Size = new System.Drawing.Size(121, 20);
            this.txtTr.TabIndex = 25;
            // 
            // txtPr
            // 
            this.txtPr.Location = new System.Drawing.Point(205, 107);
            this.txtPr.Name = "txtPr";
            this.txtPr.Size = new System.Drawing.Size(121, 20);
            this.txtPr.TabIndex = 24;
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpar.Location = new System.Drawing.Point(68, 279);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(258, 33);
            this.Limpar.TabIndex = 23;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_calcular.Location = new System.Drawing.Point(68, 240);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(258, 33);
            this.Btn_calcular.TabIndex = 21;
            this.Btn_calcular.Text = "Calcular";
            this.Btn_calcular.UseVisualStyleBackColor = true;
            this.Btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click_1);
            // 
            // TrValor
            // 
            this.TrValor.AutoSize = true;
            this.TrValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrValor.Location = new System.Drawing.Point(64, 180);
            this.TrValor.Name = "TrValor";
            this.TrValor.Size = new System.Drawing.Size(121, 20);
            this.TrValor.TabIndex = 20;
            this.TrValor.Text = "Terceiro Valor";
            // 
            // SgValor
            // 
            this.SgValor.AutoSize = true;
            this.SgValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SgValor.Location = new System.Drawing.Point(64, 140);
            this.SgValor.Name = "SgValor";
            this.SgValor.Size = new System.Drawing.Size(128, 20);
            this.SgValor.TabIndex = 19;
            this.SgValor.Text = "Segundo Valor";
            // 
            // PrValor
            // 
            this.PrValor.AutoSize = true;
            this.PrValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrValor.Location = new System.Drawing.Point(64, 105);
            this.PrValor.Name = "PrValor";
            this.PrValor.Size = new System.Drawing.Size(121, 20);
            this.PrValor.TabIndex = 18;
            this.PrValor.Text = "Primeiro Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sistema de Valor";
            // 
            // Maior
            // 
            this.Maior.AutoSize = true;
            this.Maior.Location = new System.Drawing.Point(68, 353);
            this.Maior.Name = "Maior";
            this.Maior.Size = new System.Drawing.Size(35, 13);
            this.Maior.TabIndex = 27;
            this.Maior.Text = "label2";
            // 
            // Menor
            // 
            this.Menor.AutoSize = true;
            this.Menor.Location = new System.Drawing.Point(68, 388);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(35, 13);
            this.Menor.TabIndex = 28;
            this.Menor.Text = "label3";
            // 
            // TelaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.Maior);
            this.Controls.Add(this.txtSg);
            this.Controls.Add(this.txtTr);
            this.Controls.Add(this.txtPr);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Btn_calcular);
            this.Controls.Add(this.TrValor);
            this.Controls.Add(this.SgValor);
            this.Controls.Add(this.PrValor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Valor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSg;
        private System.Windows.Forms.TextBox txtTr;
        private System.Windows.Forms.TextBox txtPr;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Btn_calcular;
        private System.Windows.Forms.Label TrValor;
        private System.Windows.Forms.Label SgValor;
        private System.Windows.Forms.Label PrValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Maior;
        private System.Windows.Forms.Label Menor;
    }
}