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
            this.lb1 = new System.Windows.Forms.Label();
            this.btR = new System.Windows.Forms.Button();
            this.btI = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lb1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold);
            this.lb1.Location = new System.Drawing.Point(78, 34);
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
            this.btR.Location = new System.Drawing.Point(149, 89);
            this.btR.Name = "btR";
            this.btR.Size = new System.Drawing.Size(152, 40);
            this.btR.TabIndex = 2;
            this.btR.Text = "Residencial";
            this.btR.UseVisualStyleBackColor = false;
            this.btR.Click += new System.EventHandler(this.btR_Click);
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
            this.btI.Location = new System.Drawing.Point(149, 201);
            this.btI.Name = "btI";
            this.btI.Size = new System.Drawing.Size(152, 43);
            this.btI.TabIndex = 3;
            this.btI.Text = "Industrial";
            this.btI.UseVisualStyleBackColor = false;
            this.btI.Click += new System.EventHandler(this.btI_Click);
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
            this.btC.Location = new System.Drawing.Point(149, 143);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(152, 44);
            this.btC.TabIndex = 4;
            this.btC.Text = "Comercial";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.AutoSize = true;
            this.btVoltar.BackColor = System.Drawing.Color.SandyBrown;
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btVoltar.Location = new System.Drawing.Point(149, 306);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(152, 44);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Visible = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(87, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o seu consumo em kWh:";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            // 
            // btRelatorio
            // 
            this.btRelatorio.AutoSize = true;
            this.btRelatorio.BackColor = System.Drawing.Color.SandyBrown;
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRelatorio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRelatorio.Location = new System.Drawing.Point(139, 242);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(182, 44);
            this.btRelatorio.TabIndex = 8;
            this.btRelatorio.Text = "Gerar Relatório";
            this.btRelatorio.UseVisualStyleBackColor = false;
            this.btRelatorio.Visible = false;
            this.btRelatorio.Click += new System.EventHandler(this.btRelatorio_Click);
            // 
            // btSair
            // 
            this.btSair.AutoSize = true;
            this.btSair.BackColor = System.Drawing.Color.SandyBrown;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSair.Location = new System.Drawing.Point(149, 292);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(152, 44);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(110, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Onde você quer salvar?";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Visible = false;
            // 
            // EnergiaEletrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Prova2_Vivian_Magda.Properties.Resources.Screenshot_1__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(457, 382);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btR);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btRelatorio);
            this.Controls.Add(this.btI);
            this.Controls.Add(this.btSair);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EnergiaEletrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Energia Elétrica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btR;
        private System.Windows.Forms.Button btI;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

