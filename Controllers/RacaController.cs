using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Projeto.Controllers;

public class RacaController : Controller
{
    private DataContext _db;
    public RacaController(DataContext db)
    {
        _db = db;
    }

    [HttpGet]
    public ActionResult Escolher(int IdPersonagem)
    {
        ViewBagdeCria();
        var personagem = _db.Personagens.Find(IdPersonagem);
        if(personagem is null){
            return View(personagem);
        }
        return View(personagem);
    }

    private void ViewBagdeCria()
    {
        var listaraca = _db.Racas.AsNoTracking().ToList();
        var listasubraca = _db.SubRacas.AsNoTracking().ToList();
        var listahabilidade = _db.HabilidadesRaciais.AsNoTracking().ToList();
        var listahabilidaderaca = _db.HabilidadesRaciais_Racas.AsNoTracking().ToList();
        var listahabilidadesubraca = _db.HabilidadesRaciais_SubRacas.AsNoTracking().ToList();
        ViewBag.listaraca = listaraca;
        ViewBag.listasubraca = listasubraca;
        ViewBag.listahabilidade = listahabilidade;
        ViewBag.listahabilidaderaca = listahabilidaderaca;
        ViewBag.listahabilidadesubraca = listahabilidadesubraca;
    }
    [HttpPost]
    public ActionResult Escolher(int IdPersonagem, Personagem personagem)
    {

        List<int> armas = new List<int>();
        List<int> armaduras = new List<int>();
        List<int> itens = new List<int>();

        if(personagem.IdRaca == 1){
          armas.AddRange(new int[]{8, 25, 9, 28});
        }

        if(personagem.IdSubRaca == 2){
            armaduras.AddRange(new int[]{1, 2, 3, 4, 5, 6, 7, 8});
          }
          else if(personagem.IdSubRaca == 3){
            armas.AddRange(new int[]{18, 20, 11, 32});
          }
          else if(personagem.IdSubRaca == 4){
            armas.AddRange(new int[]{18, 20, 11, 32});
          }
          else if(personagem.IdSubRaca == 5){
            armas.AddRange(new int[] {30, 18, 33});
          }

        var varoriginal = _db.Personagens.Find(IdPersonagem);
        if (varoriginal is null)
        {
            return RedirectToAction("Index");
        }
        foreach (var arma in armas)
        {
            var proficiencia_arma = new Proficiencia_Arma();
            var armasoriginal = armas;
            if (armasoriginal is null)
            {
                return RedirectToAction("Index");
            }
            
            proficiencia_arma.SetProficiencia(IdPersonagem, arma);
            _db.Proficiencias_Armas.Add(proficiencia_arma);
        }
        foreach (var armadura in armaduras)
        {
            var proficiencia_armadura = new Proficiencia_Armadura();
            var armadurasoriginal = armaduras;
            if (armadurasoriginal is null)
            {
                return RedirectToAction("Index");
            }
            
            proficiencia_armadura.SetProficiencia(IdPersonagem, armadura);
            _db.Proficiencias_Armaduras.Add(proficiencia_armadura);
        }
        foreach (var item in itens)
        {
            var proficiencia_item = new Proficiencia_Item();
            var itensoriginal = itens;
            if (itensoriginal is null)
            {
                return RedirectToAction("Index");
            }
            
            proficiencia_item.SetProficiencia(IdPersonagem, item);
            _db.Proficiencias_Itens.Add(proficiencia_item);
        }

        // if (personagem.IdSubRaca is null)
        // {
        //     ViewBagdeCria();
        //     return View(personagem);
        // }
        
        varoriginal.IdRaca = personagem.IdRaca;
        varoriginal.IdSubRaca = personagem.IdSubRaca;
        _db.SaveChanges();
        return RedirectToAction("Escolher", "Classe", new { personagem.IdPersonagem });
    }
}