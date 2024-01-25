using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using portal.Models;
using portal.Services;

namespace portal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly MainDAO _mainDAO;

    public HomeController(ILogger<HomeController> logger, MainDAO mainDAO)
    {
        _logger = logger;
        _mainDAO = mainDAO;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return PartialView();
    }

    public IActionResult Livros()
    {
        List<LivroModel> livros = _mainDAO.GetBooks();
        
        return View(livros);
    }

    public IActionResult Usuarios()
    {
        List<UsuarioModel> usuarios = _mainDAO.GetUsers();
        
        return View(usuarios);
    }

    public IActionResult MarcarLido(int idLivro, int idUsuario)
    {
        _mainDAO.MarcarLido(idLivro, idUsuario);
        return Ok();
    }
}
