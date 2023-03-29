using Google.Protobuf.WellKnownTypes;
using MySqlConnector;
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
    public partial class DeleteBookInStoreForm : Form
    {
        MySqlConnection conn;
        public DeleteBookInStoreForm()
        {
            InitializeComponent();
            SQL_Connection sqlConn = new SQL_Connection();
            conn = new MySqlConnection(sqlConn.userCon());
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Hämtar id för en affär
                int listIndex = Index.index[0];

                //Hämtar värden från textBox
                int bookId = Convert.ToInt32(txtBookId.Text);

                //Konverterar värde till ett id
                int selectedID = StoreHasBooks.storehasbooks[bookId - 1].Books_BooksId;

                //SQL Querry
                string strSql = $"CALL DeleteBookInStore({listIndex}, {selectedID});";

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
