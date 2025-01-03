using backend.Context;
using backend.Contracts;
using backend.Entities;
using Dapper;

namespace backend.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var query = "SELECT * FROM exercise_logging.user";

            using (var connection = _context.CreateConnection())
            {
                var users = await connection.QueryAsync<User>(query);

                return users.ToList();

            }
        }
    }
}
