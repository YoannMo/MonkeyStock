namespace MonkeyStock
{
    partial class frmAddArticleCommande
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbArticle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.btnConfirmArticle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article :";
            // 
            // cmbArticle
            // 
            this.cmbArticle.FormattingEnabled = true;
            this.cmbArticle.Location = new System.Drawing.Point(15, 38);
            this.cmbArticle.Name = "cmbArticle";
            this.cmbArticle.Size = new System.Drawing.Size(322, 21);
            this.cmbArticle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantité :";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(89, 91);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(134, 20);
            this.txtQte.TabIndex = 3;
            // 
            // btnConfirmArticle
            // 
            this.btnConfirmArticle.Location = new System.Drawing.Point(245, 88);
            this.btnConfirmArticle.Name = "btnConfirmArticle";
            this.btnConfirmArticle.Size = new System.Drawing.Size(92, 23);
            this.btnConfirmArticle.TabIndex = 4;
            this.btnConfirmArticle.Text = "Ajouter";
            this.btnConfirmArticle.UseVisualStyleBackColor = true;
            this.btnConfirmArticle.Click += new System.EventHandler(this.btnConfirmArticle_Click);
            // 
            // frmAddArticleCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 143);
            this.Controls.Add(this.btnConfirmArticle);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbArticle);
            this.Controls.Add(this.label1);
            this.Name = "frmAddArticleCommande";
            this.Text = "Ajouter article";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Button btnConfirmArticle;
    }
}