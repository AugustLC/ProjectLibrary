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
    public partial class Form2 : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"data source=" + Environment.CurrentDirectory + @"\Library.sdf");

        private string name;

        private int requme = 0;

        public Form2(string nameProfile)
        {
            InitializeComponent();
            con.Open();
            name = nameProfile;
            Profile.Text = name;

            SqlCeCommand com1 = new SqlCeCommand("Select * from Users_Books WHERE Profile = '" + name + "'", con);
            //Создание объекта для чтения табличного результата запроса SELECT
            SqlCeDataReader reader = com1.ExecuteReader();
            while (reader.Read())
            {
                ListBook.Items.Add(reader[0]);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            Application.Exit();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(name);
            form4.Show();
            this.Hide();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            if (ListBook.SelectedIndex != -1)
            {
                string book = ListBook.Items[ListBook.SelectedIndex].ToString();
                Form3 form3 = new Form3(name, book);
                form3.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            if (ListBook.SelectedIndex != -1)
            {
                string book = ListBook.Items[ListBook.SelectedIndex].ToString();

                SqlCeCommand com = new SqlCeCommand("DELETE FROM Users_Books WHERE Book = '"
                    + book + "'", con);
                com.ExecuteNonQuery();

                SqlCeCommand com1 = new SqlCeCommand("Select * from Users_Books WHERE Book = '" + book + "'", con);
                //Создание объекта для чтения табличного результата запроса SELECT
                SqlCeDataReader reader = com1.ExecuteReader();
                if (!reader.Read())
                {
                    SqlCeCommand com2 = new SqlCeCommand("DELETE FROM Books WHERE Name = '"
                    + book + "'", con);
                    com2.ExecuteNonQuery();
                }

                ListBook.Items.Clear();
                SqlCeCommand com3 = new SqlCeCommand("Select * from Users_Books WHERE Profile = '" + name + "'", con);
                //Создание объекта для чтения табличного результата запроса SELECT
                SqlCeDataReader reader3 = com3.ExecuteReader();
                while (reader3.Read())
                {
                    ListBook.Items.Add(reader3[0]);
                }
            }
        }

        private void AuthorSelect_Click(object sender, EventArgs e)
        {
            SelectAutOrGen.Items.Clear();

            SelectAutOrGen.Visible = true;
            SelectButton.Visible = true;
            SqlCeCommand com1 = new SqlCeCommand("Select * from Author", con);
            //Создание объекта для чтения табличного результата запроса SELECT
            SqlCeDataReader reader = com1.ExecuteReader();
            while (reader.Read())
            {
                SelectAutOrGen.Items.Add(reader[0]);
            }
            requme = 0;
        }

        private void GenreSelect_Click(object sender, EventArgs e)
        {
            SelectAutOrGen.Items.Clear();

            SelectAutOrGen.Visible = true;
            SelectButton.Visible = true;
            SqlCeCommand com1 = new SqlCeCommand("Select * from Genre", con);
            //Создание объекта для чтения табличного результата запроса SELECT
            SqlCeDataReader reader = com1.ExecuteReader();
            while (reader.Read())
            {
                SelectAutOrGen.Items.Add(reader[0]);
            }
            requme = 1;
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (SelectAutOrGen.SelectedIndex != -1)
            {
                ListBook.Items.Clear();

                SelectAutOrGen.Visible = false;
                SelectButton.Visible = false;
                string command;
                if (requme == 0)
                {
                    command = "Select * from Books WHERE Genre = '" + SelectAutOrGen.Items[SelectAutOrGen.SelectedIndex].ToString() + "'";
                }
                else
                {
                    command = "Select * from Books WHERE Author = '" + SelectAutOrGen.Items[SelectAutOrGen.SelectedIndex].ToString() + "'";
                }

                SqlCeCommand com1 = new SqlCeCommand(command, con);
                //Создание объекта для чтения табличного результата запроса SELECT
                SqlCeDataReader reader1 = com1.ExecuteReader();

                while (reader1.Read())
                {
                    SqlCeCommand com2 = new SqlCeCommand("Select * from Users_Books WHERE Book = '" + reader1[0] + "'", con);
                    //Создание объекта для чтения табличного результата запроса SELECT
                    SqlCeDataReader reader2 = com2.ExecuteReader();
                    if (reader2.Read())
                        ListBook.Items.Add(reader1[0]);
                }
            }
        }
    }
}
