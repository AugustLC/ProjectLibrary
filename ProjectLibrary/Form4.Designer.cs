namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.Puth = new System.Windows.Forms.TextBox();
            this.ChoiceFile = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.ComboBox();
            this.Genre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.NameBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Puth
            // 
            this.Puth.Location = new System.Drawing.Point(12, 33);
            this.Puth.Name = "Puth";
            this.Puth.ReadOnly = true;
            this.Puth.Size = new System.Drawing.Size(260, 20);
            this.Puth.TabIndex = 0;
            // 
            // ChoiceFile
            // 
            this.ChoiceFile.Location = new System.Drawing.Point(278, 31);
            this.ChoiceFile.Name = "ChoiceFile";
            this.ChoiceFile.Size = new System.Drawing.Size(75, 23);
            this.ChoiceFile.TabIndex = 1;
            this.ChoiceFile.Text = "Выбрать";
            this.ChoiceFile.UseVisualStyleBackColor = true;
            this.ChoiceFile.Click += new System.EventHandler(this.ChoiceFile_Click);
            // 
            // Author
            // 
            this.Author.FormattingEnabled = true;
            this.Author.Location = new System.Drawing.Point(12, 96);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(260, 21);
            this.Author.TabIndex = 2;
            // 
            // Genre
            // 
            this.Genre.FormattingEnabled = true;
            this.Genre.Location = new System.Drawing.Point(12, 123);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(260, 21);
            this.Genre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Жанр";
            // 
            // AddBook
            // 
            this.AddBook.Location = new System.Drawing.Point(12, 150);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(75, 23);
            this.AddBook.TabIndex = 6;
            this.AddBook.Text = "Добавить";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // NameBook
            // 
            this.NameBook.Location = new System.Drawing.Point(12, 70);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(260, 20);
            this.NameBook.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.Location = new System.Drawing.Point(12, 9);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 13);
            this.Message.TabIndex = 9;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 188);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBook);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.ChoiceFile);
            this.Controls.Add(this.Puth);
            this.Name = "Form4";
            this.Text = "Добавление книги";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Puth;
        private System.Windows.Forms.Button ChoiceFile;
        private System.Windows.Forms.ComboBox Author;
        private System.Windows.Forms.ComboBox Genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.TextBox NameBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Message;
    }
}