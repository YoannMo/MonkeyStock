using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyStock.Models
{
    public class Commande
    {
        public int CommandeID;
        public string NomPersonne;
        public string MoyenPaiement;
        public string Date;

        public List<CommandeArticle> arts;
    }

    public class CommandeArticle
    {
        public int ArticleID;
        public string ArticleNom;
        public int Quantite;
    }
}
