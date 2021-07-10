using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlServerCe;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        SqlCeConnection con = new SqlCeConnection(@"data source=" + Environment.CurrentDirectory + @"\Library.sdf");

        private string name, book, path;
        private int countPage = 0, numPage = 0, numMark = 0;
        string[] strings;
        int[] bookmarks;

        public Form3(string nameProfile, string nameBook)
        {
            InitializeComponent();
            con.Open();
            name = nameProfile;
            book = nameBook;
            LabelName.Text = book;

            SqlCeCommand com1 = new SqlCeCommand("SELECT * FROM Books WHERE Name = '" + book + "'", con);
            SqlCeDataReader reader1 = com1.ExecuteReader();
            reader1.Read();
            path = reader1[3].ToString();

            int n = 0;

            StreamReader sr=new StreamReader(path);
            string line;
            while (!sr.EndOfStream)
            {
                n++;
                line=sr.ReadLine();
            }
            sr.Close();

            int i=0;
            while (n>i) i+= 10;
            countPage = i/10;

            strings = new string [n];
            n = 0;

            StreamReader sr1 = new StreamReader(path, Encoding.GetEncoding(1251));
            while (!sr1.EndOfStream)
            {
                strings[n] = sr1.ReadLine();
                n++;
            }
            sr1.Close();

            ToPage(0);

            update_bookmarks();
        }

        void update_bookmarks()
        {
            SqlCeCommand com2 = new SqlCeCommand("SELECT COUNT(Book) FROM Bookmarks WHERE Book = '"
                    + book + "' AND Profile = '" + name + "'", con);
            com2.ExecuteNonQuery();

            SqlCeDataReader reader2 = com2.ExecuteReader();

            int nB = 0;
            if (reader2.Read())
                nB = (int)reader2[0];

            SqlCeCommand com3 = new SqlCeCommand("SELECT * FROM Bookmarks WHERE Book = '"
                    + book + "' AND Profile = '" + name + "' ORDER BY Page", con);
            com3.ExecuteNonQuery();

            SqlCeDataReader reader3 = com3.ExecuteReader();

            bookmarks = new int[nB];

            int j = 0;
            while (reader3.Read())
            {
                bookmarks[j] = (int)reader3[1];
                j++;
            }
        }

        void ToPage(int _page)
        {
            if (_page >= 0 && _page < countPage)
            {
                Reader.Text = "";

                numPage = _page;
                int mn=10, finalStr, startStr;

                startStr = mn * numPage;

                if (_page * mn + mn >= countPage * mn)
                    finalStr = strings.Length;
                else
                    finalStr = startStr + mn;

                for (int i = startStr; i < finalStr; i++)
                    Reader.Text += "        " + strings[i] + Environment.NewLine;

                Page.Text = (numPage+1) + "/" + countPage;
            }
        }

        private void PageDown_Click(object sender, EventArgs e)
        {
            ToPage(numPage + 1);
        }

        private void PageUp_Click(object sender, EventArgs e)
        {
            ToPage(numPage - 1);
        }

        private void markNext_Click(object sender, EventArgs e)
        {
            if (numMark+1<bookmarks.Length)
            {
                numMark++;
                ToPage(bookmarks[numMark]);
            }
        }

        private void markPast_Click(object sender, EventArgs e)
        {
            if (numMark - 1 > -1)
            {
                numMark--;
                ToPage(bookmarks[numMark]);
            }
        }

        private void AddMark_Click(object sender, EventArgs e)
        {
            SqlCeCommand com1 = new SqlCeCommand("SELECT * FROM Bookmarks WHERE Book = '"
                    + book + "' AND Profile = '" + name + "' AND Page = '" + numPage + "'", con);
            com1.ExecuteNonQuery();

            SqlCeDataReader reader1 = com1.ExecuteReader();

            if (!reader1.Read())
            {
                SqlCeCommand com2 = new SqlCeCommand("INSERT INTO Bookmarks (Book, Page, Profile) VALUES ('"
                    + book + "', '" + numPage + "', '" + name +"')", con);
                com2.ExecuteNonQuery();

                update_bookmarks();
            }
        }

        private void DeleteMark_Click(object sender, EventArgs e)
        {
            SqlCeCommand com1 = new SqlCeCommand("SELECT * FROM Bookmarks WHERE Book = '"
                    + book + "' AND Profile = '" + name + "' AND Page = '" + numPage + "'", con);
            com1.ExecuteNonQuery();

            SqlCeDataReader reader1 = com1.ExecuteReader();

            if (reader1.Read())
            {
                SqlCeCommand com2 = new SqlCeCommand(
                    "DELETE FROM Bookmarks WHERE Book = '"
                    + book + "' AND Profile = '" + name + "' AND Page = '" + numPage + "'", con);
                com2.ExecuteNonQuery();

                update_bookmarks();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ColorText_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog(this) == DialogResult.OK)
            {
                Reader.ForeColor = cd.Color;
            }
        }

        private void BackColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog(this) == DialogResult.OK)
            {
                Reader.BackColor = cd.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Reader.Font = new Font(Reader.Font.Name, (int)numericUpDown1.Value, Reader.Font.Style);
            //Reader.Font.Height = (int)numericUpDown1.Value;
        }
    }
}
