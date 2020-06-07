using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrantDatabaseSQL
{
    class SpecialityRepo
    {
        private SpecialityRepo()
        {

        }

        private static SpecialityRepo specialityRepo;

        public static SpecialityRepo GetInstance()
        {
            if (specialityRepo == null)
            {
                specialityRepo = new SpecialityRepo();
            }

            return specialityRepo;
        }

        public void Create(Speciality speciality, SqlConnection sqlConnection)
        {
            SqlCommand command =
                new SqlCommand("INSERT INTO [Specialities] (Name, CompetitionD, CompetitionC, CompetitionN, PriceD, PriceC, PriceN, UniversityId)" +
                               " VALUES(@Name, @CompetitionD, @CompetitionC, @CompetitionN, @PriceD, @PriceC, @PriceN, @UniversityId)", sqlConnection);
            command.Parameters.AddWithValue("Name", speciality.Name);
            command.Parameters.AddWithValue("UniversityId", speciality.UniversityId);
            command.Parameters.AddWithValue("CompetitionD", speciality.CompetitionD);
            command.Parameters.AddWithValue("CompetitionC", speciality.CompetitionC);
            command.Parameters.AddWithValue("CompetitionN", speciality.CompetitionN);
            command.Parameters.AddWithValue("PriceD", speciality.PriceD);
            command.Parameters.AddWithValue("PriceC", speciality.PriceC);
            command.Parameters.AddWithValue("PriceN", speciality.PriceN);
            command.ExecuteNonQuery();
        }

        public void Update(Speciality speciality, SqlConnection sqlConnection)
        { 
        SqlCommand command =
                new SqlCommand("UPDATE [Specialities] SET [Name] = @Name, [CompetitionD] = @CompetitionD, [CompetitionC] = @CompetitionC," +
                               " [CompetitionN] = @CompetitionN, [PriceD] = @PriceD, [PriceC] = @PriceC, [PriceN] = @PriceN, [UniversityId] = @UniversityId WHERE [Id] = @Id"
                    , sqlConnection);
            command.Parameters.AddWithValue("Name", speciality.Name);
            command.Parameters.AddWithValue("CompetitionD", speciality.CompetitionD);
            command.Parameters.AddWithValue("CompetitionC", speciality.CompetitionC);
            command.Parameters.AddWithValue("CompetitionN", speciality.CompetitionN);
            command.Parameters.AddWithValue("PriceD", speciality.PriceD);
            command.Parameters.AddWithValue("PriceC", speciality.PriceC);
            command.Parameters.AddWithValue("PriceN", speciality.PriceN);
            command.Parameters.AddWithValue("UniversityId", speciality.UniversityId);
            command.Parameters.AddWithValue("Id", speciality.Id);
            command.ExecuteNonQueryAsync();

        }

        public void Delete(Speciality speciality, SqlConnection sqlConnection)
        {
            SqlCommand command =
                new SqlCommand("DELETE FROM [Specialities] WHERE [Id] = @Id", sqlConnection);

            command.Parameters.AddWithValue("Id", speciality.Id);
            command.ExecuteNonQueryAsync();
        }

        public void DeleteByUniversityId(Speciality speciality, SqlConnection sqlConnection)
        {
            SqlCommand command2 =
                new SqlCommand("DELETE FROM [Specialities] WHERE [UniversityId] = @UniversityId", sqlConnection);

            command2.Parameters.AddWithValue("UniversityId", speciality.UniversityId); 
            command2.ExecuteNonQuery();
        }
    }
}
