using backend.Entities;

namespace backend.Contracts
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetUsers();
    }
}
