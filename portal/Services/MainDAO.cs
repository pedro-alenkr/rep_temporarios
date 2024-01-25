using System.Collections.Generic;
using System.Linq;
using portal.Models;
using portal.Properties;

namespace portal.Services
{
    public class MainDAO
    {
        private readonly AppDbContext _context;

        public MainDAO(AppDbContext context){
            _context = context;
        }

        public List<UsuarioModel> GetUsers()
        {
           return _context.UserDAO.OrderByDescending(x=>x.Pontos).Take(10).ToList() ;
        }

        public List<LivroModel> GetBooks()
        {
           return _context.LivroDAO.Where(x=>true).ToList() ;
        }

        public void MarcarLido(int idLivro, int idUsuario)
        {
            //_context.LivroDAO.Where(x=>true).ToList() ;
        }
    }
}