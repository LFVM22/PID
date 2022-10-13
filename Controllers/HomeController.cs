using System.Diagnostics;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Projeto.Controllers;

public class HomeController : Controller
{
    private DataContext _db;
    public HomeController(DataContext db){
        _db = db;
    }

    //Tela Principal
    public IActionResult Index()
    {
        return View();
    }

    //Exibir Fichas
    [HttpGet]
    public IActionResult ExibirFicha()
    {
        ViewBagdeCria();
        var var = _db.Personagens.AsNoTracking().ToList();
        return View(var);
    }
    public void ViewBagdeCria(){
        var listaraca = _db.Racas.AsNoTracking().ToList();
        var listausuario = _db.Usuarios.AsNoTracking().ToList();
        var listasubraca = _db.SubRacas.AsNoTracking().ToList();
        ViewBag.Listaraca = listaraca;
        ViewBag.listausuario = listausuario;
        ViewBag.listasubraca = listasubraca;

        var listaclasse = _db.Classes.AsNoTracking().ToList();
        ViewBag.listaclasse = listaclasse;
    }

    //Excluir Personagem
    [HttpGet]
    public ActionResult ExcluirFicha(int IdPersonagem){
        var var = _db.Personagens.Find(IdPersonagem);
        if (var is null)
            return RedirectToAction("Index");

        return View(var);
    }
    [HttpPost]
    public ActionResult ProcessarExcluir(int IdPersonagem){
        var var = _db.Personagens.Find(IdPersonagem);
        if (var is null){
            return RedirectToAction("Index");
        }
        _db.Personagens.Remove(var);
        _db.SaveChanges();
        return RedirectToAction("ExibirFicha");
    }
}
