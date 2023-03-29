using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class DeleteBookOrAuthorForm : Form
    {
        MySqlConnection conn;
        public DeleteBookOrAuthorForm()
        {
            InitializeComponent();
            SQL_Connection sqlConn = new SQL_Connection();
            conn = new MySqlConnection(sqlConn.userCon());
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Hämtar värden från textBox
                int bookId = Convert.ToInt32(txtBookId.Text);

                //Konverterar värde till ett id
                int selectedID = Book.books[bookId - 1].Id;

                //SQL Querry
                string strSql = $"CALL DeleteBookInDB({selectedID});";

                //Skapa MySQLCommand objekt
                MySqlCommand cmd = new MySqlCommand(strSql, conn);

                //Öppnar koppling till DB, Utför Querry, Stänger koppling till DB
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

                //Stänger fönstret
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid id");
            }
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Hämtar värden från textBox
                int authorId = Convert.ToInt32(txtAuthorId.Text);

                //Konverterar värde till ett id
                int selectedId = Author.authors[authorId - 1].Id;

                //SQL Querry
                string strSql = $"CALL DeleteAuthorInDB({selectedId})";

                //Skapa MySQLCommand objekt
                MySqlCommand cmd = new MySqlCommand(strSql, conn);

                //Öppnar koppling till DB, Utför Querry, Stänger koppling till DB
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

                //Stänger fönstret
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid id");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Stänger fönstret
            this.Close();
        }
    }
}
