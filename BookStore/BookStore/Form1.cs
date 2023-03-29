using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStore
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            SQL_Connection sqlConn = new SQL_Connection();
            conn = new MySqlConnection(sqlConn.userCon());

        }
        private void btnStoreRead_Click(object sender, EventArgs e)
        {
            //Hämtar id för en affär
            int storeId = Store.stores[lbxStore.SelectedIndex].Id;
            
            //SQL Querry
            string strSql = $"CALL ViewBookByStore({storeId})";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Nollställer labels
            lblId.Text = "ID";
            lblTitleOrAuthor.Text = "Title";
            lblAuthor.Text = "Author";

            //Öppnar koppling till DB
            conn.Open();

            //Exekvera MySQLCommand. Spara resultat i reader
            MySqlDataReader reader = cmd.ExecuteReader();

            //Rensar listan
            StoreHasBooks.storehasbooks.Clear();

            //Skapar en variabel för att spara lokalt id
            int intID = 1;

            //While Loop för att skriva ut och lägger in böcker i listan
            while (reader.Read())
            {
                //Skriver ut lokalt id
                lblId.Text += Environment.NewLine + intID++;

                //Skriver ut book title
                lblTitleOrAuthor.Text += Environment.NewLine + reader["books_title"];

                //Skriver ut author name
                lblAuthor.Text += Environment.NewLine + reader["author_name"];

                //Sparar böcker i listan
                new StoreHasBooks(Convert.ToInt32(reader["store_store_id"]), Convert.ToInt32(reader["books_books_id"]));
            }
            //Stänger koppling till DB
            conn.Close();
        }

        private void btnStoreAdd_Click(object sender, EventArgs e)
        {
            //Hämtar id för en affär
            int storeId = Store.stores[lbxStore.SelectedIndex].Id;
            
            //Rensar listan
            Index.index.Clear();

            //Lägger in Index till listan
            new Index(storeId);

            //Skapa Form objekt
            AddBookToStoreForm fm = new AddBookToStoreForm();

            //Hämtar och visar böcker
            btnReadBook_Click(sender, e);

            //Visa Formen
            fm.Show();
        }

        private void btnStoreDelete_Click(object sender, EventArgs e)
        {
            //Hämtar id för en affär
            int storeId = Store.stores[lbxStore.SelectedIndex].Id;

            //Rensar listan
            Index.index.Clear();

            //Lägger in Index till listan
            new Index(storeId);

            //Skapa Form objekt
            DeleteBookInStoreForm fm = new DeleteBookInStoreForm();

            //Hämtar och visar böcker
            btnStoreRead_Click(sender, e);

            //Visa Formen
            fm.Show();

        }

        private void btnReadBook_Click(object sender, EventArgs e)
        {
            //SQL Querry
            string strSql = $"CALL ViewAllBooks()";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Nollställer labels
            lblId.Text = "ID";
            lblTitleOrAuthor.Text = "Title";
            lblAuthor.Text = "Author";

            //Öppnar koppling till DB
            conn.Open();

            //Exekvera MySQLCommand. Spara resultat i reader
            MySqlDataReader reader = cmd.ExecuteReader();

            //Rensar listan
            Book.books.Clear();

            //Skapar en variabel för att spara lokalt id
            int intID = 1;

            //While Loop för att skriva ut och lägger in böcker i listan
            while (reader.Read())
            {
                //Skriver ut lokalt id
                lblId.Text += Environment.NewLine + intID++;

                //Skriver ut book title
                lblTitleOrAuthor.Text += Environment.NewLine + reader["books_title"];

                //Skriver ut author name
                lblAuthor.Text += Environment.NewLine + reader["author_name"];

                //Sparar böcker i listan
                new Book(Convert.ToInt32(reader["books_id"]), reader["books_title"].ToString(), Convert.ToInt32(reader["author_author_id"]));
            }
            //Stänger koppling till DB
            conn.Close();
        }

        private void btnReadAuthor_Click(object sender, EventArgs e)
        {
            //SQL Querry
            string strSql = "CaLL ViewAllAuthors()";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Nollställer labels
            lblId.Text = "ID";
            lblTitleOrAuthor.Text = "Author";
            lblAuthor.Text = "";

            //Öppnar koppling till DB
            conn.Open();

            //Exekvera MySQLCommand. Spara resultat i reader
            MySqlDataReader reader = cmd.ExecuteReader();

            //Rensar listan
            Author.authors.Clear();

            //Skapar en variabel för att spara lokalt id
            int intID = 1;

            //While Loop för att skriva ut och lägger in författare i listan
            while (reader.Read())
            {
                //Skriver ut lokalt id
                lblId.Text += Environment.NewLine + intID++;

                //Skriver ut author name
                lblTitleOrAuthor.Text += Environment.NewLine + reader["author_name"];

                //Sparar författare i listan
                new Author(Convert.ToInt32(reader["author_id"]), reader["author_name"].ToString());
            }
            //Stänger koppling till DB
            conn.Close();
        }

        private void btnAddBookOrAuthor_Click(object sender, EventArgs e)
        {
            //Hämtar data för böcker och författare
            getBookOrAuthorData();

            //Skapa Form objekt
            AddBookOrAuthorForm fm = new AddBookOrAuthorForm();

            //Visa Formen
            fm.Show();
        }

        private void btnUpdateBookOrAuthor_Click(object sender, EventArgs e)
        {
            //Hämtar data för böcker och författare
            getBookOrAuthorData();

            //Skapa Form objekt
            UpdateBookOrAuthorForm fm = new UpdateBookOrAuthorForm();

            //Visa Formen
            fm.Show();
        }

        private void btnDeleteBookOrAuthor_Click(object sender, EventArgs e)
        {
            //Hämtar data för böcker och författare
            getBookOrAuthorData();

            //Skapa Form objekt
            DeleteBookOrAuthorForm fm = new DeleteBookOrAuthorForm();

            //Visa Formen
            fm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SQL Querry
            string strSql = $"CALL GetDataOnStore()";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppnar koppling till DB
            conn.Open();

            //Exekvera MySQLCommand. Spara resultat i reader
            MySqlDataReader reader = cmd.ExecuteReader();

            //Rensar listan
            Store.stores.Clear();

            //While Loop för att skriva ut och lägger in böcker i listan
            while (reader.Read())
            {
                //Sparar affärer i listan
                new Store(Convert.ToInt32(reader["store_id"]), reader["store_name"].ToString(), Convert.ToInt32(reader["store_phonenumber"]), reader["store_adress"].ToString());
            }
            //Stänger koppling till DB
            conn.Close();
        }

        private void getBookOrAuthorData()
        {
            //Hämtar data för böcker
            getBookData();

            //Hämtar data för författare
            getAuthorData();
        }

        private void getBookData()
        {
            //SQL Querry
            string strSql = $"CALL ViewAllBooks()";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppnar koppling till DB
            conn.Open();

            //Exekvera MySQLCommand. Spara resultat i reader
            MySqlDataReader reader = cmd.ExecuteReader();

            //Rensar listan
            Book.books.Clear();

            //While Loop för att lägga in böcker i listan
            while (reader.Read())
            {
                //Sparar böcker i listan
                new Book(Convert.ToInt32(reader["books_id"]), reader["books_title"].ToString(), Convert.ToInt32(reader["author_author_id"]));
            }
            //Stänger koppling till DB
            conn.Close();
        }

        private void getAuthorData()
        {
            //SQL Querry
            string strSql = "CALL ViewAllAuthors()";

            //Skapa MySQLCommand objekt
            MySqlCommand cmd = new MySqlCommand(strSql, conn);

            //Öppnar koppling till DB
            conn.Open();

            //Exekvera MySQLCommand. Spara resultat i reader
            MySqlDataReader reader = cmd.ExecuteReader();

            //Rensar listan
            Author.authors.Clear();

            //While Loop för att lägga in författre i listan
            while (reader.Read())
            {
                //Sparar författare i listan
                new Author(Convert.ToInt32(reader["author_id"]), reader["author_name"].ToString());
            }
            //Stänger koppling till DB
            conn.Close();
        }

        
    }
}
