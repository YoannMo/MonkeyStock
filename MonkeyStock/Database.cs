using MonkeyStock.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyStock
{
    public class Database
    {
        private SQLiteConnection connection;
        private SQLiteCommand cmd;
        private SQLiteDataReader read;

        public Database()
        {
            string fullpath = @"C:\Users\yoann\source\repos\MonkeyStock\monkeyStock.db";
            connection = new SQLiteConnection("Data Source=" + fullpath + ";Version=3;New=True;Compress=True;");
            connection.Open();
        }

        public List<Article> GetArticles()
        {
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM articles ORDER BY Nom";

            read = cmd.ExecuteReader();

            List<Article> articles = new List<Article>();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    Article art = new Article()
                    {
                        ID = read.GetInt32(0),
                        Nom = read.GetString(1),
                        Prix = read.GetDecimal(2),
                    };

                    articles.Add(art);
                }
            }

            return articles;
        }
        
        public List<ArticleStock> GetStock()
        {
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT a.Nom, Quantite FROM stock LEFT JOIN articles a ON ArticleID = a.ID ORDER BY Nom";

            read = cmd.ExecuteReader();

            List<ArticleStock> articles = new List<ArticleStock>();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    ArticleStock art = new ArticleStock()
                    {
                        ArticleNom = read.GetString(0),
                        Quantite = read.GetInt32(1),
                    };

                    articles.Add(art);
                }
            }

            return articles;
        }
        
        public List<Commande> GetCommandes()
        {
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM commandes";

            read = cmd.ExecuteReader();

            List<Commande> coms = new List<Commande>();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    Commande c = new Commande()
                    {
                        CommandeID = read.GetInt32(0),
                        Date = read.GetString(1),
                        NomPersonne = read.GetString(2),
                        MoyenPaiement = read.GetString(3)
                    };

                    coms.Add(c);
                }
            }

            return coms;
        }

        public void AddArticle(Article article)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO articles (Nom, Prix) VALUES ('" + article.Nom + "', " + article.Prix + ")";
            cmd.ExecuteNonQuery();
        }
        
        public int AddCommande(string date, string client, string paiement)
        {
            int commId = -1;
            cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO commandes (Date, Client, MoyenPaiement) VALUES ('" + date + "', '" + client + "', '" + paiement + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "SELECT last_insert_rowid();";
            read = cmd.ExecuteReader();
            if (read.Read())
                commId = (Int32)read.GetInt64(0);

            return commId;
        }

        public List<CommandeArticle> GetArticlesForCommande(int commID)
        {
            List<CommandeArticle> coms = new List<CommandeArticle>();
            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT ArticleID, CommandeID, Quantite, Nom FROM commandeArticles LEFT JOIN articles ON ArticleID = ID WHERE CommandeID = " + commID;

            read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    CommandeArticle c = new CommandeArticle()
                    {
                        ArticleID = read.GetInt32(0),
                        Quantite = read.GetInt32(2),
                        ArticleNom = read.GetString(3)
                    };

                    coms.Add(c);
                }
            }

            return coms;
        }        
        
        public void AddArticleCommande(CommandeArticle ca, int comID)
        {
            cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO commandeArticles (ArticleID, CommandeID, Quantite) VALUES (" + ca.ArticleID + ", " + comID + ", " + ca.Quantite + ")";
            cmd.ExecuteNonQuery();
        }
        
        public void AddStock(int articleID, int qte)
        {
            bool shouldUpdate = false;

            cmd = connection.CreateCommand();

            cmd.CommandText = "SELECT * FROM stock WHERE ArticleID = " + articleID;

            read = cmd.ExecuteReader();

            List<ArticleStock> articles = new List<ArticleStock>();

            if (read.HasRows)
                shouldUpdate = true;

            read.Close();

            if (shouldUpdate)
            {
                cmd.CommandText = "UPDATE stock SET Quantite = Quantite + " + qte + " WHERE ArticleID = " + articleID;
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.CommandText = "INSERT INTO stock (ArticleID, Quantite) VALUES (" + articleID + ", " + qte + ")";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
