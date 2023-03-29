namespace BookStore
{
    partial class DeleteBookOrAuthorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblIdAuthor = new System.Windows.Forms.Label();
            this.txtAuthorId = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblDeleteAuthor = new System.Windows.Forms.Label();
            this.lblDeletBooks = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAuthorUpdate = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(21, 137);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(34, 25);
            this.lblBookId.TabIndex = 23;
            this.lblBookId.Text = "ID";
            // 
            // lblIdAuthor
            // 
            this.lblIdAuthor.AutoSize = true;
            this.lblIdAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAuthor.Location = new System.Drawing.Point(356, 137);
            this.lblIdAuthor.Name = "lblIdAuthor";
            this.lblIdAuthor.Size = new System.Drawing.Size(34, 25);
            this.lblIdAuthor.TabIndex = 24;
            this.lblIdAuthor.Text = "ID";
            // 
            // txtAuthorId
            // 
            this.txtAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorId.Location = new System.Drawing.Point(396, 131);
            this.txtAuthorId.Name = "txtAuthorId";
            this.txtAuthorId.Size = new System.Drawing.Size(202, 31);
            this.txtAuthorId.TabIndex = 22;
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(71, 131);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(202, 31);
            this.txtBookId.TabIndex = 21;
            // 
            // lblDeleteAuthor
            // 
            this.lblDeleteAuthor.AutoSize = true;
            this.lblDeleteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAuthor.Location = new System.Drawing.Point(391, 60);
            this.lblDeleteAuthor.Name = "lblDeleteAuthor";
            this.lblDeleteAuthor.Size = new System.Drawing.Size(172, 29);
            this.lblDeleteAuthor.TabIndex = 20;
            this.lblDeleteAuthor.Text = "Delete Author";
            // 
            // lblDeletBooks
            // 
            this.lblDeletBooks.AutoSize = true;
            this.lblDeletBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletBooks.Location = new System.Drawing.Point(66, 60);
            this.lblDeletBooks.Name = "lblDeletBooks";
            this.lblDeletBooks.Size = new System.Drawing.Size(170, 29);
            this.lblDeletBooks.TabIndex = 19;
            this.lblDeletBooks.Text = "Delete Books";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(627, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 35);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAuthorUpdate
            // 
            this.btnAuthorUpdate.AutoSize = true;
            this.btnAuthorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorUpdate.Location = new System.Drawing.Point(396, 203);
            this.btnAuthorUpdate.Name = "btnAuthorUpdate";
            this.btnAuthorUpdate.Size = new System.Drawing.Size(97, 35);
            this.btnAuthorUpdate.TabIndex = 26;
            this.btnAuthorUpdate.Text = "Delete";
            this.btnAuthorUpdate.UseVisualStyleBackColor = true;
            this.btnAuthorUpdate.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.AutoSize = true;
            this.btnBookDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDelete.Location = new System.Drawing.Point(71, 203);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(97, 35);
            this.btnBookDelete.TabIndex = 25;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // DeleteBookOrAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 258);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAuthorUpdate);
            this.Controls.Add(this.btnBookDelete);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblIdAuthor);
            this.Controls.Add(this.txtAuthorId);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lblDeleteAuthor);
            this.Controls.Add(this.lblDeletBooks);
            this.Name = "DeleteBookOrAuthorForm";
            this.Text = "DeleteBookOrAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblIdAuthor;
        private System.Windows.Forms.TextBox txtAuthorId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblDeleteAuthor;
        private System.Windows.Forms.Label lblDeletBooks;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAuthorUpdate;
        private System.Windows.Forms.Button btnBookDelete;
    }
}