using System.Collections.Generic;
using System.Threading.Tasks;
using MeetMeApp.API.Models;

namespace MeetMeApp.API.Data
{
    public interface IMeetRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}