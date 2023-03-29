using MySqlConnector;
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
    public partial class AddBookOrAuthorForm : Form
    {
        MySqlConnection conn;
        public AddBookOrAuthorForm()
        {
            InitializeComponent();
            SQL_Connection sqlConn = new SQL_Connection();
            conn = new MySqlConnection(sqlConn.userCon());
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
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

                //SQL Querry
                string strSql = $"CALL AddBookToDB('{bookTitle}', {authorId})";

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
                MessageBox.Show("Please enter valid values");
            }
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            //Hämtar värden från textBox
            string authorName = txtAuthorName.Text;

            //SQL Querry
            string strSql = $"CALL AddAuthorToDB('{authorName}')";
            
            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppnar koppling till DB, Utför Querry, Stänger koppling till DB
            conn.Open();
            cmd.ExecuteReader();
            conn.Close();

            //Stänger fönstret
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Stänger fönstret
            this.Close();
        }
    }
}
