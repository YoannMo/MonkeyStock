using MonkeyStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonkeyStock
{
    public partial class frmAddArticleCommande : Form
    {
        private Database db;
        private frmNewCommande frm;

        public frmAddArticleCommande(Database pdb, frmNewCommande parentForm)
        {
            InitializeComponent();

            db = pdb;
            frm = parentForm;

            List<Article> arts = new List<Article>();
            arts = db.GetArticles();

            cmbArticle.DisplayMember = "Nom";
            cmbArticle.ValueMember = "ID";
            cmbArticle.DataSource = (from a in arts
                                       select new { Nom = a.Nom, ID = a.ID }).ToList();
        }

        private void btnConfirmArticle_Click(object sender, EventArgs e)
        {
            int articleId = int.Parse(cmbArticle.SelectedValue.ToString());
            int qte = int.Parse(txtQte.Text);
            frm.AddArticle(articleId, qte, cmbArticle.Text);
            this.Close();
        }
    }
}
