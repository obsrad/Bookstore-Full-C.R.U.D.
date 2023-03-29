namespace BookStore
{
    partial class AddBookToStoreForm
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
            this.lblAddBooks = new System.Windows.Forms.Label();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddBooks
            // 
            this.lblAddBooks.AutoSize = true;
            this.lblAddBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBooks.Location = new System.Drawing.Point(110, 26);
            this.lblAddBooks.Name = "lblAddBooks";
            this.lblAddBooks.Size = new System.Drawing.Size(139, 29);
            this.lblAddBooks.TabIndex = 12;
            this.lblAddBooks.Text = "Add Books";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.AutoSize = true;
            this.btnBookAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAdd.Location = new System.Drawing.Point(115, 160);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 35);
            this.btnBookAdd.TabIndex = 11;
            this.btnBookAdd.Text = "Add";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(41, 101);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 25);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "ID";
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(115, 101);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(202, 31);
            this.txtBookId.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(341, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddBookToStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAddBooks);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtBookId);
            this.Name = "AddBookToStoreForm";
            this.Text = "AddBookToStoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBooks;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Button btnCancel;
    }
}