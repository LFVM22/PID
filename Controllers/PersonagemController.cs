using Data;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

public class PersonagemController : Controller
{
    private DataContext _db;
    public PersonagemController(DataContext db)
    {
        _db = db;
    }
    [HttpGet]
    public ActionResult InserirBio()
    {
        var personagem = new Personagem();
        return View(personagem);
    }
    [HttpPost]
    public ActionResult InserirBio(Personagem personagem)
    {
        if (!ModelState.IsValid)
        {
            return View(personagem);
        }
        _db.Personagens.Add(personagem);
        _db.SaveChanges();
        return RedirectToAction("Escolher", "Raca", new { personagem.IdPersonagem });
    }
}