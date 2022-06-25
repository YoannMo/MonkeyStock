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
    public partial class frmStock : Form
    {
        private Database db;
        public frmStock(Database pdb)
        {
            InitializeComponent();

            db = pdb;

            //Init listview
            listStock.View = View.Details;
            listStock.GridLines = true;
            listStock.FullRowSelect = true;
            listStock.Columns.Add("Article", 150);
            listStock.Columns.Add("Quantité", 100);
            DisplayListStock();

            List<Article> arts = new List<Article>();
            arts = db.GetArticles();

            listArticles.DisplayMember = "Nom";
            listArticles.ValueMember = "ID";
            listArticles.DataSource = (from a in arts
                                       select new { Nom = a.Nom, ID = a.ID }).ToList();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            int articleID = int.Parse(listArticles.SelectedValue.ToString());
            int quantite = int.Parse(txtQuantite.Text);
            db.AddStock(articleID, quantite);

            DisplayListStock();
        }

        private void DisplayListStock()
        {
            List<ArticleStock> arts = db.GetStock();

            listStock.Items.Clear();

            foreach (ArticleStock a in arts)
            {
                string[] arr = new string[2];
                arr[0] = a.ArticleNom;
                arr[1] = a.Quantite.ToString();
                ListViewItem item = new ListViewItem(arr);
                listStock.Items.Add(item);
            }

        }
    }
}
