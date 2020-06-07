using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrantDatabaseSQL
{
    public partial class Form1 : Form
    {
        private List<string> comboList = new List<string>();
        public SqlConnection sqlConnection;
        public string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KRPS\source\repos\EntrantDatabaseSQL\EntrantDatabaseSQL\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            if (database1DataSet1 != null)
            {
                this.database1DataSet1.Reset();
                this.specialitiesTableAdapter.Fill(this.database1DataSet1.Specialities);
                this.universitiesTableAdapter.Fill(this.database1DataSet1.Universities);
            }
            LoadData();
            findDistinct();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Specialities' table. You can move, or remove it, as needed.
            this.specialitiesTableAdapter1.Fill(this.database1DataSet.Specialities);
            // TODO: This line of code loads data into the 'database1DataSet.Universities' table. You can move, or remove it, as needed.
            this.universitiesTableAdapter1.Fill(this.database1DataSet.Universities);
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
        }

        private void LoadData()
        {
            dataGridView1.Rows.Clear();

            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            string query = "SELECT Universities.Id, Universities.Name, Universities.Address, Specialities.Id, Specialities.Name, Specialities.CompetitionD, Specialities.CompetitionC, Specialities.CompetitionN, " +
                           "Specialities.PriceD, Specialities.PriceC, Specialities.PriceN " +
                           "FROM Universities INNER JOIN Specialities ON Specialities.UniversityId = Universities.Id ORDER BY Universities.Id";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[11]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                University university = new University(textBox1.Text, textBox2.Text); 
                UniversityRepo.GetInstance().Create(university, sqlConnection);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox3.DataSource = universitiesBindingSource;
                comboBox3.ResetBindings();
            }
            else
            {
                label25.Visible = true;
                label25.Text = "Заповніть всі поля";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label26.Visible = false;
            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                Speciality speciality = new Speciality(textBox4.Text, Convert.ToInt32(comboBox3.SelectedValue), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox6.Text),
                    Convert.ToDouble(textBox5.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox9.Text));
                SpecialityRepo.GetInstance().Create(speciality, sqlConnection);
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";

            }
            else
            {
                label26.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            University university = new University(textBox12.Text, Convert.ToInt32(comboBox2.SelectedValue), textBox11.Text);
            UniversityRepo.GetInstance().Update(university, sqlConnection);
            textBox11.Text = "";
            textBox12.Text = "";
            //comboBox2.DataSource = new List<object>();
            comboBox2.DataSource = universitiesBindingSource1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label28.Visible = false;

            int SpecId;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Id FROM Specialities WHERE UniversityId = @Id AND Name = @Name";
                connection.Open();
                cmd.Parameters.AddWithValue("Id", Convert.ToInt32(comboBox6.SelectedValue));
                cmd.Parameters.AddWithValue("Name", Convert.ToString(comboBox7.SelectedItem));
                SpecId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            if (!string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrWhiteSpace(textBox21.Text))
            {
                Speciality speciality = new Speciality(textBox21.Text, SpecId, Convert.ToInt32(comboBox8.SelectedValue),
                    Convert.ToDouble(textBox20.Text), Convert.ToDouble(textBox19.Text), Convert.ToDouble(textBox18.Text),
                    Convert.ToInt32(textBox17.Text), Convert.ToInt32(textBox16.Text), Convert.ToInt32(textBox15.Text));
                SpecialityRepo.GetInstance().Update(speciality, sqlConnection);
                textBox21.Text = "";
                textBox20.Text = "";
                textBox19.Text = "";
                textBox18.Text = "";
                textBox17.Text = "";
                textBox16.Text = "";
                textBox15.Text = "";
            }
            else
            {
                label28.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label29.Visible = false;
            Speciality speciality = new Speciality(Convert.ToInt32(comboBox1.SelectedValue));
            SpecialityRepo.GetInstance().DeleteByUniversityId(speciality, sqlConnection); 
            University university = new University(Convert.ToInt32(comboBox1.SelectedValue)); 
            UniversityRepo.GetInstance().Delete(university, sqlConnection);
        }
        private void findDistinct()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (comboBox5.Items != null) comboBox5.Items.Clear();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Name FROM Specialities";
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboList.Add(reader[0].ToString());
                }

                foreach (var x in comboList.Distinct().ToList())
                {
                    comboBox5.Items.Add(x);
                    comboBox7.Items.Add(x);
                }
                reader.Close();
                comboBox5.SelectedItem = comboBox5.Items[0];
                comboBox7.SelectedItem = comboBox7.Items[0];
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int SpecId;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Id FROM Specialities WHERE UniversityId = @Id AND Name = @Name";
                connection.Open();
                cmd.Parameters.AddWithValue("Id", Convert.ToInt32(comboBox4.SelectedValue));
                cmd.Parameters.AddWithValue("Name", Convert.ToString(comboBox5.SelectedItem));
                SpecId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            Speciality speciality = new Speciality(SpecId, true);
            SpecialityRepo.GetInstance().Delete(speciality, sqlConnection);
            findDistinct();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            if (database1DataSet1 != null)
            {
                this.database1DataSet1.Reset();
                this.specialitiesTableAdapter.Fill(this.database1DataSet1.Specialities);
                this.universitiesTableAdapter.Fill(this.database1DataSet1.Universities);
            }
            LoadData();
        }

        
    }
}
