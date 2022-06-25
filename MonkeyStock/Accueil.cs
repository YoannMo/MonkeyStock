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
    public partial class Accueil : Form
    {
        private Database db;
        public Accueil()
        {
            InitializeComponent();

            db = new Database();
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            frmArticles articles = new frmArticles(db);
            articles.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock st = new frmStock(db);
            st.Show();
        }

        private void btnCommandes_Click(object sender, EventArgs e)
        {
            fromCommande co = new fromCommande(db);
            co.Show();
        }
    }
}
