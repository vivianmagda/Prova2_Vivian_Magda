namespace Prova2_Vivian_Magda
{
    partial class EnergiaEletrica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergiaEletrica));
            this.cLB1 = new System.Windows.Forms.CheckedListBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cLB1
            // 
            this.cLB1.CheckOnClick = true;
            this.cLB1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLB1.FormattingEnabled = true;
            this.cLB1.Items.AddRange(new object[] {
            "Residencial",
            "Industrial",
            "Comercial"});
            this.cLB1.Location = new System.Drawing.Point(23, 56);
            this.cLB1.Name = "cLB1";
            this.cLB1.Size = new System.Drawing.Size(130, 67);
            this.cLB1.TabIndex = 0;
            this.cLB1.ThreeDCheckBoxes = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Arial", 12F);
            this.lb1.Location = new System.Drawing.Point(20, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(255, 18);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Selecione o seu tipo de instalação: ";
            // 
            // EnergiaEletrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 288);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.cLB1);
            this.DoubleBuffered = true;
            this.Name = "EnergiaEletrica";
            this.Text = "Energia Elétrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cLB1;
        private System.Windows.Forms.Label lb1;
    }
}

