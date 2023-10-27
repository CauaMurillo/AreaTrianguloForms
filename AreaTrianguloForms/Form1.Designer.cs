namespace AreaTrianguloForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.Label();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbBase
            // 
            this.txbBase.AutoSize = true;
            this.txbBase.Location = new System.Drawing.Point(27, 34);
            this.txbBase.Name = "txbBase";
            this.txbBase.Size = new System.Drawing.Size(31, 13);
            this.txbBase.TabIndex = 0;
            this.txbBase.Text = "Base";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(89, 34);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(89, 79);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 2;
            // 
            // txbAltura
            // 
            this.txbAltura.AutoSize = true;
            this.txbAltura.Location = new System.Drawing.Point(27, 86);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(34, 13);
            this.txbAltura.TabIndex = 3;
            this.txbAltura.Text = "Altura";
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.Location = new System.Drawing.Point(12, 129);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Size = new System.Drawing.Size(177, 49);
            this.btnCalcular1.TabIndex = 4;
            this.btnCalcular1.Text = "CALCULAR";
            this.btnCalcular1.UseVisualStyleBackColor = true;
            this.btnCalcular1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(30, 211);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(129, 20);
            this.txbResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(204, 261);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.btnCalcular1);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txbBase);
            this.Name = "Form1";
            this.Text = "Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox lblResultado;
        private System.Windows.Forms.Label txbBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label txbAltura;
        private System.Windows.Forms.Button btnCalcular1;
        private System.Windows.Forms.TextBox txbResultado;
    }
}

