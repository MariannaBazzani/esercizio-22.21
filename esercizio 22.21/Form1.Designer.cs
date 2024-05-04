namespace esercizio_22._21
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMeno = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnDiviso = new System.Windows.Forms.Button();
            this.txtRisultato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(228, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMeno
            // 
            this.btnMeno.Location = new System.Drawing.Point(228, 70);
            this.btnMeno.Name = "btnMeno";
            this.btnMeno.Size = new System.Drawing.Size(75, 23);
            this.btnMeno.TabIndex = 3;
            this.btnMeno.Text = "-";
            this.btnMeno.UseVisualStyleBackColor = true;
            this.btnMeno.Click += new System.EventHandler(this.btnMeno_Click);
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(228, 114);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(75, 23);
            this.btnPer.TabIndex = 4;
            this.btnPer.Text = "x";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnDiviso
            // 
            this.btnDiviso.Location = new System.Drawing.Point(228, 158);
            this.btnDiviso.Name = "btnDiviso";
            this.btnDiviso.Size = new System.Drawing.Size(75, 23);
            this.btnDiviso.TabIndex = 5;
            this.btnDiviso.Text = ":";
            this.btnDiviso.UseVisualStyleBackColor = true;
            this.btnDiviso.Click += new System.EventHandler(this.btnDiviso_Click);
            // 
            // txtRisultato
            // 
            this.txtRisultato.Location = new System.Drawing.Point(34, 137);
            this.txtRisultato.Name = "txtRisultato";
            this.txtRisultato.Size = new System.Drawing.Size(100, 20);
            this.txtRisultato.TabIndex = 6;
            this.txtRisultato.TextChanged += new System.EventHandler(this.txtRisultato_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRisultato);
            this.Controls.Add(this.btnDiviso);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnMeno);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMeno;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnDiviso;
        private System.Windows.Forms.TextBox txtRisultato;
    }
}

