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
    public partial class frmNewCommande : Form
    {
        private Database db;
        private static List<CommandeArticle> arts;
        private fromCommande parentForm;

        public frmNewCommande(Database pdb, fromCommande frm)
        {
            InitializeComponent();

            db = pdb;
            arts = new List<CommandeArticle>();
            parentForm = frm;

            //Init listview
            listArticles.View = View.Details;
            listArticles.GridLines = true;
            listArticles.FullRowSelect = true;
            listArticles.Columns.Add("Article", 150);
            listArticles.Columns.Add("Quantité", 100);
        }

        public void AddArticle(int articleID, int qte, string articleNom)
        {
            CommandeArticle comArt = arts.FirstOrDefault(x => x.ArticleID == articleID);
            if (comArt == null)
            {
                arts.Add(new CommandeArticle()
                {
                    ArticleID = articleID,
                    Quantite = qte,
                    ArticleNom = articleNom
                });
            }
            else
            {
                arts.Remove(comArt);
                arts.Add(new CommandeArticle()
                {
                    ArticleID = articleID,
                    Quantite = qte + comArt.Quantite,
                    ArticleNom = articleNom
                });
            }
            
            listArticles.Items.Clear();
            foreach (CommandeArticle c in arts)
            {
                string[] arr = new string[2];
                arr[0] = c.ArticleNom;
                arr[1] = c.Quantite.ToString();
                ListViewItem item = new ListViewItem(arr);
                listArticles.Items.Add(item);
            }
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            frmAddArticleCommande fr = new frmAddArticleCommande(db, this);
            fr.Show();
        }

        private void btnAddCommande_Click(object sender, EventArgs e)
        {
            string date = txtDate.Text;
            string nomCli = txtClient.Text;
            string moyenPaiem = cmbMoyenPai.Text;
            int commandeId = db.AddCommande(date, nomCli, moyenPaiem);
            foreach(CommandeArticle ca in arts)
            {
                db.AddArticleCommande(ca, commandeId);
            }
            parentForm.DisplayListCommandes();
            this.Close();
        }
    }
}
