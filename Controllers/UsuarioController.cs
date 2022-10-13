using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Projeto.Controllers;

public class UsuarioController : Controller
{
    private DataContext _db;
    public UsuarioController(DataContext db)
    {
        _db = db;
    }
    [HttpGet]
    public ActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Login(Usuario usuario, string login, string senha)
    {
        if (usuario.Login == login && usuario.Senha == senha)
        {
            return RedirectToAction("Index", "Home", new { usuario.IdUsuario });
        }
        else
        {
            return RedirectToAction("Index", "Home");
        }
    }
    [HttpGet]
    public ActionResult Cadastrar()
    {
        var usuario = new Usuario();
        return View(usuario);
    }
    [HttpPost]
    public ActionResult Cadastrar(Usuario usuario)
    {
        if(!ModelState.IsValid){
            return View(usuario);
        }
        _db.Usuarios.Add(usuario);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public ActionResult EsqueciaSenha()
    {
        return View();
    }
    // [HttpPost]
    // public ActionResult EsqueciaSenha(Usuario usuario, string senha)
    // {
    //     foreach(var users in usuario){

    //     }
    // }
    [HttpGet]
    public ActionResult Perfil(int IdUsuario){
        var usuario = _db.Usuarios.Find(IdUsuario);
        return View(usuario);
    }
}