using Microsoft.Data.SqlClient;
using Roommates.Models;
using System.Collections.Generic;

namespace Roommates.Repositories
{
    public class RoommateRepository : BaseRepository
    {
        public RoommateRepository(string connectionString) : base(connectionString) { }

        public Roommate GetById(int id)
        { 
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cd = conn.CreateCommand())
                {
                }
    }
}
