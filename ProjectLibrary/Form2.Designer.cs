namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBook = new System.Windows.Forms.ListBox();
            this.Profile = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.AuthorSelect = new System.Windows.Forms.Button();
            this.GenreSelect = new System.Windows.Forms.Button();
            this.SelectAutOrGen = new System.Windows.Forms.ComboBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBook
            // 
            this.ListBook.FormattingEnabled = true;
            this.ListBook.Location = new System.Drawing.Point(12, 42);
            this.ListBook.Name = "ListBook";
            this.ListBook.Size = new System.Drawing.Size(342, 173);
            this.ListBook.TabIndex = 0;
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Profile.Location = new System.Drawing.Point(12, 9);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(49, 17);
            this.Profile.TabIndex = 7;
            this.Profile.Text = "Name";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(12, 232);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(110, 23);
            this.AddBook.TabIndex = 8;
            this.AddBook.Text = "Добавить книгу";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(128, 232);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(110, 23);
            this.Read.TabIndex = 9;
            this.Read.Text = "Читать";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(244, 232);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(110, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Выйти из профиля";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.Location = new System.Drawing.Point(12, 261);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(110, 23);
            this.DeleteBook.TabIndex = 11;
            this.DeleteBook.Text = "Удалить книгу";
            this.DeleteBook.UseVisualStyleBackColor = true;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // AuthorSelect
            // 
            this.AuthorSelect.Location = new System.Drawing.Point(128, 261);
            this.AuthorSelect.Name = "AuthorSelect";
            this.AuthorSelect.Size = new System.Drawing.Size(110, 23);
            this.AuthorSelect.TabIndex = 12;
            this.AuthorSelect.Text = "По авторам";
            this.AuthorSelect.UseVisualStyleBackColor = true;
            this.AuthorSelect.Click += new System.EventHandler(this.AuthorSelect_Click);
            // 
            // GenreSelect
            // 
            this.GenreSelect.Location = new System.Drawing.Point(244, 261);
            this.GenreSelect.Name = "GenreSelect";
            this.GenreSelect.Size = new System.Drawing.Size(110, 23);
            this.GenreSelect.TabIndex = 13;
            this.GenreSelect.Text = "По жанрам";
            this.GenreSelect.UseVisualStyleBackColor = true;
            this.GenreSelect.Click += new System.EventHandler(this.GenreSelect_Click);
            // 
            // SelectAutOrGen
            // 
            this.SelectAutOrGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectAutOrGen.FormattingEnabled = true;
            this.SelectAutOrGen.Location = new System.Drawing.Point(224, 12);
            this.SelectAutOrGen.Name = "SelectAutOrGen";
            this.SelectAutOrGen.Size = new System.Drawing.Size(94, 21);
            this.SelectAutOrGen.TabIndex = 14;
            this.SelectAutOrGen.Visible = false;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(324, 10);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(43, 23);
            this.SelectButton.TabIndex = 15;
            this.SelectButton.Text = "ОК";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Visible = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 288);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.SelectAutOrGen);
            this.Controls.Add(this.GenreSelect);
            this.Controls.Add(this.AuthorSelect);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.Profile);
            this.Controls.Add(this.ListBook);
            this.Name = "Form2";
            this.Text = "Книги профиля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBook;
        private System.Windows.Forms.Label Profile;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button AuthorSelect;
        private System.Windows.Forms.Button GenreSelect;
        private System.Windows.Forms.ComboBox SelectAutOrGen;
        private System.Windows.Forms.Button SelectButton;
    }
}