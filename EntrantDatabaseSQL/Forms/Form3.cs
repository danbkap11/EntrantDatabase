using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrantDatabaseSQL
{
    public partial class Form3 : Form
    {
        List<string> comboList = new List<string>();
        List<string> comboList2 = new List<string>();
        Dictionary<int, string> choices = new Dictionary<int, string>
        {
            [0] = "PriceD",
            [1] = "PriceC",
            [2] = "PriceN",
            [3] = "CompetitionD",
            [4] = "CompetitionC",
            [5] = "CompetitionN"
        };
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KRPS\source\repos\EntrantDatabaseSQL\EntrantDatabaseSQL\Database1.mdf;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
            if (database1DataSet != null)
            {
                this.database1DataSet.Reset();
                this.specialitiesTableAdapter.Fill(this.database1DataSet.Specialities);
                this.universitiesTableAdapter1.Fill(this.database1DataSet.Universities);
            }

            if (database1DataSet1 != null)
            {
                this.database1DataSet1.Reset();
                this.universitiesTableAdapter.Fill(this.database1DataSet1.Universities);
                this.specialitiesTableAdapter1.Fill(this.database1DataSet1.Specialities);
            }
            findDistinct();
            findUniversities();
            this.comboBox2.SelectedItem = comboBox2.Items[0];
            this.comboBox4.SelectedItem = comboBox4.Items[0];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData(string Name, string Column)
        {
            dataGridView1.Rows.Clear();

            SqlConnection myConnection = new SqlConnection(connectionString);
            int Id = 0;
            myConnection.Open();
            string qry = $"SELECT Id FROM Universities WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(qry, myConnection);
            cmd.Parameters.AddWithValue("Name", Name);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Id = (int)rdr[0];
            }
            rdr.Close();
            string query = $"SELECT Name, CompetitionD, CompetitionC, CompetitionN, PriceD, PriceC, PriceN FROM Specialities WHERE UniversityId = {Id} ORDER BY {Column}";
                
            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void LoadDataSpec(string Name, string Column)
        {
            dataGridView2.Rows.Clear();

            SqlConnection myConnection = new SqlConnection(connectionString);

            myConnection.Open();

            string query = "SELECT Universities.Name, Specialities.CompetitionD, Specialities.CompetitionC, Specialities.CompetitionN, " +
                           "Specialities.PriceD, Specialities.PriceC, Specialities.PriceN " +
                           "FROM Universities INNER JOIN Specialities ON Specialities.UniversityId = Universities.Id " +
                           $"WHERE Specialities.Name = @Name ORDER BY {Column}";

            SqlCommand command = new SqlCommand(query, myConnection);
            command.Parameters.AddWithValue("Name", Name);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(comboBox1.SelectedItem.ToString(), choices[comboBox2.SelectedIndex]);
            findDistinct();
        }

        private void findDistinct()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if(comboBox3.Items != null) comboBox3.Items.Clear();
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
                    comboBox3.Items.Add(x);
                }
                reader.Close();
                comboBox3.SelectedItem = comboBox3.Items[0];
            }
        }

        private void findUniversities()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (comboBox1.Items != null) comboBox1.Items.Clear();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Name FROM Universities";
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboList2.Add(reader[0].ToString());
                }

                foreach (var x in comboList2)
                {
                    comboBox1.Items.Add(x);
                }
                reader.Close();
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataSpec(comboBox3.SelectedItem.ToString(), choices[comboBox4.SelectedIndex]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            string savingDate = DateTime.Now.ToString().Replace('.', ' ').Replace(':', '.');
            using (var newBitmap = new Bitmap(bitmap))
            {
                newBitmap.Save($@"c:\EntrantDB\Університет{savingDate}.jpeg", ImageFormat.Jpeg);
            }
            MessageBox.Show($"Збережено до Університет {savingDate}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            string savingDate = DateTime.Now.ToString().Replace('.', ' ').Replace(':', '.');
            using (var newBitmap = new Bitmap(bitmap))
            {
                newBitmap.Save($"C:\\EntrantDB\\Спеціальності{savingDate}.jpeg", ImageFormat.Jpeg);
            }
            MessageBox.Show($"Збережено до Спеціальності  {savingDate}");
        }
    }
}
