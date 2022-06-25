namespace MonkeyStock
{
    partial class frmNewCommande
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMoyenPai = new System.Windows.Forms.ComboBox();
            this.listArticles = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnAddCommande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouvelle Commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(71, 97);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(216, 20);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "24/06/2022";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(71, 135);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(216, 20);
            this.txtClient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Moyen de paiement :";
            // 
            // cmbMoyenPai
            // 
            this.cmbMoyenPai.FormattingEnabled = true;
            this.cmbMoyenPai.Items.AddRange(new object[] {
            "CB",
            "Espèces",
            "Chèque",
            "Don"});
            this.cmbMoyenPai.Location = new System.Drawing.Point(24, 202);
            this.cmbMoyenPai.Name = "cmbMoyenPai";
            this.cmbMoyenPai.Size = new System.Drawing.Size(263, 21);
            this.cmbMoyenPai.TabIndex = 7;
            // 
            // listArticles
            // 
            this.listArticles.HideSelection = false;
            this.listArticles.Location = new System.Drawing.Point(15, 265);
            this.listArticles.Name = "listArticles";
            this.listArticles.Size = new System.Drawing.Size(272, 97);
            this.listArticles.TabIndex = 8;
            this.listArticles.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Articles :";
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(15, 368);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(272, 23);
            this.btnAddArticle.TabIndex = 10;
            this.btnAddArticle.Text = "Ajouter article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // btnAddCommande
            // 
            this.btnAddCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCommande.Location = new System.Drawing.Point(15, 436);
            this.btnAddCommande.Name = "btnAddCommande";
            this.btnAddCommande.Size = new System.Drawing.Size(272, 40);
            this.btnAddCommande.TabIndex = 11;
            this.btnAddCommande.Text = "Ajouter commande";
            this.btnAddCommande.UseVisualStyleBackColor = true;
            this.btnAddCommande.Click += new System.EventHandler(this.btnAddCommande_Click);
            // 
            // frmNewCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 497);
            this.Controls.Add(this.btnAddCommande);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listArticles);
            this.Controls.Add(this.cmbMoyenPai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewCommande";
            this.Text = "frmNewCommande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMoyenPai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnAddCommande;
        private System.Windows.Forms.ListView listArticles;
    }
}