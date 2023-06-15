using Api.Entities;
using Api.Models;
using Api.Properties;
using Npgsql;
namespace Api.Services
{
    public class ApiDAO
    {
        private readonly dbcontext _context;

        public ApiDAO(dbcontext context){
            _context = context;
        }
        
        public UsersModel Create(UsersModel user)
        {
            _context.Users.Add(user);   
            _context.SaveChanges();

            return user;
        }

        public void Update(UsersModel user)
        {
            if(_context.Users.Any(x=>x.Id==user.Id))
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            else throw new Exception(ApiMsg.EXC0003);
        }

        public void DeleteUserById(long id)
        {
            UsersModel? user = _context.Users.Find(id);

            if (user == null) throw new Exception(ApiMsg.EXC0003);
            
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public UsersModel GetUserByEmailAndPassword(string email, string password)
        {
            UsersModel? user = _context.Users.Where(x=> x.Email == email && x.Password == password).FirstOrDefault();

            if(user == null) throw new Exception(ApiMsg.EXC0003);

            return user;
        }

        public List<UsersModel> GetUsers()
        {
           return _context.Users.Where(x=>true).ToList() ;
        }

        public void ValidateUser(UsersModel user)
        {
            if((_context.Users.Any(x=> x.Email == user.Email || x.PhoneNumber == user.PhoneNumber && x.Id!=user.Id)))
                throw new Exception(ApiMsg.EXC0004);
        }
    }
}