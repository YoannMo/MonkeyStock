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
    public partial class frmArticles : Form
    {
        private Database db;

        public frmArticles(Database pdb)
        {
            InitializeComponent();

            db = pdb;

            //Init listview
            listArticles.View = View.Details;
            listArticles.GridLines = true;
            listArticles.FullRowSelect = true;
            //listArticles.Columns.Add("Id", 50);
            listArticles.Columns.Add("Nom", 150);
            listArticles.Columns.Add("Prix", 100);
            DisplayListArticles();
        }

        private void DisplayListArticles()
        {
            List<Article> arts = db.GetArticles();

            listArticles.Items.Clear();


            foreach (Article a in arts)
            {
                string[] arr = new string[2];
                //arr[0] = a.ID.ToString();
                arr[0] = a.Nom;
                arr[1] = a.Prix.ToString();
                ListViewItem item = new ListViewItem(arr);
                listArticles.Items.Add(item);
            }

        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            string nomArticle = txtNomArticle.Text;
            decimal prixArticle;
            decimal.TryParse(txtPrixArticle.Text, out prixArticle);
            Article art = new Article()
            {
                Nom = nomArticle,
                Prix = prixArticle
            };
            db.AddArticle(art);
            DisplayListArticles();
        }
    }
}
