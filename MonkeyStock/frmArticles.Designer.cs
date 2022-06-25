namespace MonkeyStock
{
    partial class frmArticles
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
            this.listArticles = new System.Windows.Forms.ListView();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomArticle = new System.Windows.Forms.TextBox();
            this.txtPrixArticle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listArticles
            // 
            this.listArticles.HideSelection = false;
            this.listArticles.Location = new System.Drawing.Point(12, 55);
            this.listArticles.Name = "listArticles";
            this.listArticles.Size = new System.Drawing.Size(402, 383);
            this.listArticles.TabIndex = 0;
            this.listArticles.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticle.Location = new System.Drawing.Point(6, 336);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(260, 41);
            this.btnAddArticle.TabIndex = 1;
            this.btnAddArticle.Text = "Ajouter article";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrixArticle);
            this.groupBox1.Controls.Add(this.txtNomArticle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddArticle);
            this.groupBox1.Location = new System.Drawing.Point(484, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 383);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvel article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prix :";
            // 
            // txtNomArticle
            // 
            this.txtNomArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomArticle.Location = new System.Drawing.Point(6, 101);
            this.txtNomArticle.Name = "txtNomArticle";
            this.txtNomArticle.Size = new System.Drawing.Size(260, 26);
            this.txtNomArticle.TabIndex = 4;
            // 
            // txtPrixArticle
            // 
            this.txtPrixArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixArticle.Location = new System.Drawing.Point(6, 198);
            this.txtPrixArticle.Name = "txtPrixArticle";
            this.txtPrixArticle.Size = new System.Drawing.Size(260, 26);
            this.txtPrixArticle.TabIndex = 5;
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listArticles);
            this.Name = "frmArticles";
            this.Text = "frmArticles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listArticles;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrixArticle;
        private System.Windows.Forms.TextBox txtNomArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}