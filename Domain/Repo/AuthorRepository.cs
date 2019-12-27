using Dapper;
using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repo
{
    public class AuthorRepository : IRepository<AuthorResult>
    {
        private string _conString;
        public AuthorRepository(string conString)
        {
            _conString = conString;
        }
        public async Task DeleteRowAsync(int id)
        {
            using (var _connection = new SQLiteConnection(_conString))
            {               
                await _connection.ExecuteAsync(@"DELETE FROM Authors WHERE Id = @Id", new { Id = id });
            }
        }
        public async Task<IEnumerable<AuthorResult>> GetAllAsync()
        {
            string query = $"SELECT a.Id, a.Name, a.Surname, c.Name as CountryName FROM Authors a " +                 
                 $"INNER JOIN Country c ON a.CountryId = c.Id;";

            using (var _connection = new SQLiteConnection(_conString))
            {
                return await _connection.QueryAsync<AuthorResult>(query);
            }
        }

        public async Task<AuthorResult> GetAsync(int id)
        {
            string query = $"SELECT a.Id, a.Name, a.Surname, c.Name as CountryName FROM Authors a INNER JOIN Country c ON a.CountryId = c.Id WHERE a.Id = @Id;";

            using (var _connection = new SQLiteConnection(_conString))
            {
                return await _connection.QueryFirstAsync<AuthorResult>(query, new { Id = id });
            }
        }        

        public async Task UpdateAsync(AuthorResult a)
        {
            var query = $"UPDATE Authors SET Name = @Name, Surname = @Surname  WHERE Id = @Id";
            using (var _connection = new SQLiteConnection(_conString))
            {
                await _connection.QueryAsync(query, new { Id = a.Id, Name = a.Name, Surname = a.Surname });
            }
        }
    }
}
