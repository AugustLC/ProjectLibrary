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
    public partial class Form1 : Form
    {
        //Создание объекта для установления соединения с БД
        SqlCeConnection con = new SqlCeConnection(@"data source=" + Environment.CurrentDirectory + @"\Library.sdf");

        public Form1()
        {
            InitializeComponent();
            //Открытие подключения к базе данных
            con.Open();

            SqlCeCommand com = new SqlCeCommand("Select * from Profiles", con);
            //Создание объекта для чтения табличного результата запроса SELECT
            SqlCeDataReader reader = com.ExecuteReader();
            //Построчное считывание ответа результата запроса SELECT
            //и обновление элементов ComboBox
            while (reader.Read())
            {
                profiles.Items.Add(reader[0]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                NewProfile.Enabled = true;
                NewPassword.Enabled = true;
                CreateProfile.Enabled = true;
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (profiles.SelectedIndex != -1)
            {
                SqlCeCommand com = new SqlCeCommand("Select * from Profiles WHERE Name = '" + profiles.Items[profiles.SelectedIndex].ToString() + "'", con);
                //Создание объекта для чтения табличного результата запроса SELECT
                SqlCeDataReader reader = com.ExecuteReader();
                //Построчное считывание ответа результата запроса SELECT
                //и обновление элементов ComboBox
                reader.Read();
                if (Password.Text == reader[1].ToString())
                {
                    Form2 form2 = new Form2(profiles.Items[profiles.SelectedIndex].ToString());
                    form2.Show();
                    this.Hide();
                }
                else
                    Message.Text = "Неправильный пароль или логин";
            }
            else
            {
                Message.Text = "Не выбрана учетная запись";
            }
        }

        private void CreateProfile_Click(object sender, EventArgs e)
        {
            SqlCeCommand com = new SqlCeCommand("Select * from Profiles WHERE Name = '" + NewProfile.Text + "'", con);
            //Создание объекта для чтения табличного результата запроса SELECT
            SqlCeDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                Message.Text = "Такой профиль уже существует";
            }
            else
            {
                SqlCeCommand com1 = new SqlCeCommand("INSERT INTO Profiles (Name, Password) VALUES ('"
                    + NewProfile.Text + "', "
                    + "'" + NewPassword.Text + "')", con);
                com1.ExecuteNonQuery();
                Form2 form2 = new Form2(NewProfile.Text);
                form2.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            Application.Exit();
        }
    }
}
