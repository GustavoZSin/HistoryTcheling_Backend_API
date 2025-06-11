using HistoryTcheling_Backend.Domain.Entities;
using HistoryTcheling_Backend.Domain.Interfaces.Mappers;
using HistoryTcheling_Backend.Domain.Interfaces.Repositories;
using HistoryTcheling_Backend.Infraestructure.Persistence.Context;
using HistoryTcheling_Backend.Infraestructure.Persistence.Models;

namespace HistoryTcheling_Backend.Infraestructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HistoryTchelingContext _context;

        public UserRepository(HistoryTchelingContext context)
        {
            _context = context;
        }

        public int CreateUser(string userName, string userEmail, string userHashPass)
        {
            UserModel userModel = new UserModel() { Name = userName, Email = userEmail, HashPass = userHashPass , IdAddress = 6};
            _context.Users.Add(userModel);
            _context.SaveChanges();

            return userModel.Id;
        }

        public (bool, int) ValidateUser(string userEmail, string passHash)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == userEmail && x.HashPass == passHash);

            if (user == null)
                return (false, 0);

            return (true, user.Id);
        }
    }
}
