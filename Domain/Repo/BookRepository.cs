using Dapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Dapper.Contrib;
using System.Threading.Tasks;
using Domain.Dto;

namespace Domain.Repo
{
    public class BookRepository : IRepository<BookResult>
    {
        private string _conString;

        public BookRepository(string conString)
        {
            _conString = conString;
        }

        public async Task DeleteRowAsync(int id)
        {
            using (var _connection = new SQLiteConnection(_conString))
            {
                await _connection.ExecuteAsync(@"DELETE FROM Books WHERE Id = @Id", new { Id = id });
            }
        }

        public async Task<IEnumerable<BookResult>> GetAllAsync()
        {
            string query = $"SELECT b.Id, b.Title, a.Name, a.Surname, b.Date, c.Name as CountryName FROM Books b " +
                $"INNER JOIN Authors a ON b.AuthorId = a.Id " +
                $"INNER JOIN Country c ON a.CountryId = c.Id;";

            using (var _connection = new SQLiteConnection(_conString))
            {
                return await _connection.QueryAsync<BookResult>(query);
            }
        }

        public async Task<BookResult> GetAsync(int id)
        {
            string query = $"SELECT b.Id, b.Title, a.Name, a.Surname, b.Date, c.Name as CountryName FROM Books b " +
                $"INNER JOIN Authors a ON b.AuthorId = a.Id " +
                $"INNER JOIN Country c ON a.CountryId = c.Id " +
                $"WHERE b.Id = @Id;";

            using (var _connection = new SQLiteConnection(_conString))
            {
                return await _connection.QueryFirstAsync<BookResult>(query, new { Id = id});
            }
        }              

        public async Task UpdateAsync(BookResult t)
        {
            var query = $"UPDATE Books SET Title = @Title, Date = @Date  WHERE Id = @Id"; 
            using (var _connection = new SQLiteConnection(_conString))
            {
                await _connection.QueryAsync(query, new { Id = t.Id, Title = t.Title, Date = t.Date});
            }
        }
    }
}
