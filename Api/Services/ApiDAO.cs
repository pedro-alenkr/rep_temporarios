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

            if(user == null) throw new Exception(ApiMsg.EXC0003);
            
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
        
        public ProductsModel Create(ProductsModel product)
        {
            _context.Products.Add(product);   
            _context.SaveChanges();

            return product;
        }

        public void Update(ProductsModel product)
        {
            if(_context.Products.Any(x=>x.Id==product.Id))
            {
                _context.Products.Update(product);
                _context.SaveChanges();
            }
            else throw new Exception(ApiMsg.EXC0001);
        }

        public void DeleteProductById(long id)
        {
            ProductsModel? product = _context.Products.Find(id);

            if(product == null) throw new Exception(ApiMsg.EXC0001);
            
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<ProductsModel> GetProductsByName(string name)
        {
            List<ProductsModel>? products = _context.Products.Where(x=> x.Name.Contains(name)).ToList();

            if(products == null) throw new Exception(ApiMsg.EXC0001);

            return products;
        }

        public List<ProductsModel> GetProducts()
        {
           return _context.Products.Where(x=>true).ToList() ;
        }
        
        public void ValidateProduct(ProductsModel product)
        {
            if((_context.Products.Any(x=> x.Name == product.Name || x.Description == product.Description && x.Id!=product.Id)))
                throw new Exception(ApiMsg.EXC0002);
        }
    }
}