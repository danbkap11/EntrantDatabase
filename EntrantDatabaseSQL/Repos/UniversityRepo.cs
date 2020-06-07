using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrantDatabaseSQL
{
    class UniversityRepo
    {
        private UniversityRepo()
        {

        }

        private static UniversityRepo universityRepo;

        public static UniversityRepo GetInstance()
        {
            if (universityRepo == null)
            {
                universityRepo = new UniversityRepo();
            }

            return universityRepo;
        }

        public async void Create(University university, SqlConnection sqlConnection)
        {
            SqlCommand command =
                new SqlCommand("INSERT INTO [Universities] (Name, Address) VALUES(@Name, @Address)", sqlConnection);
            command.Parameters.AddWithValue("Name", university.Name);
            command.Parameters.AddWithValue("Address", university.Address);
            await command.ExecuteNonQueryAsync();
        }

        public void Update(University university, SqlConnection sqlConnection)
        {
            SqlCommand command =
                new SqlCommand("UPDATE [Universities] SET [Name] = @Name, [Address] = @Address WHERE [Id] = @Id", sqlConnection);
            command.Parameters.AddWithValue("Name", university.Name);
            command.Parameters.AddWithValue("Address", university.Address);
            command.Parameters.AddWithValue("Id", university.Id);
            command.ExecuteNonQueryAsync();
        }

        public void Delete(University university, SqlConnection sqlConnection)
        {
            SqlCommand command =
                new SqlCommand("DELETE FROM [Universities] WHERE [Id] = @Id", sqlConnection);
            command.Parameters.AddWithValue("Id", university.Id);
            command.ExecuteNonQuery();
        }
    }
}
