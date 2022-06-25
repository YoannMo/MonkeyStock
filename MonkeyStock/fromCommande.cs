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
    public partial class fromCommande : Form
    {
        private Database db;
        private List<Commande> comms;
        public fromCommande(Database pDb)
        {
            InitializeComponent();

            db = pDb;

            //Init listview
            listeComArticles.View = View.Details;
            listeComArticles.GridLines = true;
            listeComArticles.FullRowSelect = true;
            listeComArticles.Columns.Add("Article", 150);
            listeComArticles.Columns.Add("Quantité", 100);

            //Init listview
            listCommandes.View = View.Details;
            listCommandes.GridLines = true;
            listCommandes.FullRowSelect = true;
            listCommandes.Columns.Add("Client", 150);
            listCommandes.Columns.Add("Date", 100);
            listCommandes.Columns.Add("Moyen de Paiement", 100);
            DisplayListCommandes();
        }

        public void DisplayListCommandes()
        {
            comms = db.GetCommandes();

            listCommandes.Items.Clear();

            foreach (Commande c in comms)
            {
                string[] arr = new string[3];
                arr[0] = c.NomPersonne;
                arr[1] = c.Date;
                arr[2] = c.MoyenPaiement;
                ListViewItem item = new ListViewItem(arr);
                listCommandes.Items.Add(item);
            }

        }

        private void btnNewCommande_Click(object sender, EventArgs e)
        {
            frmNewCommande ne = new frmNewCommande(db, this);
            ne.Show();
        }

        private void listCommandes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCommandes.SelectedIndices.Count <= 0)
                return;

            int selectedIndex = listCommandes.SelectedIndices[0];
            Commande co = comms[selectedIndex];
            List<CommandeArticle> cas = db.GetArticlesForCommande(co.CommandeID);

            listeComArticles.Items.Clear();
            foreach (CommandeArticle c in cas)
            {
                string[] arr = new string[2];
                arr[0] = c.ArticleNom;
                arr[1] = c.Quantite.ToString();
                ListViewItem item = new ListViewItem(arr);
                listeComArticles.Items.Add(item);
            }
        }
    }
}
