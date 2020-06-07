using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntrantDatabaseSQL
{
    class Speciality
    {
        public Speciality(string name, int id, int universityid, double competitionD = 0,
            double competitionC = 0, double competitionN = 0, int priceD = 0, int priceC = 0, int priceN = 0)
        {
            Name = name;
            Id = id;
            UniversityId = universityid;
            CompetitionD = competitionD;
            CompetitionC = competitionC;
            CompetitionN = competitionN;
            PriceD = priceD;
            PriceC = priceC;
            PriceN = priceN;
        }
        public Speciality(string name, int universityid, double competitionD = 0,
            double competitionC = 0, double competitionN = 0, int priceD = 0, int priceC = 0, int priceN = 0)
        {
            Name = name;
            UniversityId = universityid;
            CompetitionD = competitionD;
            CompetitionC = competitionC;
            CompetitionN = competitionN;
            PriceD = priceD;
            PriceC = priceC;
            PriceN = priceN;
        }

        public Speciality(int universityId)
        {
            UniversityId = universityId;
        }

        public Speciality(int id, bool a)
        {
            Id = id;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int UniversityId { get; set; }
        public double CompetitionD { get; set; }
        public double CompetitionC { get; set; }
        public double CompetitionN { get; set; }
        public int PriceD { get; set; }
        public int PriceC { get; set; }
        public int PriceN { get; set; }
    }
}
