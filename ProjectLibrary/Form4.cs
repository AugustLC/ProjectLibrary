using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlServerCe;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"data source=" + Environment.CurrentDirectory + @"\Library.sdf");

        private string name;

        public Form4(string nameProfile)
        {
            InitializeComponent();
            con.Open();
            name = nameProfile;

            SqlCeCommand com1 = new SqlCeCommand("Select * from Author", con);
            //Создание объекта для чтения табличного результата запроса SELECT
            SqlCeDataReader reader = com1.ExecuteReader();
            while (reader.Read())
            {
                Author.Items.Add(reader[0]);
            }

            SqlCeCommand com2 = new SqlCeCommand("Select * from Genre", con);
            //Создание объекта для чтения табличного результата запроса SELECT
            SqlCeDataReader reader2 = com2.ExecuteReader();
            while (reader2.Read())
            {
                Genre.Items.Add(reader2[0]);
            }
        }

        private void ChoiceFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if ((ofd.ShowDialog() == DialogResult.OK) && (ofd.FileName != null))
            {
                Puth.Text = ofd.FileName;
            }
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            if (Author.Text != "")
            {
                SqlCeCommand com0 = new SqlCeCommand("Select * from Author WHERE Name = '" + Author.Text + "'", con);
                SqlCeDataReader reader0 = com0.ExecuteReader();
                if (!reader0.Read())
                {
                    SqlCeCommand com01 = new SqlCeCommand("INSERT INTO Author (Name) VALUES ('"
                                + Author.Text + "')", con);
                    com01.ExecuteNonQuery();
                }
            }

            if (Genre.Text != "")
            {
                SqlCeCommand com02 = new SqlCeCommand("Select * from Genre WHERE Name = '" + Genre.Text + "'", con);
                SqlCeDataReader reader02 = com02.ExecuteReader();
                if (!reader02.Read())
                {
                    SqlCeCommand com03 = new SqlCeCommand("INSERT INTO Genre(Name) VALUES ('"
                                + Genre.Text + "')", con);
                    com03.ExecuteNonQuery();
                }
            }


            if (Puth.Text != "" && NameBook.Text != "")
            {
                SqlCeCommand com1 = new SqlCeCommand("Select * from Users_Books WHERE Book = '" + NameBook.Text + "'", con);
                SqlCeDataReader reader1 = com1.ExecuteReader();

                if (!reader1.Read())
                {
                    SqlCeCommand com2 = new SqlCeCommand("INSERT INTO Users_Books (Book, Profile) VALUES ('"
                            + NameBook.Text + "', "
                            + "'" + name + "')", con);
                    com2.ExecuteNonQuery();

                    SqlCeCommand com3 = new SqlCeCommand("Select * from Books WHERE Name = '" + NameBook.Text + "'", con);
                    SqlCeDataReader reader3 = com3.ExecuteReader();

                    if (!reader3.Read())
                    {
                        SqlCeCommand com4 = new SqlCeCommand("INSERT INTO Books (Name, Author, Genre, Address) VALUES ('"
                            + NameBook.Text + "', "
                            + "'" + Author.Text + "', "
                            + "'" + Genre.Text + "', "
                            + "'" + Puth.Text + "')", con);
                        com4.ExecuteNonQuery();
                    }
                }
                Form2 form2 = new Form2(name);
                form2.Show();
                this.Hide();
            }
            else
            {
                Message.Text = "Не введенны параметры";
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 form2 = new Form2(name);
            form2.Show();
            this.Hide();
        }
    }
}
