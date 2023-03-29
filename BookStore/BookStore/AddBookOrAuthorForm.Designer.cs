namespace BookStore
{
    partial class AddBookOrAuthorForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthorId = new System.Windows.Forms.Label();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddBooks = new System.Windows.Forms.Label();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnAuthorAdd = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(175, 171);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(202, 31);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(175, 234);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(202, 31);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(101, 171);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthorId
            // 
            this.lblAuthorId.AutoSize = true;
            this.lblAuthorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorId.Location = new System.Drawing.Point(9, 240);
            this.lblAuthorId.Name = "lblAuthorId";
            this.lblAuthorId.Size = new System.Drawing.Size(148, 25);
            this.lblAuthorId.TabIndex = 3;
            this.lblAuthorId.Text = "Author Name";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.AutoSize = true;
            this.btnBookAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAdd.Location = new System.Drawing.Point(175, 321);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 35);
            this.btnBookAdd.TabIndex = 4;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(817, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddBooks
            // 
            this.lblAddBooks.AutoSize = true;
            this.lblAddBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBooks.Location = new System.Drawing.Point(170, 96);
            this.lblAddBooks.Name = "lblAddBooks";
            this.lblAddBooks.Size = new System.Drawing.Size(139, 29);
            this.lblAddBooks.TabIndex = 6;
            this.lblAddBooks.Text = "Add Books";
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAuthor.Location = new System.Drawing.Point(537, 96);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(141, 29);
            this.lblAddAuthor.TabIndex = 7;
            this.lblAddAuthor.Text = "Add Author";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(464, 171);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(72, 25);
            this.lblAuthorName.TabIndex = 8;
            this.lblAuthorName.Text = "Name";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(542, 171);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(202, 31);
            this.txtAuthorName.TabIndex = 9;
            // 
            // btnAuthorAdd
            // 
            this.btnAuthorAdd.AutoSize = true;
            this.btnAuthorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorAdd.Location = new System.Drawing.Point(542, 321);
            this.btnAuthorAdd.Name = "btnAuthorAdd";
            this.btnAuthorAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAuthorAdd.TabIndex = 10;
            this.btnAuthorAdd.Text = "Add";
            this.btnAuthorAdd.UseVisualStyleBackColor = true;
            this.btnAuthorAdd.Click += new System.EventHandler(this.btnAuthorAdd_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 405);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // AddBookOrAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 405);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnAuthorAdd);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblAddAuthor);
            this.Controls.Add(this.lblAddBooks);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.lblAuthorId);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "AddBookOrAuthorForm";
            this.Text = "AddBookOrAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddBooks;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnAuthorAdd;
        private System.Windows.Forms.Splitter splitter1;
    }
}