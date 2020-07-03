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
            this.lb1 = new System.Windows.Forms.Label();
            this.btR = new System.Windows.Forms.Button();
            this.btI = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(61, 58);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(309, 23);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Selecione o seu tipo de instalação: ";
            // 
            // btR
            // 
            this.btR.AutoSize = true;
            this.btR.BackColor = System.Drawing.Color.SandyBrown;
            this.btR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btR.FlatAppearance.BorderSize = 0;
            this.btR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btR.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btR.Location = new System.Drawing.Point(132, 93);
            this.btR.Name = "btR";
            this.btR.Size = new System.Drawing.Size(152, 40);
            this.btR.TabIndex = 2;
            this.btR.Text = "Residencial";
            this.btR.UseVisualStyleBackColor = false;
            // 
            // btI
            // 
            this.btI.AutoSize = true;
            this.btI.BackColor = System.Drawing.Color.SandyBrown;
            this.btI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btI.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btI.FlatAppearance.BorderSize = 0;
            this.btI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btI.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btI.Location = new System.Drawing.Point(132, 159);
            this.btI.Name = "btI";
            this.btI.Size = new System.Drawing.Size(152, 43);
            this.btI.TabIndex = 3;
            this.btI.Text = "Industrial";
            this.btI.UseVisualStyleBackColor = false;
            // 
            // btC
            // 
            this.btC.AutoSize = true;
            this.btC.BackColor = System.Drawing.Color.SandyBrown;
            this.btC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btC.FlatAppearance.BorderSize = 0;
            this.btC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btC.Location = new System.Drawing.Point(132, 231);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(152, 44);
            this.btC.TabIndex = 4;
            this.btC.Text = "Comercial";
            this.btC.UseVisualStyleBackColor = false;
            // 
            // EnergiaEletrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(407, 331);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btI);
            this.Controls.Add(this.btR);
            this.Controls.Add(this.lb1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EnergiaEletrica";
            this.Text = "Energia Elétrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btR;
        private System.Windows.Forms.Button btI;
        private System.Windows.Forms.Button btC;
    }
}

