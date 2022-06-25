namespace MonkeyStock
{
    partial class fromCommande
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
            this.listCommandes = new System.Windows.Forms.ListView();
            this.listeComArticles = new System.Windows.Forms.ListView();
            this.btnNewCommande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCommandes
            // 
            this.listCommandes.HideSelection = false;
            this.listCommandes.Location = new System.Drawing.Point(12, 12);
            this.listCommandes.MultiSelect = false;
            this.listCommandes.Name = "listCommandes";
            this.listCommandes.Size = new System.Drawing.Size(373, 426);
            this.listCommandes.TabIndex = 0;
            this.listCommandes.UseCompatibleStateImageBehavior = false;
            this.listCommandes.SelectedIndexChanged += new System.EventHandler(this.listCommandes_SelectedIndexChanged);
            // 
            // listeComArticles
            // 
            this.listeComArticles.HideSelection = false;
            this.listeComArticles.Location = new System.Drawing.Point(410, 12);
            this.listeComArticles.Name = "listeComArticles";
            this.listeComArticles.Size = new System.Drawing.Size(368, 332);
            this.listeComArticles.TabIndex = 1;
            this.listeComArticles.UseCompatibleStateImageBehavior = false;
            // 
            // btnNewCommande
            // 
            this.btnNewCommande.Location = new System.Drawing.Point(417, 365);
            this.btnNewCommande.Name = "btnNewCommande";
            this.btnNewCommande.Size = new System.Drawing.Size(360, 58);
            this.btnNewCommande.TabIndex = 2;
            this.btnNewCommande.Text = "Nouvelle commande";
            this.btnNewCommande.UseVisualStyleBackColor = true;
            this.btnNewCommande.Click += new System.EventHandler(this.btnNewCommande_Click);
            // 
            // fromCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewCommande);
            this.Controls.Add(this.listeComArticles);
            this.Controls.Add(this.listCommandes);
            this.Name = "fromCommande";
            this.Text = "fromCommande";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCommandes;
        private System.Windows.Forms.ListView listeComArticles;
        private System.Windows.Forms.Button btnNewCommande;
    }
}