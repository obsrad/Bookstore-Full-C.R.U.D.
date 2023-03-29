using MySqlConnector;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStore
{
    public partial class UpdateBookOrAuthorForm : Form
    {
        MySqlConnection conn;
        public UpdateBookOrAuthorForm()
        {
            InitializeComponent();
            SQL_Connection sqlConn = new SQL_Connection();
            conn = new MySqlConnection(sqlConn.userCon());
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Hämtar värden från textBox
                string authorName = txtAuthor.Text;

                //SQL Querry
                string sqlQuerry = $"CALL GetAuthorName('{authorName}')";

                //Skapa MySQLCommand objekt
                MySqlCommand cmda = new MySqlCommand(sqlQuerry, conn);

                //Öppnar koppling till DB
                conn.Open();

                //Exekvera MySQLCommand. Spara resultat i reader
                MySqlDataReader reader = cmda.ExecuteReader();

                //Skapar en variabel för att spara ett id
                int authorId = 0;

                //Lägga in id till authorId
                while (reader.Read())
                {
                    authorId = Convert.ToInt32(reader["author_id"]);
                }

                //Stänger koppling till DB
                conn.Close();

                //Hämtar värden från textBox
                string bookTitle = txtTitle.Text;
                int bookId = Convert.ToInt32(txtBookId.Text);

                //Konverterar värde till ett id
                int selectedID = Book.books[bookId - 1].Id;

                //SQL Querry
                string strSql = $"CALL UpdateBookInDB('{bookTitle}', {authorId}, {selectedID})";

                //Skapa MySQLCommand objekt
                MySqlCommand cmd = new MySqlCommand(strSql, conn);

                //Öppnar koppling till DB, Utför Querry, Stänger koppling till DB
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

                //Stänger fönstret
                this.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Please enter valid values");
            }

        }

        private void btnAuthorUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Hämtar värden från textBox
                string authorName = txtAuthorName.Text;
                int authorId = Convert.ToInt32(txtAuthorId.Text);

                //Konverterar värde till ett id
                int selectedID = Author.authors[authorId - 1].Id;

                //SQL Querry
                string sqlQuerry = $"CALL UpdateAuthorInDB('{authorName}', {selectedID});";

                //Skapa MySQLCommand objekt
                MySqlCommand cmda = new MySqlCommand(sqlQuerry, conn);

                //Öppnar koppling till DB, Utför Querry, Stänger koppling till DB
                conn.Open();
                cmda.ExecuteReader();
                conn.Close();

                //Stänger fönstret
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Please enter valid values");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Stänger fönstret
            this.Close();
        }
    }
}
