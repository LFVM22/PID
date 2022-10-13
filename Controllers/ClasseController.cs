using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;


namespace Projeto.Controllers;

public class ClasseController : Controller
{
    private DataContext _db;
    public ClasseController(DataContext db)
    {
        _db = db;
    }
    
    [HttpGet]
    public ActionResult Escolher(int IdPersonagem)
    {
        ViewBagdeCria();
        var personagem = _db.Personagens.Find(IdPersonagem);
        return View(personagem);
    }

    private void ViewBagdeCria()
    {
        var listaclasse = _db.Classes.AsNoTracking().ToList();
        var listatraco = _db.TracosdeClasse.AsNoTracking().ToList();
        var listaarquetipo = _db.Arquetipos.AsNoTracking().ToList();
        var listaclassetracosdeclasse = _db.Classes_TracosdeClasses.AsNoTracking().ToList();
        var listatracodeclassearquetipo = _db.TracosdeClasse_Arquetipos.AsNoTracking().ToList();
        var listaproficienciaarma = _db.Proficiencias_Armas.AsNoTracking().ToList();
        ViewBag.listaclasse = listaclasse;
        ViewBag.listatraco = listatraco;
        ViewBag.listaarquetipo = listaarquetipo;
        ViewBag.listaclassetracosdeclasse = listaclassetracosdeclasse;
        ViewBag.listatracodeclassearquetipo = listatracodeclassearquetipo;
        ViewBag.listaproficienciaarma = listaproficienciaarma;
    }
    
    [HttpPost]
    public ActionResult Escolher(int IdPersonagem, Personagem personagem)
    {
        List<int> profarmas = new List<int>();
        List<int> profarmaduras = new List<int>();
        List<int> profarmastipos = new List<int>();
        List<int> profarmadurastipos = new List<int>();
        List<int> profitens = new List<int>();

        var varoriginal = _db.Personagens.Find(IdPersonagem);

        if(personagem.IdClasse == 1){
            profarmadurastipos.AddRange(new int[]{1, 2, 4});
            profarmastipos.AddRange(new int[]{1, 2, 3, 4});
        }
        else if(personagem.IdClasse == 2){
            profarmastipos.AddRange(new int[]{1, 2});
            profarmas.AddRange(new int[]{33, 20, 18, 30});
        }
        else if(personagem.IdClasse == 3){
            profarmadurastipos.Add(1);
            profarmastipos.AddRange(new int[]{1, 2});
        }
        else if(personagem.IdClasse == 4){
            profarmadurastipos.AddRange(new int[]{1, 2, 4});
            profarmastipos.AddRange(new int[]{1, 2});
        }
        else if(personagem.IdClasse == 5){
            profarmadurastipos.AddRange(new int[]{1, 2, 4});
            profarmas.AddRange(new int[]{1, 2, 3, 4, 5, 6, 7, 13, 14, 16});
            profitens.Add(130);
        }
        else if(personagem.IdClasse == 6){
            profarmas.AddRange(new int[]{1, 3, 12, 13, 14});
        }
        else if(personagem.IdClasse == 7){
            profarmadurastipos.AddRange(new int[]{1, 2, 3, 4});
            profarmastipos.AddRange(new int[]{1, 2, 3, 4});
        }
        else if(personagem.IdClasse == 8){
            profarmadurastipos.Add(1);
            profarmastipos.AddRange(new int[]{1, 2});
            profarmas.AddRange(new int[]{18, 20, 30, 33});
        }
        else if(personagem.IdClasse == 9){
            profarmas.AddRange(new int[]{1, 3, 12, 13, 14});
        }
        else if(personagem.IdClasse == 10){
            profarmastipos.Add(1);
            profarmas.Add(18);
        }
        else if(personagem.IdClasse == 11){
            profarmadurastipos.AddRange(new int[]{1, 2, 3, 4});
            profarmastipos.AddRange(new int[]{1, 2, 3, 4});
        }
        else if(personagem.IdClasse == 12){
            profarmadurastipos.AddRange(new int[]{1, 2, 4});
            profarmastipos.AddRange(new int[]{1, 2, 3, 4});
        }

        if (varoriginal is null)
        {
            return RedirectToAction("Index", "Home");
        }
        if (personagem.IdClasse is null)
        {
            ViewBagdeCria();
            return View(personagem);
        }

        foreach (var profarma in profarmas)
        {
            var proficiencia_arma = new Proficiencia_Arma();
            proficiencia_arma.SetProficiencia(IdPersonagem, profarma);
            _db.Proficiencias_Armas.Add(proficiencia_arma);
        }
        foreach (var profarmadura in profarmaduras)
        {
            var proficiencia_armadura = new Proficiencia_Armadura();
            proficiencia_armadura.SetProficiencia(IdPersonagem, profarmadura);
            _db.Proficiencias_Armaduras.Add(proficiencia_armadura);
        }
        foreach (var profitem in profitens)
        {
            var proficiencia_item = new Proficiencia_Item();
            proficiencia_item.SetProficiencia(IdPersonagem, profitem);
            _db.Proficiencias_Itens.Add(proficiencia_item);
        }
        foreach (var profarma in profarmas)
        {
            var proficiencia_arma = new Proficiencia_Arma();
            proficiencia_arma.SetProficiencia(IdPersonagem, profarma);
            _db.Proficiencias_Armas.Add(proficiencia_arma);
        }
        foreach (var profarmatipo in profarmastipos)
        {
            var proficiencia_armatipo = new Proficiencia_Arma();
            proficiencia_armatipo.SetProficienciaTipo(IdPersonagem, profarmatipo);
            _db.Proficiencias_Armas.Add(proficiencia_armatipo);
        }
        foreach (var profarmaduratipo in profarmadurastipos)
        {
            var proficiencia_armaduratipo = new Proficiencia_Armadura();
            proficiencia_armaduratipo.SetProficienciaTipo(IdPersonagem, profarmaduratipo);
            _db.Proficiencias_Armaduras.Add(proficiencia_armaduratipo);
        }

        varoriginal.IdClasse = personagem.IdClasse;
        varoriginal.DefinirBonusdeProficiencia();
        varoriginal.DefinirDinheiro(personagem.IdClasse);
        _db.SaveChanges();
        return RedirectToAction("Escolher", "Atributo", new { personagem.IdPersonagem });
    }
}